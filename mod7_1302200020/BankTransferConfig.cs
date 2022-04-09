using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod7_1302200020
{
    public class BankTransferConfig
    {

        public string lang { get; set; }

        public transfers transfer { get; set; }
        public string methods { get; set; }
        public confirmation confirmation { get; set; }
       

    }
    public class transfers 
    {
        public string threshold { get; set; }
        public string low_fee { get; set; }
        public string high_fee { get; set; }


    }
    class confirmation
    {
        public string en { get; set; }
        public string id { get; set; }
        public confirmation() { }
        public confirmation(string en, string id)
        {
            this.en = en;
            this.id = id;
        }
    }
}