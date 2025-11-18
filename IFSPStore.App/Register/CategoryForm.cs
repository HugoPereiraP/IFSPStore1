using IFSPStore.App.Base;
using IFSPStore.App.ViewModels;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

namespace IFSPStore.App.Register;

public partial class CategoryForm : BaseForm
{
    #region Variables
    private readonly IBaseService<Category> _categoryService;
    private List<CategoryModel> _categories;

    #endregion

    #region Methods
    public CategoryForm(IBaseService<Category> categoryService)
    {
        _categoryService = categoryService;

        InitializeComponent();
    }

    private void FormToObject(Category category)
    {
        category.Name = mtbName.Text;
        category.Description = mtbDescription.Text;
    }

    protected override void Save()
    {
        try
        {
            if (isEditMode)
            {
                int.TryParse(mtbId.Text, out int id);

                var category = _categoryService.GetById<Category>(id);

                FormToObject(category);

                category = _categoryService.Update<Category, Category, CategoryValidator>(category);
            }
            else
            {
                var category = new Category();

                FormToObject(category);

                category = _categoryService.Add<Category, Category, CategoryValidator>(category);
            }

            ClearFields();

            MessageBox.Show("Product saved successfully", "IFSP Store",
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
            _categoryService.Delete(id);
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
            _categories = _categoryService.Get<CategoryModel>().ToList();
            dataGridViewList.DataSource = _categories;
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
            mtbId.Text = record?.Cells["Id"].Value.ToString();
            mtbName.Text = record?.Cells["Name"].Value.ToString();
            mtbDescription.Text = record?.Cells["Description"].Value.ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "IFSP Store",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    #endregion
}
