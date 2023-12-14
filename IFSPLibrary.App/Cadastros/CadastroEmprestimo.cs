using IFSPLibrary.App.Base;
using IFSPLibrary.App.Models;
using IFSPLibrary.domain.Base;
using IFSPLibrary.domain.Entities;
using IFSPLibrary.Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace IFSPLibrary.App.Cadastros
{
    public partial class CadastroEmprestimo : CadastroBase
    {
        private List<EmprestimoItemModel> _emprestimoItems;
        private readonly IBaseService<Cliente> _clienteService;
        private readonly IBaseService<Livro> _livroService;
        private readonly IBaseService<Emprestimo> _emprestimoService;
        private readonly IBaseService<Autor> _autorService;

        private List<EmprestimoModel>? _emprestimos;

        public CadastroEmprestimo(IBaseService<Emprestimo> emprestimoService, IBaseService<Autor> autorService,
                             IBaseService<Editora> editoraService, IBaseService<Cliente> clienteService, IBaseService<Livro> livroService)
        {
            _emprestimoService = emprestimoService;
            _autorService = autorService;
            _clienteService = clienteService;
            _livroService = livroService;
            _emprestimoItems = new List<EmprestimoItemModel>();
            InitializeComponent();
            CarregarCombo();
            CarregaGridItensEmprestimo();
            Novo();
        }

        private void CarregarCombo()
        {
            cboCliente.ValueMember = "Id";
            cboCliente.DisplayMember = "Nome";
            cboCliente.DataSource = _clienteService.Get<Cliente>().ToList();

            cboLivro.ValueMember = "Id";
            cboLivro.DisplayMember = "Titulo"; 
            cboLivro.DataSource = _livroService.Get<Livro>().ToList();
        }

        private void PreencheObjeto(Emprestimo emprestimo)
        {
            if (DateTime.TryParseExact(txtDataEmprestimo.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out var dataEmprestimo))
            {
                emprestimo.DataEmprestimo = dataEmprestimo;
            }

            if (int.TryParse(cboCliente.SelectedValue.ToString(), out var idCliente))
            {
                var cliente = _clienteService.GetById<Cliente>(idCliente);
                emprestimo.Cliente = cliente;
            }

            
            if (DateTime.TryParseExact(txtDataDevolucao.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dataDevolucao))
            {
                emprestimo.DataDevolucao = dataDevolucao;
            }
            else
            {
                MessageBox.Show("Data de devolução inválida. Certifique-se de usar o formato dd/MM/yyyy.", "Erro de Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var item in _emprestimoItems)
            {
                var itemEmprestimo = new EmprestimoLivro
                {
                    Emprestimo = emprestimo,
                    Livro = _livroService.GetById<Livro>(item.IdLivro),
                    Quantidade = item.Quantidade,
                };

                emprestimo.Livros.Add(itemEmprestimo);
            }
        }

        protected override void Novo()
        {
            base.Novo();
            _emprestimoItems.Clear();
            CarregaGridItensEmprestimo();
            txtDataEmprestimo.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var emprestimo = _emprestimoService.GetById<Emprestimo>(id);
                        PreencheObjeto(emprestimo);
                        emprestimo = _emprestimoService.Update<Emprestimo, Emprestimo, EmprestimoValidator>(emprestimo);
                    }
                }
                else
                {
                    var emprestimo = new Emprestimo();
                    PreencheObjeto(emprestimo);
                    emprestimo = _emprestimoService.Add<Emprestimo, Emprestimo, EmprestimoValidator>(emprestimo);
                }

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _emprestimoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 

        protected override void CarregaGrid()
        {
            
            var includes = new List<string>() { "Cliente", "Livros" };
            _emprestimos = _emprestimoService.Get<EmprestimoModel>(includes).ToList();
            dataGridViewConsulta.DataSource = _emprestimos;
          /*
            if (dataGridViewConsulta.Columns.Contains("Id"))
            {
                dataGridViewConsulta.Columns["Id"].Visible = false;
            }
          */
           
            if (dataGridViewConsulta.Columns.Contains("Livros"))
            {
                dataGridViewConsulta.Columns["Livros"].Visible = false;
            }
            /*
            if (dataGridViewConsulta.Columns.Contains("Cliente"))
            {
                dataGridViewConsulta.Columns["Cliente"].Visible = false;
            }
            */
           
            
        }



        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            int.TryParse(linha?.Cells["Id"].Value.ToString(), out var id);
            txtId.Text = linha?.Cells["Id"].Value.ToString();

            
            //int livroId = Convert.ToInt32(linha?.Cells["Livro"].Value);
            //var livroSelecionado = _livroService.GetById<Livro>(livroId);
            //cboLivro.SelectedItem = livroSelecionado;

            
            cboCliente.SelectedValue = linha?.Cells["Cliente"].Value;
            txtDataEmprestimo.Text = DateTime.TryParseExact(linha?.Cells[1].Value?.ToString(), "g", null, DateTimeStyles.None, out var dataC)
            ? dataC.ToString("dd/MM/yyyy")
            : "";


            var includes = new List<string>() { "Cliente", "Livros" };
            var emprestimo = _emprestimoService.GetById<Emprestimo>(id, includes);
            _emprestimoItems = new List<EmprestimoItemModel>();
            foreach (var item in emprestimo.Livros)
            {
                var emprestimoItem = new EmprestimoItemModel
                {
                    Id = item.Id,
                    IdLivro = item.Livro!.Id,
                    Livro = item.Livro!.Titulo,                   
                    Quantidade = item.Quantidade,
                };
                _emprestimoItems.Add(emprestimoItem);              
            }

            
            CarregaGridItensEmprestimo();
        }



        private void CarregaGridItensEmprestimo()
        {
            var source = new BindingSource();
            if (_emprestimoItems == null)
            {
                _emprestimoItems = new List<EmprestimoItemModel>();
            }
            source.DataSource = _emprestimoItems.ToArray();
            dataGridViewLivros.DataSource = source;
            dataGridViewLivros.Columns["Id"].Visible = false;
            dataGridViewLivros.Columns["IdLivro"].HeaderText = "Id.Livro";
            dataGridViewLivros.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidaItem())
            {
                var emprestimoLivro = new EmprestimoItemModel();
                if (int.TryParse(cboLivro.SelectedValue.ToString(), out var idLivro))
                {
                    var livro = _livroService.GetById<Livro>(idLivro);
                    emprestimoLivro.IdLivro = livro.Id;
                    emprestimoLivro.Livro = livro.Titulo;
                }

                if (int.TryParse(txtQuantidade.Text, out var qtd))
                {
                    emprestimoLivro.Quantidade = qtd;
                }
                _emprestimoItems.Add(emprestimoLivro);
                CarregaGridItensEmprestimo();
            }
        }

        private bool ValidaItem()
        {
            
            return true;
        }
    }
}
