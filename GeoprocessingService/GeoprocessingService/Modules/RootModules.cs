using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoprocessingService.Modules
{
    public class RootModules:Nancy.NancyModule
    {
        public RootModules()
        {
            Get["/"]=parameters=>
            {
                return "Hello world";
            };
        }
    }
}