using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGI.Api.Models
{
    public class Settings
    {
        public Connection Connection { get; set; } = new Connection();
        public JwToken Token { get; set; } = new JwToken();
    }

    public class Connection
    {
        public enum EnumProviders { MySQL, SqlServer }

        public string ConnectionString = "";
        public EnumProviders Provider = EnumProviders.SqlServer;
    }
    public class JwToken
    {
        public string Key = "";
        public string Issuer = "";
    }
}
