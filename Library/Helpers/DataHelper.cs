using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Newtonsoft.Json;

namespace Library.Helpers
{
    class DataHelper
    {
        public IList<RootObject> myArray { get; set; }

       
        public IList<RootObject> deserialize()
        {
            string filePath = ConfigurationManager.AppSettings["Path"];
            var jsonText = File.ReadAllText(filePath);
            myArray = JsonConvert.DeserializeObject<IList<RootObject>>(jsonText);
            return myArray;
        }

        public string  serialize()
        {
            var json =  JsonConvert.SerializeObject(myArray);
            return json;
        }
    }
    
}
