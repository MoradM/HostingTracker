using HostingTracker.Src.Common.Interfaces;
using HostingTracker.Src.HostingServices.Hostinger;

namespace HostingTracker
{
    public partial class HostingTracker : Form
    {
        public HostingTracker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(t_hostingerKey.Text))
            {
                // TODO: Make this generic by dependency injection
                // and fetching the different providers.
                string apiKey = t_hostingerKey.Text;
                IHostingService hostinger = new HostingerService(apiKey);
                var hostingerProducts = await hostinger.GetHostingProducts();
                foreach(var product in hostingerProducts)
                {
                    g_Products.Rows.Add(
                        product.GetName(),
                        product.GetExpiration(),
                        product.GetHostingType().ToString(),
                        product.IsAutoRenewed() != null ? (product.IsAutoRenewed().Value ? "Yes" : "No") : "Unknown",
                        hostinger.GetServiceName());
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
