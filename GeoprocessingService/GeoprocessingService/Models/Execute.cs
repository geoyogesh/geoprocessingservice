using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoprocessingService.Models
{
    public class Execute : BaseGPModel
    {
        public Execute()
        {
            QString = new Dictionary<string, string>();
        }
        public Dictionary<string,string> QString { get; set; }
    }
}