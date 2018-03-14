﻿using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WFStructureMap.Web.StructureMapRegistry;

namespace WFStructureMap.Web.IoC
{
    public static class IoC
    {
        private static readonly IContainer Container;

        static IoC()
        {
            Container = new Container(new ScanningRegistry());
        }

        public static T Resolve<T>()
        {
            return Container.GetInstance<T>();
        }

        public static T Resolve<T>(string name)
        {
            return Container.GetInstance<T>(name);
        }

        public static void BuildUp(object target)
        {
            Container.BuildUp(target);
        }

        // helper method that shows what's in the container
        public static string WhatDoIHave()
        {
            return Container.WhatDoIHave();
        }
    }
}