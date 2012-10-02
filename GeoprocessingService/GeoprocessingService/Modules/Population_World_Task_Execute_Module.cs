using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoprocessingService.Modules
{
    public class PopulationWorldTaskExecuteModule : Nancy.NancyModule
    {
        public PopulationWorldTaskExecuteModule()
            : base("/rest/services/PopulationWorld/GPServer/{Task}/execute")
        {
           // Get["/"] = parameters => "Tasks :" + parameters.Task + " : Execute";
            Get["/"] = parameters =>
                {
                    return View["Execute"];
                };
        }
    }
}