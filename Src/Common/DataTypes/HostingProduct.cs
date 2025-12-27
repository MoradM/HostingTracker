using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostingTracker.Src.Common.DataTypes
{
    public enum HostingType
    {
        Domain,
        VPS,
        WebHosting,
    }

    public class HostingProduct
    {
        private readonly string _name;
        private readonly HostingType _type;
        private readonly DateTime _expiration;

        public HostingProduct(string name, HostingType type, DateTime expiration)
        {
            _name = name;
            _type = type;
            _expiration = expiration;
        }

        public string GetName()
        {
            return _name;
        }

        public HostingType GetHostingType()
        {
            return _type;
        }

        public DateTime GetExpiration()
        {
            return _expiration;
        }
    }
}
