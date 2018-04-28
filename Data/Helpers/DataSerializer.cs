using System;
using System.Collections.Generic;
using System.IO;
using Data.Models;

namespace Data.Helpers
{
    class DataSerializer
    {

        public IList<Restaurants> myArray { get; set; }


        public IList<Restaurants> deserialize()
        {
            string filePath = ConfigurationManager.AppSettings["Path"];
            var jsonText = File.ReadAllText(filePath);
            myArray = JsonConvert.DeserializeObject<IList<Restaurants>>(jsonText);
            return myArray;
        }

        public string serialize()
        {
            var json = JsonConvert.SerializeObject(myArray);
            return json;
        }
    }
}
