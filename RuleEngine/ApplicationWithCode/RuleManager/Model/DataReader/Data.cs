using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.DataReader
{
    public class Data
    {
        
        public string signal { get; set; }

        public string value { get; set; }

        public string value_type { get; set; }

    }

    public class DataStream
    {

        public Data[] DataArray;

    }
}
