using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic.MionixQG
{
    public class BioRawEventArgs : EventArgs
    {
        public BioRaw BioRaw
        {
            get;
            protected set;
        }

        public BioRawEventArgs(BioRaw bioRaw)
        {
            BioRaw = bioRaw;
        }
    }
}
