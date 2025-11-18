using IFSPStore.App.Base;
using IFSPStore.App.ViewModels;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using System.Xml.Linq;

namespace IFSPStore.App.Register
{
    public partial class CityForm : BaseForm
    {
        #region Variables
        private readonly IBaseService<City> _cityService;
        private List<CityModel> _cities;

        #endregion

        #region Methods
        public CityForm(IBaseService<City> cityService)
        {
            _cityService = cityService;

            InitializeComponent();
        }

        private void FormToObject(City city)
        {
            city.Name = tbName.Text;
            city.State = tbState.Text;
        }

        protected override void Save()
        {
            try
            {
                if (isEditMode)
                {
                    int.TryParse(tbId.Text, out int id);

                    var city = _cityService.GetById<City>(id);

                    FormToObject(city);

                    city = _cityService.Update<City, City, CityValidator>(city);
                }
                else
                {
                    var city = new City();

                    FormToObject(city);

                    city = _cityService.Add<City, City, CityValidator>(city);
                }

                ClearFields();

                MessageBox.Show("User saved successfully", "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _cityService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            try
            {
                _cities = _cityService.Get<CityModel>().ToList();
                dataGridViewList.DataSource = _cities;
                dataGridViewList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            try
            {
                tbId.Text = record?.Cells["Id"].Value.ToString();
                tbName.Text = record?.Cells["Name"].Value.ToString();
                tbState.Text = record?.Cells["State"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
