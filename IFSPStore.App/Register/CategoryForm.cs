using IFSPStore.App.Base;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;



namespace IFSPStore.App.Register
{
    public partial class CategoryForm : BaseForm
    {
        private IBaseService<Category> _CategoryService;
        public CategoryForm(IBaseService<Category> categoryService)
        {
            _CategoryService = categoryService;
            InitializeComponent();
        }
        private void FormToObject(Category category)
        {
            category.Name = txtName.Text;
        }
        protected override void Save()
        {
            try
            {
                if (ISEditMode)
                {
                    int.TryParse(txtId.Text, out var id);
                    var category = _CategoryService.GetById<Category>(id);
                    FormToObject(category);
                    category = _CategoryService.Update<Category, Category, CategoryValidator>(category);
                }
                else
                {
                    var category = new Category();
                    FormToObject(category);
                    _CategoryService.Add<Category, Category, CategoryValidator>(category);
                    txtId.Text = category.Id.ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
    }
}
