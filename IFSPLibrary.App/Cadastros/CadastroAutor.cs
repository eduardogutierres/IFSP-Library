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
    public partial class CadastroAutor : CadastroBase
    {
        private readonly IBaseService<Autor> _autorService;

        private List<AutorModel>? autores;
        public CadastroAutor(IBaseService<Autor> autorService)
        {
            _autorService = autorService;
            InitializeComponent();
        }

        private void PreencheObjeto(Autor autor)
        {
            autor.Nome = txtNome.Text;
            autor.Biografia = txtBiografia.Text;
        }


        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var autor = _autorService.GetById<Autor>(id);
                        PreencheObjeto(autor);
                        autor = _autorService.Update<Autor, Autor, AutorValidator>(autor);
                    }
                }
                else
                {
                    var autor = new Autor();
                    PreencheObjeto(autor);
                    _autorService.Add<Autor, Autor, AutorValidator>(autor);

                }

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP library", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _autorService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            autores = _autorService.Get<AutorModel>().ToList();
            dataGridViewConsulta.DataSource = autores;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtBiografia.Text = linha?.Cells["Biografia"].Value.ToString();
        }
    }
}
