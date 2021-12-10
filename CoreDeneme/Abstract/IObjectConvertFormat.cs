using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Abstract
{
    public interface IObjectConvertFormat
    {
        T JsonToObject<T>(string jsonString) where T : class;
        string ObjectToJson<T>(T entityObject) where T : class;
        T ParseObjectDataArray<T>(byte[] rawBytes) where T : class;
    }
}
