using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoprocessingService.Modules
{
    public class PopulationWorldTaskModule : Nancy.NancyModule
    {
        public PopulationWorldTaskModule()
            : base("/rest/services/PopulationWorld/GPServer/{Task}")
        {
            Get["/"] = parameters => "Tasks :" + parameters.Task;
        }
    }
}