using IFSPLibrary.App.Base;
using IFSPLibrary.App.Models;
using IFSPLibrary.domain.Base;
using IFSPLibrary.domain.Entities;
using IFSPLibrary.Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFSPLibrary.App.Cadastros
{
    public partial class CadastroLivro : CadastroBase
    {
        private readonly IBaseService<Livro> _livroService;
        private readonly IBaseService<Autor> _autorService;
        private readonly IBaseService<Editora> _editoraService;
        private List<LivroModel> livro;
        private object livros;
        private object editoras;
        private object autores;

        public CadastroLivro(IBaseService<Livro> livroService, IBaseService<Autor> autorService, IBaseService<Editora> editoraService)
        {
            _livroService = livroService;
            _autorService = autorService;
            _editoraService = editoraService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboAutor.ValueMember = "Id";
            cboAutor.DisplayMember = "Nome";
            cboAutor.DataSource = _autorService.Get<Autor>().ToList();

            cboEditora.ValueMember = "Id";
            cboEditora.DisplayMember = "Nome";
            cboEditora.DataSource = _editoraService.Get<Editora>().ToList();
        }

        private void PreencheObjeto(Livro livro)
        {
            livro.Titulo = txtNome.Text;

            if (int.TryParse(cboAutor.SelectedValue.ToString(), out var idAutor))
            {
                var autor = _autorService.GetById<Autor>(idAutor);
                // Atualize as propriedades corretas do objeto Autor
                autor.Nome = autor.Nome; // Substitua pelo valor correto
                                                   // Exemplo: autor.DataNascimento = DateTime.Now;

                // Atualiza a propriedade Autor do objeto Livro
                livro.Autor = autor;
            }

            // Antes
            // livro.AnoPublicacao = txtAnoPublicacao.Text;

            // Depois
            if (int.TryParse(txtAnoPublicacao.Text, out int anoPublicacao))
            {
                livro.AnoPublicacao = anoPublicacao;
            }
            else
            {
                MessageBox.Show("O ano de publicação deve ser um número inteiro válido.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (int.TryParse(cboEditora.SelectedValue.ToString(), out var idEditora))
            {
                var editora = _editoraService.GetById<Editora>(idEditora);
                // Atualize as propriedades corretas do objeto Editora
                editora.Nome = editora.Nome; // Substitua pelo valor correto
                                                       // Exemplo: editora.Endereco = "Novo Endereço da Editora";

                // Atualiza a propriedade Editora do objeto Livro
                livro.Editora = editora;
            }
        }


        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var livro = _livroService.GetById<Livro>(id);
                        PreencheObjeto(livro);
                        livro = _livroService.Update<Livro, Livro, LivroValidator>(livro);
                    }
                }
                else
                {
                    var livro = new Livro();
                    PreencheObjeto(livro);
                    _livroService.Add<Livro, Livro, LivroValidator>(livro);

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
                _livroService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            livros = _livroService.Get<LivroModel>().ToList();
            dataGridViewConsulta.DataSource = livros;

            // Verifica se a coluna existe antes de acessá-la
            if (dataGridViewConsulta.Columns["Nome"] != null)
            {
                dataGridViewConsulta.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }




        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Titulo"].Value.ToString();
            txtAnoPublicacao.Text = linha?.Cells["AnoPublicacao"].Value.ToString();
            //cboAutor.SelectedValue = linha?.Cells["Autor"].Value;
            //cboEditora.SelectedValue = linha?.Cells["Editora"].Value;
        }
    }
}
