using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic.MionixQG
{
    /// <summary>
    /// Structure representing metrics calculated by Mionix QG from the sensors
    /// </summary>
    [Serializable]
    public struct BioMetrics
    {
        /// <summary>
        /// Galvanic Skin Response sensor's value
        /// </summary>
        public double gsr;

        /// <summary>
        /// Maximum heart beat rate since a few seconds (in beats per minute)
        /// </summary>
        public float heartRateMax;

        /// <summary>
        /// Average heart beat rate since a few seconds (in beats per minute)
        /// </summary>
        public float hearRateAvg;

        /// <summary>
        /// Current heart beat rate since a few seconds (in beats per minute)
        /// </summary>
        public float heartRate;

        /// <summary>
        /// Heart beat calculation quality (between 0 - 100)
        /// </summary>
        public int heartRateQuality;

        /// <summary>
        /// Status of heart beat monitor sensor
        /// </summary>
        public string heartRateState;
    }
}
