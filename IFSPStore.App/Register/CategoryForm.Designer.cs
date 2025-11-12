namespace IFSPStore.App.Register
{
    partial class CategoryForm
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
            mtbName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mtbId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mtbDescription = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            tabPageList.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(mtbDescription);
            tabPageRegister.Controls.Add(mtbId);
            tabPageRegister.Controls.Add(mtbName);
            tabPageRegister.Location = new Point(4, 29);
            tabPageRegister.Size = new Size(736, 452);
            tabPageRegister.Controls.SetChildIndex(btnCancel, 0);
            tabPageRegister.Controls.SetChildIndex(btnSave, 0);
            tabPageRegister.Controls.SetChildIndex(mtbName, 0);
            tabPageRegister.Controls.SetChildIndex(mtbId, 0);
            tabPageRegister.Controls.SetChildIndex(mtbDescription, 0);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(652, 407);
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(567, 407);
            // 
            // btnNew
            // 
            btnNew.Location = new Point(665, 405);
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(657, 405);
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(593, 405);
            // 
            // tabControlRegister
            // 
            tabControlRegister.ImageList = null;
            tabControlRegister.Size = new Size(744, 485);
            // 
            // tabPageList
            // 
            tabPageList.Location = new Point(4, 29);
            tabPageList.Size = new Size(736, 452);
            // 
            // mtbName
            // 
            mtbName.AnimateReadOnly = false;
            mtbName.AutoCompleteMode = AutoCompleteMode.None;
            mtbName.AutoCompleteSource = AutoCompleteSource.None;
            mtbName.BackgroundImageLayout = ImageLayout.None;
            mtbName.CharacterCasing = CharacterCasing.Normal;
            mtbName.Depth = 0;
            mtbName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbName.HideSelection = true;
            mtbName.Hint = "Name";
            mtbName.LeadingIcon = null;
            mtbName.Location = new Point(22, 31);
            mtbName.MaxLength = 32767;
            mtbName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbName.Name = "mtbName";
            mtbName.PasswordChar = '\0';
            mtbName.PrefixSuffixText = null;
            mtbName.ReadOnly = false;
            mtbName.RightToLeft = RightToLeft.No;
            mtbName.SelectedText = "";
            mtbName.SelectionLength = 0;
            mtbName.SelectionStart = 0;
            mtbName.ShortcutsEnabled = true;
            mtbName.Size = new Size(534, 48);
            mtbName.TabIndex = 2;
            mtbName.TabStop = false;
            mtbName.TextAlign = HorizontalAlignment.Left;
            mtbName.TrailingIcon = null;
            mtbName.UseSystemPasswordChar = false;
            // 
            // mtbId
            // 
            mtbId.AnimateReadOnly = false;
            mtbId.AutoCompleteMode = AutoCompleteMode.None;
            mtbId.AutoCompleteSource = AutoCompleteSource.None;
            mtbId.BackgroundImageLayout = ImageLayout.None;
            mtbId.CharacterCasing = CharacterCasing.Normal;
            mtbId.Depth = 0;
            mtbId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbId.HideSelection = true;
            mtbId.Hint = "Id";
            mtbId.LeadingIcon = null;
            mtbId.Location = new Point(610, 31);
            mtbId.MaxLength = 32767;
            mtbId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbId.Name = "mtbId";
            mtbId.PasswordChar = '\0';
            mtbId.PrefixSuffixText = null;
            mtbId.ReadOnly = true;
            mtbId.RightToLeft = RightToLeft.No;
            mtbId.SelectedText = "";
            mtbId.SelectionLength = 0;
            mtbId.SelectionStart = 0;
            mtbId.ShortcutsEnabled = true;
            mtbId.Size = new Size(106, 48);
            mtbId.TabIndex = 3;
            mtbId.TabStop = false;
            mtbId.TextAlign = HorizontalAlignment.Left;
            mtbId.TrailingIcon = null;
            mtbId.UseSystemPasswordChar = false;
            // 
            // mtbDescription
            // 
            mtbDescription.AnimateReadOnly = false;
            mtbDescription.AutoCompleteMode = AutoCompleteMode.None;
            mtbDescription.AutoCompleteSource = AutoCompleteSource.None;
            mtbDescription.BackgroundImageLayout = ImageLayout.None;
            mtbDescription.CharacterCasing = CharacterCasing.Normal;
            mtbDescription.Depth = 0;
            mtbDescription.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbDescription.HideSelection = true;
            mtbDescription.Hint = "Description";
            mtbDescription.LeadingIcon = null;
            mtbDescription.Location = new Point(22, 98);
            mtbDescription.MaxLength = 32767;
            mtbDescription.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbDescription.Name = "mtbDescription";
            mtbDescription.PasswordChar = '\0';
            mtbDescription.PrefixSuffixText = null;
            mtbDescription.ReadOnly = false;
            mtbDescription.RightToLeft = RightToLeft.No;
            mtbDescription.SelectedText = "";
            mtbDescription.SelectionLength = 0;
            mtbDescription.SelectionStart = 0;
            mtbDescription.ShortcutsEnabled = true;
            mtbDescription.Size = new Size(694, 48);
            mtbDescription.TabIndex = 4;
            mtbDescription.TabStop = false;
            mtbDescription.TextAlign = HorizontalAlignment.Left;
            mtbDescription.TrailingIcon = null;
            mtbDescription.UseSystemPasswordChar = false;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 552);
            DrawerTabControl = tabControlRegister;
            Location = new Point(0, 0);
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category Register";
            tabPageRegister.ResumeLayout(false);
            tabPageRegister.PerformLayout();
            tabControlRegister.ResumeLayout(false);
            tabPageList.ResumeLayout(false);
            tabPageList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbDescription;
    }
}