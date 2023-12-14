namespace IFSPLibrary.App.Cadastros
{
    partial class CadastroEmprestimo
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
            txtDataEmprestimo = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDataDevolucao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            groupBox1 = new GroupBox();
            dataGridViewLivros = new DataGridView();
            btnAdicionar = new ReaLTaiizor.Controls.MaterialButton();
            cboLivro = new ReaLTaiizor.Controls.MaterialComboBox();
            txtQuantidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLivros).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(794, 383);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(groupBox1);
            tabPageCadastro.Controls.Add(cboCliente);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtDataDevolucao);
            tabPageCadastro.Controls.Add(txtDataEmprestimo);
            tabPageCadastro.Size = new Size(786, 348);
            tabPageCadastro.Controls.SetChildIndex(txtDataEmprestimo, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataDevolucao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCliente, 0);
            tabPageCadastro.Controls.SetChildIndex(groupBox1, 0);
            // 
            // txtDataEmprestimo
            // 
            txtDataEmprestimo.AllowPromptAsInput = true;
            txtDataEmprestimo.AnimateReadOnly = false;
            txtDataEmprestimo.AsciiOnly = false;
            txtDataEmprestimo.BackgroundImageLayout = ImageLayout.None;
            txtDataEmprestimo.BeepOnError = false;
            txtDataEmprestimo.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataEmprestimo.Depth = 0;
            txtDataEmprestimo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataEmprestimo.HidePromptOnLeave = false;
            txtDataEmprestimo.HideSelection = true;
            txtDataEmprestimo.Hint = "Data Emprestimo";
            txtDataEmprestimo.InsertKeyMode = InsertKeyMode.Default;
            txtDataEmprestimo.LeadingIcon = null;
            txtDataEmprestimo.Location = new Point(3, 3);
            txtDataEmprestimo.Mask = "99/99/9999";
            txtDataEmprestimo.MaxLength = 32767;
            txtDataEmprestimo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataEmprestimo.Name = "txtDataEmprestimo";
            txtDataEmprestimo.PasswordChar = '\0';
            txtDataEmprestimo.PrefixSuffixText = null;
            txtDataEmprestimo.PromptChar = '_';
            txtDataEmprestimo.ReadOnly = false;
            txtDataEmprestimo.RejectInputOnFirstFailure = false;
            txtDataEmprestimo.ResetOnPrompt = true;
            txtDataEmprestimo.ResetOnSpace = true;
            txtDataEmprestimo.RightToLeft = RightToLeft.No;
            txtDataEmprestimo.SelectedText = "";
            txtDataEmprestimo.SelectionLength = 0;
            txtDataEmprestimo.SelectionStart = 0;
            txtDataEmprestimo.ShortcutsEnabled = true;
            txtDataEmprestimo.Size = new Size(195, 48);
            txtDataEmprestimo.SkipLiterals = true;
            txtDataEmprestimo.TabIndex = 11;
            txtDataEmprestimo.TabStop = false;
            txtDataEmprestimo.Text = "  /  /";
            txtDataEmprestimo.TextAlign = HorizontalAlignment.Center;
            txtDataEmprestimo.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataEmprestimo.TrailingIcon = null;
            txtDataEmprestimo.UseSystemPasswordChar = false;
            txtDataEmprestimo.ValidatingType = null;
            // 
            // txtDataDevolucao
            // 
            txtDataDevolucao.AllowPromptAsInput = true;
            txtDataDevolucao.AnimateReadOnly = false;
            txtDataDevolucao.AsciiOnly = false;
            txtDataDevolucao.BackgroundImageLayout = ImageLayout.None;
            txtDataDevolucao.BeepOnError = false;
            txtDataDevolucao.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataDevolucao.Depth = 0;
            txtDataDevolucao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataDevolucao.HidePromptOnLeave = false;
            txtDataDevolucao.HideSelection = true;
            txtDataDevolucao.Hint = "Data devolução";
            txtDataDevolucao.InsertKeyMode = InsertKeyMode.Default;
            txtDataDevolucao.LeadingIcon = null;
            txtDataDevolucao.Location = new Point(217, 3);
            txtDataDevolucao.Mask = "99/99/9999";
            txtDataDevolucao.MaxLength = 32767;
            txtDataDevolucao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataDevolucao.Name = "txtDataDevolucao";
            txtDataDevolucao.PasswordChar = '\0';
            txtDataDevolucao.PrefixSuffixText = null;
            txtDataDevolucao.PromptChar = '_';
            txtDataDevolucao.ReadOnly = false;
            txtDataDevolucao.RejectInputOnFirstFailure = false;
            txtDataDevolucao.ResetOnPrompt = true;
            txtDataDevolucao.ResetOnSpace = true;
            txtDataDevolucao.RightToLeft = RightToLeft.No;
            txtDataDevolucao.SelectedText = "";
            txtDataDevolucao.SelectionLength = 0;
            txtDataDevolucao.SelectionStart = 0;
            txtDataDevolucao.ShortcutsEnabled = true;
            txtDataDevolucao.Size = new Size(195, 48);
            txtDataDevolucao.SkipLiterals = true;
            txtDataDevolucao.TabIndex = 12;
            txtDataDevolucao.TabStop = false;
            txtDataDevolucao.Text = "  /  /";
            txtDataDevolucao.TextAlign = HorizontalAlignment.Center;
            txtDataDevolucao.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataDevolucao.TrailingIcon = null;
            txtDataDevolucao.UseSystemPasswordChar = false;
            txtDataDevolucao.ValidatingType = null;
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
            txtId.Location = new Point(432, 3);
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
            txtId.Size = new Size(107, 48);
            txtId.TabIndex = 13;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cboCliente
            // 
            cboCliente.AutoResize = false;
            cboCliente.BackColor = Color.FromArgb(255, 255, 255);
            cboCliente.Depth = 0;
            cboCliente.DrawMode = DrawMode.OwnerDrawVariable;
            cboCliente.DropDownHeight = 174;
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.DropDownWidth = 121;
            cboCliente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCliente.FormattingEnabled = true;
            cboCliente.Hint = "Cliente";
            cboCliente.IntegralHeight = false;
            cboCliente.ItemHeight = 43;
            cboCliente.Location = new Point(3, 57);
            cboCliente.MaxDropDownItems = 4;
            cboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(774, 49);
            cboCliente.StartIndex = 0;
            cboCliente.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtQuantidade);
            groupBox1.Controls.Add(dataGridViewLivros);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(cboLivro);
            groupBox1.Location = new Point(6, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(774, 179);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Livros do Emprestimo";
            // 
            // dataGridViewLivros
            // 
            dataGridViewLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLivros.Location = new Point(6, 77);
            dataGridViewLivros.Name = "dataGridViewLivros";
            dataGridViewLivros.RowTemplate.Height = 25;
            dataGridViewLivros.Size = new Size(768, 89);
            dataGridViewLivros.TabIndex = 6;
            // 
            // btnAdicionar
            // 
            btnAdicionar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdicionar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdicionar.Depth = 0;
            btnAdicionar.HighEmphasis = true;
            btnAdicionar.Icon = null;
            btnAdicionar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAdicionar.Location = new Point(710, 35);
            btnAdicionar.Margin = new Padding(4, 6, 4, 6);
            btnAdicionar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.NoAccentTextColor = Color.Empty;
            btnAdicionar.Size = new Size(64, 36);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "+";
            btnAdicionar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdicionar.UseAccentColor = false;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // cboLivro
            // 
            cboLivro.AutoResize = false;
            cboLivro.BackColor = Color.FromArgb(255, 255, 255);
            cboLivro.Depth = 0;
            cboLivro.DrawMode = DrawMode.OwnerDrawVariable;
            cboLivro.DropDownHeight = 174;
            cboLivro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLivro.DropDownWidth = 121;
            cboLivro.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboLivro.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboLivro.FormattingEnabled = true;
            cboLivro.Hint = "Livros";
            cboLivro.IntegralHeight = false;
            cboLivro.ItemHeight = 43;
            cboLivro.Location = new Point(6, 22);
            cboLivro.MaxDropDownItems = 4;
            cboLivro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboLivro.Name = "cboLivro";
            cboLivro.Size = new Size(615, 49);
            cboLivro.StartIndex = 0;
            cboLivro.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            txtQuantidade.AnimateReadOnly = false;
            txtQuantidade.AutoCompleteMode = AutoCompleteMode.None;
            txtQuantidade.AutoCompleteSource = AutoCompleteSource.None;
            txtQuantidade.BackgroundImageLayout = ImageLayout.None;
            txtQuantidade.CharacterCasing = CharacterCasing.Normal;
            txtQuantidade.Depth = 0;
            txtQuantidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantidade.HideSelection = true;
            txtQuantidade.Hint = "Qtd";
            txtQuantidade.LeadingIcon = null;
            txtQuantidade.Location = new Point(627, 23);
            txtQuantidade.MaxLength = 32767;
            txtQuantidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PasswordChar = '\0';
            txtQuantidade.PrefixSuffixText = null;
            txtQuantidade.ReadOnly = false;
            txtQuantidade.RightToLeft = RightToLeft.No;
            txtQuantidade.SelectedText = "";
            txtQuantidade.SelectionLength = 0;
            txtQuantidade.SelectionStart = 0;
            txtQuantidade.ShortcutsEnabled = true;
            txtQuantidade.Size = new Size(76, 48);
            txtQuantidade.TabIndex = 7;
            txtQuantidade.TabStop = false;
            txtQuantidade.TextAlign = HorizontalAlignment.Left;
            txtQuantidade.TrailingIcon = null;
            txtQuantidade.UseSystemPasswordChar = false;
            // 
            // RegisterEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "RegisterEmprestimo";
            Text = "Cadastro de Emprestimo";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLivros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataEmprestimo;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataDevolucao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboCliente;
        private GroupBox groupBox1;
        private DataGridView dataGridViewLivros;
        private ReaLTaiizor.Controls.MaterialButton btnAdicionar;
        private ReaLTaiizor.Controls.MaterialComboBox cboLivro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantidade;
    }
}