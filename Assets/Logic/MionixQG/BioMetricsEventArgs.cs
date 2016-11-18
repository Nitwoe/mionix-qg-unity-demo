using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic.MionixQG
{
    public class BioMetricsEventArgs : EventArgs
    {
        public BioMetrics BioMetrics
        {
            get;
            protected set;
        }

        public BioMetricsEventArgs(BioMetrics metrics)
        {
            BioMetrics = metrics;
        }
    }
}
