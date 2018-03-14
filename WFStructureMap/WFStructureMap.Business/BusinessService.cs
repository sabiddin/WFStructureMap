using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFStructureMap.Data;

namespace WFStructureMap.Business
{
    public interface IBusinessService
    {
        string GetMessage();
    }
    public class BusinessService:IBusinessService
    {
        private IDataService _dataService;
        public BusinessService(IDataService dataService)
        {
            _dataService = dataService;
        }
        public string GetMessage() {
            return _dataService.GetMessage();
        }
    }
}
