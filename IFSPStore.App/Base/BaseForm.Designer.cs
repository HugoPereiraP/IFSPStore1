namespace IFSPStore.App.Base
{
    partial class BaseForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            tabControlRegister = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageRegister = new TabPage();
            btnSave = new ReaLTaiizor.Controls.MaterialButton();
            btnCancel = new ReaLTaiizor.Controls.MaterialButton();
            tabPageList = new TabPage();
            dataGridViewList = new DataGridView();
            btnDelete = new ReaLTaiizor.Controls.MaterialButton();
            btnEdit = new ReaLTaiizor.Controls.MaterialButton();
            btnNew = new ReaLTaiizor.Controls.MaterialButton();
            imageListRegister = new ImageList(components);
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).BeginInit();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Controls.Add(tabPageRegister);
            tabControlRegister.Controls.Add(tabPageList);
            tabControlRegister.Depth = 0;
            tabControlRegister.Dock = DockStyle.Fill;
            tabControlRegister.ImageList = imageListRegister;
            tabControlRegister.Location = new Point(3, 64);
            tabControlRegister.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlRegister.Multiline = true;
            tabControlRegister.Name = "tabControlRegister";
            tabControlRegister.SelectedIndex = 0;
            tabControlRegister.Size = new Size(599, 435);
            tabControlRegister.TabIndex = 0;
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(btnSave);
            tabPageRegister.Controls.Add(btnCancel);
            tabPageRegister.ImageIndex = 0;
            tabPageRegister.Location = new Point(4, 31);
            tabPageRegister.Name = "tabPageRegister";
            tabPageRegister.Padding = new Padding(3);
            tabPageRegister.Size = new Size(591, 400);
            tabPageRegister.TabIndex = 0;
            tabPageRegister.Text = "Register";
            tabPageRegister.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSave.Location = new Point(507, 355);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 1;
            btnSave.Text = "SAVE";
            btnSave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancel.Location = new Point(422, 355);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "CANCEL";
            btnCancel.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += materialButton1_Click;
            // 
            // tabPageList
            // 
            tabPageList.Controls.Add(dataGridViewList);
            tabPageList.Controls.Add(btnDelete);
            tabPageList.Controls.Add(btnEdit);
            tabPageList.Controls.Add(btnNew);
            tabPageList.ImageIndex = 1;
            tabPageList.Location = new Point(4, 31);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.Size = new Size(591, 400);
            tabPageList.TabIndex = 1;
            tabPageList.Text = "List";
            tabPageList.UseVisualStyleBackColor = true;
            tabPageList.Enter += tabPageList_Enter;
            // 
            // dataGridViewList
            // 
            dataGridViewList.AllowUserToAddRows = false;
            dataGridViewList.AllowUserToDeleteRows = false;
            dataGridViewList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewList.Location = new Point(3, 3);
            dataGridViewList.Name = "dataGridViewList";
            dataGridViewList.RowHeadersWidth = 51;
            dataGridViewList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewList.Size = new Size(585, 343);
            dataGridViewList.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnDelete.Location = new Point(367, 355);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(73, 36);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "DELETE";
            btnDelete.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEdit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEdit.Depth = 0;
            btnEdit.HighEmphasis = true;
            btnEdit.Icon = null;
            btnEdit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEdit.Location = new Point(448, 355);
            btnEdit.Margin = new Padding(4, 6, 4, 6);
            btnEdit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEdit.Name = "btnEdit";
            btnEdit.NoAccentTextColor = Color.Empty;
            btnEdit.Size = new Size(64, 36);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "EDIT";
            btnEdit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEdit.UseAccentColor = false;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNew.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNew.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNew.Depth = 0;
            btnNew.HighEmphasis = true;
            btnNew.Icon = null;
            btnNew.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNew.Location = new Point(520, 355);
            btnNew.Margin = new Padding(4, 6, 4, 6);
            btnNew.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNew.Name = "btnNew";
            btnNew.NoAccentTextColor = Color.Empty;
            btnNew.Size = new Size(64, 36);
            btnNew.TabIndex = 0;
            btnNew.Text = "New";
            btnNew.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNew.UseAccentColor = false;
            btnNew.UseVisualStyleBackColor = true;
            // 
            // imageListRegister
            // 
            imageListRegister.ColorDepth = ColorDepth.Depth32Bit;
            imageListRegister.ImageStream = (ImageListStreamer)resources.GetObject("imageListRegister.ImageStream");
            imageListRegister.TransparentColor = Color.Transparent;
            imageListRegister.Images.SetKeyName(0, "form.png");
            imageListRegister.Images.SetKeyName(1, "search.png");
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 502);
            Controls.Add(tabControlRegister);
            Name = "BaseForm";
            Text = "BaseForm";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            tabPageRegister.PerformLayout();
            tabPageList.ResumeLayout(false);
            tabPageList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageListRegister;
        protected TabPage tabPageRegister;
        protected ReaLTaiizor.Controls.MaterialButton btnSave;
        protected ReaLTaiizor.Controls.MaterialButton btnCancel;
        protected ReaLTaiizor.Controls.MaterialButton btnNew;
        protected DataGridView dataGridViewList;
        protected ReaLTaiizor.Controls.MaterialButton btnDelete;
        protected ReaLTaiizor.Controls.MaterialButton btnEdit;
        protected ReaLTaiizor.Controls.MaterialTabControl tabControlRegister;
        protected TabPage tabPageList;
    }
}