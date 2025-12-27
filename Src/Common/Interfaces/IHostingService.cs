using HostingTracker.Src.Common.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostingTracker.Src.Common.Interfaces
{
    public interface IHostingService
    {
        public string GetServiceName();

        public Task<IList<HostingProduct>> GetHostingProducts();
    }
}
