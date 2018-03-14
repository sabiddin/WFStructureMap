using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WFStructureMap.Web.Interfaces;
using WFStructureMap.Web.IoC;
using WFStructureMap.Data;
using WFStructureMap.Business;

namespace WFStructureMap.Web
{
    public partial class _Default : BasePageWithIoC
    {
        public IEmailService EmailService { get; set; }
     //   public IDataService DataService { get; set; }
        public IBusinessService businessService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var result = EmailService.SendEmail("test@test.com", "hello world");
            var message = businessService.GetMessage();
            lblEmailResult.InnerText = $"The email result was :" + (result ? $"success = {message}" : "failure");
        }
    }
}