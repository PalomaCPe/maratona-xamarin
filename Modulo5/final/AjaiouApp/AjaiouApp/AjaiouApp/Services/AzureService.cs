using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace AjaiouApp.Services
{
    public class AzureService<T>
    {
        IMobileServiceClient Client;
        IMobileServiceTable<T> Table;

        public AzureService()
        {
            string AjaiouUrl = "http://ajaiou.azurewebsites.net";
            Client = new MobileServiceClient(AjaiouUrl);
            Table = Client.GetTable<T>();
        }

        public Task<IEnumerable<T>> GetTable()
        {
            return Table.ToEnumerableAsync();
        }
    }
}
