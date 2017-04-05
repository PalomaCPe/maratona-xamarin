using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaiouApp.Models
{
    public class Repository
    {
        public async Task<List<Order>> GetOrders()
        {
            var Service = new Services.AzureService<Order>();
            var Items = await Service.GetTable();
            return Items.ToList();
        }

        public async Task<List<Cat>> GetCats()
        {
            var Service = new Services.AzureService<Cat>();
            var Items = await Service.GetTable();
            return Items.ToList();
        }
    }
}
