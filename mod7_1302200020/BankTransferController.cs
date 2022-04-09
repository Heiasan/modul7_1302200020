using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod7_1302200020
{
    public class BankTransferController
    {
        public void writejson(BankTransferConfig data) 
        {
            string file = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText("D://00_File Kampus//S4//KPL//PRAKTIKUM//TP KPL//mod7_1302200020//mod7_1302200020//BankTranfer.json", file);
        }
        public BankTransferConfig readjson()
        {
            dynamic data = File.ReadAllText("D://00_File Kampus//S4//KPL//PRAKTIKUM//TP KPL//mod7_1302200020//mod7_1302200020//BankTranfer.json");
            BankTransferConfig config = JsonConvert.DeserializeObject<BankTransferConfig>(data);
            return config;
        }
        
    }
}
