using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFStructureMap.Web.Interfaces
{
    public interface IEmailService
    {
        bool SendEmail(string recepient, string emailBody);
    }
}
