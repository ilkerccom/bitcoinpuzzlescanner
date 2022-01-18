namespace bitcoinpuzzlescanner.models
{
    /// <summary>
    /// Puzzle model
    /// </summary>
    public class Puzzle
    {
        /// <summary>
        /// Puzzle number
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Puzzle HEX start
        /// </summary>
        public string HexStart { get; set; }

        /// <summary>
        /// Puzzle HEX strop
        /// </summary>
        public string HexStop { get; set; }

        /// <summary>
        /// Target Bitcoin wallet address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Bitcoin wallet address type
        /// </summary>
        public AddressType AddressType { get; set; }
    }

    /// <summary>
    /// Bitcoin wallet address type
    /// </summary>
    public enum AddressType
    {
        Compressed, /* Compressed wallet address */
        Uncompressed /* Uncompressed wallet address */
    }

    /// <summary>
    /// Scan type
    /// </summary>
    public enum ScanType
    {
        Next, /* Start > end */
        Prev, /* End > start */
        Random /* Random */
    }
}
