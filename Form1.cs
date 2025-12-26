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
                string apiKey = t_hostingerKey.Text;
                IHostingService hostinger = new HostingerService(apiKey);
                var hostingerDomains = await hostinger.GetDomains();
                foreach (var domain in hostingerDomains)
                {
                    g_Domains.Rows.Add(domain.GetPath(), domain.GetExpiration(), "Hostinger");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
