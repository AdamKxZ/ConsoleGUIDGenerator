using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIDGenerator
{
    public class DB
    {
        public int ID { get; set; }
        public string GUID { get; set; }
        public DateTimeOffset DateAdded { get; set; }

    }

    public class GuidDBContext : DbContext
    {
        public DbSet<DB> GUIDs { get; set; }
    }
}
