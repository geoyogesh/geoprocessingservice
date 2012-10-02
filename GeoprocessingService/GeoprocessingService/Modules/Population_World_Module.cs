using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoprocessingService.Modules
{
    public class PopulationWorldModule : Nancy.NancyModule
    {
        public PopulationWorldModule()
            : base("/rest/services/PopulationWorld/GPServer")
        {
            Get["/"] = _ => "Population_World_Module";
        }
    }
}