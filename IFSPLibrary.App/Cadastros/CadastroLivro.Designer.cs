namespace IFSPLibrary.App.Cadastros
{
    partial class CadastroLivro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAnoPublicacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboAutor = new ReaLTaiizor.Controls.MaterialComboBox();
            cboEditora = new ReaLTaiizor.Controls.MaterialComboBox();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(794, 383);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboEditora);
            tabPageCadastro.Controls.Add(cboAutor);
            tabPageCadastro.Controls.Add(txtAnoPublicacao);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Size = new Size(786, 348);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtAnoPublicacao, 0);
            tabPageCadastro.Controls.SetChildIndex(cboAutor, 0);
            tabPageCadastro.Controls.SetChildIndex(cboEditora, 0);
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Título";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(3, 3);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(586, 48);
            txtNome.TabIndex = 11;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(597, 3);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(89, 48);
            txtId.TabIndex = 12;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtAnoPublicacao
            // 
            txtAnoPublicacao.AnimateReadOnly = false;
            txtAnoPublicacao.AutoCompleteMode = AutoCompleteMode.None;
            txtAnoPublicacao.AutoCompleteSource = AutoCompleteSource.None;
            txtAnoPublicacao.BackgroundImageLayout = ImageLayout.None;
            txtAnoPublicacao.CharacterCasing = CharacterCasing.Normal;
            txtAnoPublicacao.Depth = 0;
            txtAnoPublicacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAnoPublicacao.HideSelection = true;
            txtAnoPublicacao.Hint = "Ano";
            txtAnoPublicacao.LeadingIcon = null;
            txtAnoPublicacao.Location = new Point(694, 3);
            txtAnoPublicacao.MaxLength = 32767;
            txtAnoPublicacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAnoPublicacao.Name = "txtAnoPublicacao";
            txtAnoPublicacao.PasswordChar = '\0';
            txtAnoPublicacao.PrefixSuffixText = null;
            txtAnoPublicacao.ReadOnly = false;
            txtAnoPublicacao.RightToLeft = RightToLeft.No;
            txtAnoPublicacao.SelectedText = "";
            txtAnoPublicacao.SelectionLength = 0;
            txtAnoPublicacao.SelectionStart = 0;
            txtAnoPublicacao.ShortcutsEnabled = true;
            txtAnoPublicacao.Size = new Size(87, 48);
            txtAnoPublicacao.TabIndex = 13;
            txtAnoPublicacao.TabStop = false;
            txtAnoPublicacao.TextAlign = HorizontalAlignment.Left;
            txtAnoPublicacao.TrailingIcon = null;
            txtAnoPublicacao.UseSystemPasswordChar = false;
            // 
            // cboAutor
            // 
            cboAutor.AutoResize = false;
            cboAutor.BackColor = Color.FromArgb(255, 255, 255);
            cboAutor.Depth = 0;
            cboAutor.DrawMode = DrawMode.OwnerDrawVariable;
            cboAutor.DropDownHeight = 174;
            cboAutor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAutor.DropDownWidth = 121;
            cboAutor.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAutor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAutor.FormattingEnabled = true;
            cboAutor.Hint = "Autor";
            cboAutor.IntegralHeight = false;
            cboAutor.ItemHeight = 43;
            cboAutor.Location = new Point(3, 57);
            cboAutor.MaxDropDownItems = 4;
            cboAutor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAutor.Name = "cboAutor";
            cboAutor.Size = new Size(778, 49);
            cboAutor.StartIndex = 0;
            cboAutor.TabIndex = 14;
            // 
            // cboEditora
            // 
            cboEditora.AutoResize = false;
            cboEditora.BackColor = Color.FromArgb(255, 255, 255);
            cboEditora.Depth = 0;
            cboEditora.DrawMode = DrawMode.OwnerDrawVariable;
            cboEditora.DropDownHeight = 174;
            cboEditora.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEditora.DropDownWidth = 121;
            cboEditora.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEditora.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEditora.FormattingEnabled = true;
            cboEditora.Hint = "Editora";
            cboEditora.IntegralHeight = false;
            cboEditora.ItemHeight = 43;
            cboEditora.Location = new Point(3, 112);
            cboEditora.MaxDropDownItems = 4;
            cboEditora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEditora.Name = "cboEditora";
            cboEditora.Size = new Size(778, 49);
            cboEditora.StartIndex = 0;
            cboEditora.TabIndex = 15;
            // 
            // RegisterLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "RegisterLivro";
            Text = "Cadastro de Livro";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAnoPublicacao;
        private ReaLTaiizor.Controls.MaterialComboBox cboEditora;
        private ReaLTaiizor.Controls.MaterialComboBox cboAutor;
    }
}