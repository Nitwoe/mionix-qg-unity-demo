using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic.MionixQG
{
    /// <summary>
    /// Structure represeting raw bio data returned from the Miaonix QG's sensors
    /// Useful for implementing custom heartbeat calculation algorithms
    /// </summary>
    [Serializable]
    public struct BioRaw
    {
        /// <summary>
        /// Time since last update (in milliseconds)
        /// </summary>
        public int dt;

        /// <summary>
        /// Reflective value of the heart rate sensor
        /// </summary>
        public long hr;

        /// <summary>
        /// Indicates whether user is touching the heart rate sensor
        /// </summary>
        public bool touch;
    }
}
