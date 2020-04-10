using System.IO;
using Newtonsoft.Json;
using UnityEngine;

namespace Data
{
    public class InventoryDataHandler 
    {
        private const string dataFileName = "inventoryData.json";

        public InventoryData LoadInventoryData()
        {
            InventoryData data;
            if (File.Exists(dataFileName))
            {
                string dataAsString = File.ReadAllText(dataFileName);
                data = JsonConvert.DeserializeObject<InventoryData>(dataAsString);
            }
            else
            {
                InventoryDataBuilder builder = new InventoryDataBuilder();
                data = builder.CreateInventoryData();
            }

            return data;
        }

        public void SaveInventoryData(InventoryData data)
        {
            string dataAsString = JsonConvert.SerializeObject(data);
            File.WriteAllText(dataFileName,dataAsString);
            
        }
    }
}