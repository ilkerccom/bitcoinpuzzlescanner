using System;
using System.Numerics;

namespace bitcoinpuzzlescanner.models
{
    public class PuzzleInfo
    {
        /// <summary>
        /// Max available keys
        /// </summary>
        public BigInteger MaxKeys { get; set; }

        /// <summary>
        /// First key
        /// </summary>
        public BigInteger FirstKey { get; set; }

        /// <summary>
        /// Last key
        /// </summary>
        public BigInteger LastKey { get; set; }

        /// <summary>
        /// Percentage status in
        /// </summary>
        public BigInteger Percentage { get; set; }

        /// <summary>
        /// Start datetime info
        /// </summary>
        public DateTime StartDate { get; set; }
    }
}
