using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace AjaiouApp.Models
{
    [DataTable("service")]
    public class Order
    {
        public int id { get; set; }
        public string Story { get; set; }
        public string Description { get; set; }
        public string Transaction { get; set; }
        public int Motion { get; set; }
        public int Contract { get; set; }
        public int Development { get; set; }
        public int Teste { get; set; }

        [Version]
        public string AzureVersion { get; set; }
    }
}
