using System;
using System.Collections.Generic;
using bitcoinpuzzlescanner.models;

namespace bitcoinpuzzlescanner
{
    public class PuzzleList
    {
        /// <summary>
        /// Returns all puzzles in a list
        /// </summary>
        /// <returns></returns>
        public static List<Puzzle> GetPuzzles()
        {
            // Static puzzle list
            return new List<Puzzle>
            {
                new Puzzle
                {
                    Number = "1",
                    HexStart = "0000000000000000000000000000000000000000000000000000000000000001",
                    HexStop = "0000000000000000000000000000000000000000000000000000000000000001",
                    Address = "1BgGZ9tcN4rm9KBzDn7KprQz87SZ26SAMH",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "10",
                    HexStart = "0000000000000000000000000000000000000000000000000000000000000200",
                    HexStop = "00000000000000000000000000000000000000000000000000000000000003ff",
                    Address = "1LeBZP5QCwwgXRtmVUvTVrraqPUokyLHqe",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "64",
                    HexStart = "0000000000000000000000000000000000000000000000008000000000000000",
                    HexStop = "000000000000000000000000000000000000000000000000ffffffffffffffff",
                    Address = "16jY7qLJnxb7CHZyqBP8qca9d51gAjyXQN",
                    AddressType = AddressType.Compressed
                },
            };
        }
    }
}
