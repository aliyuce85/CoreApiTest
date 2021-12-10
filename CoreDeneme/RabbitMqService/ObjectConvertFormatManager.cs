using CoreDeneme.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDeneme.RabbitMqService
{
    public class ObjectConvertFormatManager : IObjectConvertFormat
    {
        public T JsonToObject<T>(string jsonString) where T : class
        {
            var objectData = JsonConvert.DeserializeObject<T>(jsonString);
            return objectData;
        }

        public string ObjectToJson<T>(T entityObject) where T : class
        {
            var jsonString = JsonConvert.SerializeObject(entityObject);
            return jsonString;
        }

        public T ParseObjectDataArray<T>(byte[] rawBytes) where T : class
        {
            var stringData = Encoding.UTF8.GetString(rawBytes);
            return JsonToObject<T>(stringData);
        }

    }
}
