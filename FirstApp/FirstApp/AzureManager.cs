using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace FirstApp
{
    public class AzureManager
    {
        private static AzureManager instance;
        private MobileServiceClient client;
        //private IMobileServiceTable<TableModel> table;

        private AzureManager()
        {
            this.client = new MobileServiceClient("https://moduletwoapp.azurewebsites.net");
            //this.table = this.client.GetTable<TableModel>();
        }

        public MobileServiceClient AzureClient
        {
            get { return client; }
        }

        public static AzureManager AzureManagerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AzureManager();
                }

                return instance;
            }
        }

        //public async Task<List<TableModel>> GetHotDogInformation()
        //{
        //    return await this.table.ToListAsync();
        //}
    }
}
