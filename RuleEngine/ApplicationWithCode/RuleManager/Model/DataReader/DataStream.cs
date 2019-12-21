using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Model.DataReader
{
    public class DataStreamReader
    {

        public string path = @"";

        DataStream stream = null;

        public DataStream ReadData()
        {

            string json = File.ReadAllText(path);

            stream = JsonConvert.DeserializeObject<DataStream>(json);

            return stream;

        }

    }
}
