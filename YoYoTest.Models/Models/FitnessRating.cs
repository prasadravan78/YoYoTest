namespace Yo_Yo_Test.Models
{
    using System;

    /// <summary>
    /// Provides various members of FitnessRating entity.
    /// </summary>
    public class FitnessRating
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets AccumulatedShuttleDistance.
        /// </summary>
        public int AccumulatedShuttleDistance { get; set; }

        /// <summary>
        /// Gets or sets SpeedLevel.
        /// </summary>
        public int SpeedLevel { get; set; }

        /// <summary>
        /// Gets or sets ShuttleNo.
        /// </summary>
        public int ShuttleNo { get; set; }

        /// <summary>
        /// Gets or sets Speed.
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// Gets or sets LevelTime.
        /// </summary>
        public decimal LevelTime { get; set; }

        /// <summary>
        /// Gets or sets CommulativeTime.
        /// </summary>
        public DateTime CommulativeTime { get; set; }

        /// <summary>
        /// Gets or sets StartTime.
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets ApproxVo2Max.
        /// </summary>
        public decimal ApproxVo2Max { get; set; }
    }
}
