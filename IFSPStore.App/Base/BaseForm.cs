using Mysqlx.Crud;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;


namespace IFSPStore.App.Base
{
    public partial class BaseForm : MaterialForm
    {
        #region Variables
        bool isEditMode = false;


        #endregion

        #region Constructors Method




        public BaseForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure Cancel?", @"IFSP Store",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearFilds();
                tabControlRegister.SelectedIndex = 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you Sure delete?", @"IFSP Store",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var id = (int)dataGridViewList.SelectedRows[0].Cells["id"].Value;
                    Delete(id);
                    PopulateGrid();
                }
            }
            else
            {
                MessageBox.Show(@"Please, select any row!",@"IFSP store", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void tabPageList_Enter(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        #endregion

        #region Methods
        private void ClearFilds()
        {
            isEditMode = false;
            foreach (var control in tabControlRegister.Controls)
            {
                if (control is MaterialTextBoxEdit textBox)
                    textBox.Clear();
                if (control is MaterialMaskedTextBox maskedTextBox)
                    maskedTextBox.Clear();
            }
        }

        protected virtual void New()
        {
            ClearFilds ();
            tabControlRegister.SelectedIndex = 0;
            TabPageRegister.Focus();
        }

        protected virtual void Save()
        {

        }
        protected virtual void Delete(int id)
        {

        }
        protected virtual void Edit()
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                isEditMode = true;
                var record = dataGridViewList.SelectedRows[0];
                GridToForm(record);
                tabControlRegister.SelectedIndex = 0;
                TabPageRegister.Focus();
            }
            else
            {
                MessageBox.Show(@"Please, select any row!", @"IFSP store", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        protected virtual void GridToForm(DataGridViewRow? record)
        {

        }

        protected virtual void PopulateGrid()
        {

        }
        #endregion
    }
}

