using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace IFSPStore.App.Base
{
    public partial class BaseForm : MaterialForm
    {
        #region Variables
        protected bool isEditMode = false;

        #endregion

        #region Methods
        public BaseForm()
        {
            InitializeComponent();
        }

        protected void ClearFields()
        {
            isEditMode = false;
            foreach (var control in tabPageRegister.Controls)
            {
                if (control is MaterialTextBoxEdit textBox)
                    textBox.Clear();

                if (control is MaterialMaskedTextBox maskedTextBox)
                    maskedTextBox.Clear();
            }
        }

        protected virtual void New()
        {
            ClearFields();
            tabControlRegister.SelectedIndex = 0;
            tabPageRegister.Focus();
        }

        protected virtual void Save()
        {
        }
        protected virtual void Delete(int id)
        {
        }
        protected void Edit()
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                isEditMode = true;
                var record = dataGridViewList.SelectedRows[0];
                GridToForm(record);
                tabControlRegister.SelectedIndex = 0;
                tabPageRegister.Focus();
            }
            else
            {
                MessageBox.Show("No rows selected. Please, select one row.", "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void PopulateGrid()
        {
        }

        protected virtual void GridToForm(DataGridViewRow? record)
        {
        }

        #endregion

        #region Events
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure cancel?", "IFSP Store",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearFields();
                tabControlRegister.SelectedIndex = 1;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete?", "IFSP Store",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var id = (int)dataGridViewList.SelectedRows[0].Cells["Id"].Value;
                    Delete(id);
                    PopulateGrid();
                }
            }
            else
            {
                MessageBox.Show("No rows selected. Please, select one row.", "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void tabPageList_Enter(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        #endregion
    }
}
