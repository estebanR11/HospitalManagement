using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public partial class DBConnection:DbContext
    {
        private DBConnection(string stringConnection)
            :base(stringConnection)
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Database.CommandTimeout = 900;
        }

        public static DBConnection Create()
        {
            return new DBConnection("name=DbConnection");
        }
    }
}
