using System;
namespace bitcoinpuzzlescanner.models
{
    /// <summary>
    /// Key model
    /// </summary>
    public class Key
    {
        /// <summary>
        /// Bitcoin wallet address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Bitcoin private key in HEX format
        /// </summary>
        public string PrivateKey { get; set; }
    }
}
