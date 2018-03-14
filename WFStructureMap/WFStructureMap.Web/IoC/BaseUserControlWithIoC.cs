﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WFStructureMap.Web.IoC
{
    public class BaseUserControlWithIoC : UserControl
    {
        protected override void OnLoad(EventArgs e)
        {
            IoC.BuildUp(this);
            base.OnLoad(e);
        }
    }
}