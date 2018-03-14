using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFStructureMap.Data
{
    public class DataService : IDataService
    {
        public string GetMessage()
        {
            return "Hello";
        }
    }
}
