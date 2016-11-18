using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic.MionixQG
{
    public class MouseMetricsEventArgs : EventArgs
    {
        public MouseMetrics MouseMetrics
        {
            get;
            protected set;
        }

        public MouseMetricsEventArgs(MouseMetrics metrics)
        {
            MouseMetrics = metrics;
        }
    }
}
