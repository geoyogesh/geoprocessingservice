using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoprocessingService.Models
{
    public abstract class BaseGPModel
    {
        protected BaseGPModel()
        {
            HasException = false;
            HasResult = false;
        }


        public int OutSR { get; set; }

        public int ProcessSR { get; set; }

        public String Format { get; set; }

        public string Result { get; set; }

        public string Exception { get; set; }

        public bool HasException { get; set; }

        public bool HasResult { get; set; }
    }
}