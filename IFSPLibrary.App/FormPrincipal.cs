using IFSPLibrary.App.Cadastros;
using IFSPStore.App.Infra;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFSPLibrary.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();

        }


        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void crownContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroLivro>();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroCliente>();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroAutor>();
        }

        private void editoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroEditora>();
        }

        private void emprestimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroEmprestimo>();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadstrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}
