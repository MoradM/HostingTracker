using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostingTracker.Src.Common.DataTypes
{
    public readonly struct Domain
    {
        private readonly string _path;
        private readonly DateTime _expiration;

        public Domain(string path, DateTime expiration)
        {
            _path = path;
            _expiration = expiration;
        }

        public string GetPath()
        {
            return _path;
        }

        public DateTime GetExpiration()
        {
            return _expiration;
        }
    }
}
