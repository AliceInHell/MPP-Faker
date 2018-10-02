using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace FakerLibrary
{
    public class JSONSerializer : ISerializer
    {
        public MemoryStream serialize(object result)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(result, Formatting.Indented));
            return new MemoryStream(byteArray);
        }

        public List<Type> deserialize(MemoryStream ms)
        {
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader(ms))
            using (var jsonTextReader = new JsonTextReader(sr))
            {
                return serializer.Deserialize<List<Type>>(jsonTextReader);
            }
        }
    }
}
