﻿namespace IFSPLibrary.App.Cadastros
{
    partial class CadastroAutor
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
            txtBiografia = new ReaLTaiizor.Controls.MetroTextBox();
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
            tabPageCadastro.Controls.Add(txtBiografia);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Size = new Size(786, 348);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBiografia, 0);
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
            txtNome.Hint = "Nome";
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
            txtNome.Size = new Size(682, 48);
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
            txtId.Location = new Point(694, 3);
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
            // txtBiografia
            // 
            txtBiografia.AutoCompleteCustomSource = null;
            txtBiografia.AutoCompleteMode = AutoCompleteMode.None;
            txtBiografia.AutoCompleteSource = AutoCompleteSource.None;
            txtBiografia.BorderColor = Color.FromArgb(155, 155, 155);
            txtBiografia.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtBiografia.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtBiografia.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtBiografia.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBiografia.HoverColor = Color.FromArgb(102, 102, 102);
            txtBiografia.Image = null;
            txtBiografia.IsDerivedStyle = true;
            txtBiografia.Lines = null;
            txtBiografia.Location = new Point(6, 57);
            txtBiografia.MaxLength = 32767;
            txtBiografia.Multiline = false;
            txtBiografia.Name = "txtBiografia";
            txtBiografia.ReadOnly = false;
            txtBiografia.Size = new Size(774, 234);
            txtBiografia.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            txtBiografia.StyleManager = null;
            txtBiografia.TabIndex = 13;
            txtBiografia.Text = "Biografia";
            txtBiografia.TextAlign = HorizontalAlignment.Left;
            txtBiografia.ThemeAuthor = "Taiizor";
            txtBiografia.ThemeName = "MetroLight";
            txtBiografia.UseSystemPasswordChar = false;
            txtBiografia.WatermarkText = "";
            // 
            // RegisterAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "RegisterAutor";
            Text = "Cadastro de Autor";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MetroTextBox txtBiografia;
    }
}