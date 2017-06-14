using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Diablo3Hub.Models
{
    public class ApiCacheData
    {
        [PrimaryKey]
        public string Url { get; set; }

        [Column("TEXT")]
        public string Content { get; set; }

        public DateTime CreateDT { get; set; }

    }
}
