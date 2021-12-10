using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Data
{
    public interface IDataModel<T>
    {
        IEnumerable<T> GetData();
    }
}
