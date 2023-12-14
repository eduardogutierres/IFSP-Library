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
    public partial class CadastroEditora : CadastroBase
    {
        private readonly IBaseService<Editora> _editoraService;
        private readonly IBaseService<Livro> _livroService;

        private List<EditoraModel>? editoras;
        public CadastroEditora(IBaseService<Editora> editoraService)
        {
            _editoraService = editoraService;
            InitializeComponent();
        }

        private void PreencheObjeto(Editora editora)
        {
            editora.Nome = txtNome.Text;
            editora.Localizacao = txtLocalizacao.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var editora = _editoraService.GetById<Editora>(id);
                        PreencheObjeto(editora);
                        _editoraService.Update<Editora, Editora, EditoraValidator>(editora);
                    }
                }
                else
                {
                    var editora = new Editora();
                    PreencheObjeto(editora);
                    _editoraService.Add<Editora, Editora, EditoraValidator>(editora);

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
                 _editoraService.Delete(id);
             }
             catch (Exception ex)
             {
                 MessageBox.Show($"Erro: {ex.Message}\nInner Exception: {ex.InnerException?.Message}", @"IFSP Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }


         }

        protected override void CarregaGrid()
        {
            editoras = _editoraService.Get<EditoraModel>().ToList();
            dataGridViewConsulta.DataSource = editoras;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
        }
    }
}
