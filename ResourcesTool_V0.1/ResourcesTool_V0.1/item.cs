using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcesTool_V0._1
{
    class item
    {

        public uint item_id { get; private set; }
        public string item_name { get; private set; }
        public uint bank_rate { get; private set; }
        public uint sm_rate { get; private set; }
        public uint timestamp { get; private set; }




        /// <summary>
        /// Creates a new item object
        /// </summary>
        /// <param name="item_id">Identifier, must not be empty.</param>
        /// <param name="item_name">Name of the item, must not be empty</param>
        /// <param name="bank_rate">Price from the bank, must not be empty,negative</param>
        /// <param name="sm_rate">Highest price from players, must be positive,</param>
        /// <param name="timestamp">Information update time</param>
        /// 
        public item(uint item_id, string item_name, uint bank_rate, uint sm_rate, uint timestamp)
        {
            this.item_id = item_id;
            this.item_name = item_name;
            this.bank_rate = bank_rate;
            this.sm_rate = sm_rate;
            this.timestamp = timestamp;
        }





    }
}
