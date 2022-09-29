using Newtonsoft.Json;
using System.Collections.Generic;

namespace RequestsTest.Utils
{
    public class JsonHandler
    {
        public T ToObj<T>(string jsonString)
        {
            try
            {
                T obj = JsonConvert.DeserializeObject<T>(jsonString);
                return obj;
            }
            catch
            {
                throw;
            }
        }

        public string ToJson<T>(T obj)
        {
            try
            {
                string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
                return json;
            }
            catch
            {
                throw;
            }
        }
    }
}
