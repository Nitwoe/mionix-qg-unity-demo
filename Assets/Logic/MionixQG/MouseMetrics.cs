using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic.MionixQG
{
    /// <summary>
    /// Structure containing current mouse metrics retrieved from the Miaonix QG.
    /// All *totals* are stored within the device's flash memory and are updated within every 10 minutes.
    /// </summary>
    [Serializable]
    public struct MouseMetrics
    {
        /// <summary>
        /// Time active since factory reset (in milliseconds)
        /// </summary>
        public long totalTime;

        /// <summary>
        /// Distance moved since factory reset (in millimeters)
        /// </summary>
        public long totalDistance;

        /// <summary>
        /// Total scrolls since factory reset (in scroll steps)
        /// </summary>
        public long totalScrolls;

        /// <summary>
        /// Total clicks since factory reset
        /// </summary>
        public long totalClicks;

        /// <summary>
        /// The time mouse has been active during last continuous gesture (in milliseconds)
        /// </summary>
        public int streakTime;

        /// <summary>
        /// Distance moved (in millimeters) during last continuous gesture
        /// </summary>
        public double streakDistance;

        /// <summary>
        /// Number of steps scrolled during last continuous gesture
        /// </summary>
        public int streakScrolls;

        /// <summary>
        /// Number of clicks during last continuous gesture
        /// </summary>
        public int streakClicks;

        /// <summary>
        /// Current movement speed of the mouse (in meters per second)
        /// </summary>
        public double speed;

        /// <summary>
        /// Average movement speed since a few seconds (in meters per second)
        /// </summary>
        public double speedAvg;

        /// <summary>
        /// Max speed since a few seconds (in meters per second)
        /// </summary>
        public double speedMax;

        /// <summary>
        /// Current click rate of the mouse (in clicks per second)
        /// </summary>
        public double clickRate;

        /// <summary>
        /// Average click rate of the mouse since a few seconds (in clicks per second)
        /// </summary>
        public double clickRateAvg;

        /// <summary>
        /// Max click rate of the mouse since a few seconds (in clicks per second)
        /// </summary>
        public double clickRateMax;

        /// <summary>
        /// Current scroll rate of the mouse (in scroll steps per second)
        /// </summary>
        public double scrollRate;
        
        /// <summary>
        /// Average scroll rate of the mouse since a few seconds (in scroll steps per second)
        /// </summary>
        public double scrollRateAvg;
        
        /// <summary>
        /// Max scroll rate of the mouse since a few seconds (in scroll steps per second)
        /// </summary>
        public double scrollRateMax;
    }
}
