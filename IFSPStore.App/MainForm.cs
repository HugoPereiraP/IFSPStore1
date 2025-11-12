using IFSPStore.App.Infra;
using IFSPStore.App.Register;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace IFSPStore.App
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<CategoryForm>();
        }

        private void ShowForm<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.serviceProvider.GetService<TFormulario>();

            if(cad is not null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}
