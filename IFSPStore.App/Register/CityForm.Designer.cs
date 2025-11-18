namespace IFSPStore.App.Register
{
    partial class CityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityForm));
            tbName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbState = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            tabPageList.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(tbId);
            tabPageRegister.Controls.Add(tbState);
            tabPageRegister.Controls.Add(tbName);
            tabPageRegister.Size = new Size(558, 311);
            tabPageRegister.Controls.SetChildIndex(panel1, 0);
            tabPageRegister.Controls.SetChildIndex(tbName, 0);
            tabPageRegister.Controls.SetChildIndex(tbState, 0);
            tabPageRegister.Controls.SetChildIndex(tbId, 0);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(465, 13);
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(380, 13);
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(566, 346);
            // 
            // imageListRegister
            // 
            imageListRegister.ImageStream = (ImageListStreamer)resources.GetObject("imageListRegister.ImageStream");
            imageListRegister.Images.SetKeyName(0, "form.png");
            imageListRegister.Images.SetKeyName(1, "search.png");
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 253);
            panel1.Size = new Size(552, 55);
            // 
            // tbName
            // 
            tbName.AnimateReadOnly = false;
            tbName.AutoCompleteMode = AutoCompleteMode.None;
            tbName.AutoCompleteSource = AutoCompleteSource.None;
            tbName.BackgroundImageLayout = ImageLayout.None;
            tbName.CharacterCasing = CharacterCasing.Normal;
            tbName.Depth = 0;
            tbName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbName.HideSelection = true;
            tbName.Hint = "Name";
            tbName.LeadingIcon = null;
            tbName.Location = new Point(18, 23);
            tbName.MaxLength = 32767;
            tbName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbName.Name = "tbName";
            tbName.PasswordChar = '\0';
            tbName.PrefixSuffixText = null;
            tbName.ReadOnly = false;
            tbName.RightToLeft = RightToLeft.No;
            tbName.SelectedText = "";
            tbName.SelectionLength = 0;
            tbName.SelectionStart = 0;
            tbName.ShortcutsEnabled = true;
            tbName.Size = new Size(514, 48);
            tbName.TabIndex = 3;
            tbName.TabStop = false;
            tbName.TextAlign = HorizontalAlignment.Left;
            tbName.TrailingIcon = null;
            tbName.UseSystemPasswordChar = false;
            // 
            // tbState
            // 
            tbState.AnimateReadOnly = false;
            tbState.AutoCompleteMode = AutoCompleteMode.None;
            tbState.AutoCompleteSource = AutoCompleteSource.None;
            tbState.BackgroundImageLayout = ImageLayout.None;
            tbState.CharacterCasing = CharacterCasing.Normal;
            tbState.Depth = 0;
            tbState.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbState.HideSelection = true;
            tbState.Hint = "State";
            tbState.LeadingIcon = null;
            tbState.Location = new Point(18, 89);
            tbState.MaxLength = 32767;
            tbState.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbState.Name = "tbState";
            tbState.PasswordChar = '\0';
            tbState.PrefixSuffixText = null;
            tbState.ReadOnly = false;
            tbState.RightToLeft = RightToLeft.No;
            tbState.SelectedText = "";
            tbState.SelectionLength = 0;
            tbState.SelectionStart = 0;
            tbState.ShortcutsEnabled = true;
            tbState.Size = new Size(402, 48);
            tbState.TabIndex = 4;
            tbState.TabStop = false;
            tbState.TextAlign = HorizontalAlignment.Left;
            tbState.TrailingIcon = null;
            tbState.UseSystemPasswordChar = false;
            // 
            // tbId
            // 
            tbId.AnimateReadOnly = false;
            tbId.AutoCompleteMode = AutoCompleteMode.None;
            tbId.AutoCompleteSource = AutoCompleteSource.None;
            tbId.BackgroundImageLayout = ImageLayout.None;
            tbId.CharacterCasing = CharacterCasing.Normal;
            tbId.Depth = 0;
            tbId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbId.HideSelection = true;
            tbId.Hint = "Id";
            tbId.LeadingIcon = null;
            tbId.Location = new Point(438, 89);
            tbId.MaxLength = 32767;
            tbId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbId.Name = "tbId";
            tbId.PasswordChar = '\0';
            tbId.PrefixSuffixText = null;
            tbId.ReadOnly = true;
            tbId.RightToLeft = RightToLeft.No;
            tbId.SelectedText = "";
            tbId.SelectionLength = 0;
            tbId.SelectionStart = 0;
            tbId.ShortcutsEnabled = true;
            tbId.Size = new Size(94, 48);
            tbId.TabIndex = 5;
            tbId.TabStop = false;
            tbId.TextAlign = HorizontalAlignment.Left;
            tbId.TrailingIcon = null;
            tbId.UseSystemPasswordChar = false;
            // 
            // CityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 413);
            Location = new Point(0, 0);
            Name = "CityForm";
            Text = "CityForm";
            tabPageRegister.ResumeLayout(false);
            tabControlRegister.ResumeLayout(false);
            tabPageList.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbState;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbId;
    }
}