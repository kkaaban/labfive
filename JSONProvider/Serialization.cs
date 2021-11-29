using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace JSONProvider
{
    public static class Serialization<T>
    {
        public static void Serialize(List<T> objects, string path)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));
            using (var file = new FileStream(path, FileMode.Create))
            {
                jsonFormatter.WriteObject(file, objects);
            }
        }
        public static List<T> DeSerialize(string path)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));
            List<T> list = new List<T>();
            using (var file = new FileStream(path, FileMode.Open))
            {
                list = (List<T>)jsonFormatter.ReadObject(file);
            }
            return list;
        }
    }
}
