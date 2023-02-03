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
                    Number = "66",
                    HexStart = "0000000000000000000000000000000000000000000000020000000000000000",
                    HexStop  = "000000000000000000000000000000000000000000000003ffffffffffffffff",
                    Address = "13zb1hQbWVsc2S7ZTZnP2G4undNNpdh5so",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "67",
                    HexStart = "0000000000000000000000000000000000000000000000040000000000000000",
                    HexStop  = "000000000000000000000000000000000000000000000007ffffffffffffffff",
                    Address = "1BY8GQbnueYofwSuFAT3USAhGjPrkxDdW9",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "68",
                    HexStart = "0000000000000000000000000000000000000000000000080000000000000000",
                    HexStop  = "00000000000000000000000000000000000000000000000fffffffffffffffff",
                    Address = "1MVDYgVaSN6iKKEsbzRUAYFrYJadLYZvvZ",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "69",
                    HexStart = "0000000000000000000000000000000000000000000000100000000000000000",
                    HexStop  = "00000000000000000000000000000000000000000000001fffffffffffffffff",
                    Address = "19vkiEajfhuZ8bs8Zu2jgmC6oqZbWqhxhG",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "71",
                    HexStart = "0000000000000000000000000000000000000000000000400000000000000000",
                    HexStop  = "00000000000000000000000000000000000000000000007fffffffffffffffff",
                    Address = "1PWo3JeB9jrGwfHDNpdGK54CRas7fsVzXU",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "72",
                    HexStart = "0000000000000000000000000000000000000000000000800000000000000000",
                    HexStop  = "0000000000000000000000000000000000000000000000ffffffffffffffffff",
                    Address = "1JTK7s9YVYywfm5XUH7RNhHJH1LshCaRFR",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "73",
                    HexStart = "0000000000000000000000000000000000000000000001000000000000000000",
                    HexStop  = "0000000000000000000000000000000000000000000001ffffffffffffffffff",
                    Address = "12VVRNPi4SJqUTsp6FmqDqY5sGosDtysn4",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "74",
                    HexStart = "0000000000000000000000000000000000000000000002000000000000000000",
                    HexStop  = "0000000000000000000000000000000000000000000003ffffffffffffffffff",
                    Address = "1FWGcVDK3JGzCC3WtkYetULPszMaK2Jksv",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "76",
                    HexStart = "0000000000000000000000000000000000000000000008000000000000000000",
                    HexStop  = "000000000000000000000000000000000000000000000fffffffffffffffffff",
                    Address = "1DJh2eHFYQfACPmrvpyWc8MSTYKh7w9eRF",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "77",
                    HexStart = "0000000000000000000000000000000000000000000010000000000000000000",
                    HexStop  = "000000000000000000000000000000000000000000001fffffffffffffffffff",
                    Address = "1Bxk4CQdqL9p22JEtDfdXMsng1XacifUtE",
                    AddressType = AddressType.Compressed
                },
                 new Puzzle
                {
                    Number = "78",
                    HexStart = "0000000000000000000000000000000000000000000020000000000000000000",
                    HexStop  = "000000000000000000000000000000000000000000003fffffffffffffffffff",
                    Address = "15qF6X51huDjqTmF9BJgxXdt1xcj46Jmhb",
                    AddressType = AddressType.Compressed
                },
                 new Puzzle
                {
                    Number = "79",
                    HexStart = "0000000000000000000000000000000000000000000040000000000000000000",
                    HexStop  = "000000000000000000000000000000000000000000007fffffffffffffffffff",
                    Address = "1ARk8HWJMn8js8tQmGUJeQHjSE7KRkn2t8",
                    AddressType = AddressType.Compressed
                },
                 new Puzzle
                {
                    Number = "81",
                    HexStart = "0000000000000000000000000000000000000000000100000000000000000000",
                    HexStop  = "00000000000000000000000000000000000000000001ffffffffffffffffffff",
                    Address = "15qsCm78whspNQFydGJQk5rexzxTQopnHZ",
                    AddressType = AddressType.Compressed
                },
                 new Puzzle
                {
                    Number = "82",
                    HexStart = "0000000000000000000000000000000000000000000200000000000000000000",
                    HexStop  = "00000000000000000000000000000000000000000003ffffffffffffffffffff",
                    Address = "13zYrYhhJxp6Ui1VV7pqa5WDhNWM45ARAC",
                    AddressType = AddressType.Compressed
                },
                  new Puzzle
                {
                    Number = "83",
                    HexStart = "0000000000000000000000000000000000000000000400000000000000000000",
                    HexStop  = "00000000000000000000000000000000000000000007ffffffffffffffffffff",
                    Address = "14MdEb4eFcT3MVG5sPFG4jGLuHJSnt1Dk2",
                    AddressType = AddressType.Compressed
                },
                  new Puzzle
                {
                    Number = "84",
                    HexStart = "0000000000000000000000000000000000000000000800000000000000000000",
                    HexStop  = "0000000000000000000000000000000000000000000fffffffffffffffffffff",
                    Address = "1CMq3SvFcVEcpLMuuH8PUcNiqsK1oicG2D",
                    AddressType = AddressType.Compressed
                },
                   new Puzzle
                {
                    Number = "86",
                    HexStart = "0000000000000000000000000000000000000000002000000000000000000000",
                    HexStop  = "0000000000000000000000000000000000000000003fffffffffffffffffffff",
                    Address = "1K3x5L6G57Y494fDqBfrojD28UJv4s5JcK",
                    AddressType = AddressType.Compressed
                },
                   new Puzzle
                {
                    Number = "87",
                    HexStart = "0000000000000000000000000000000000000000004000000000000000000000",
                    HexStop  = "0000000000000000000000000000000000000000007fffffffffffffffffffff",
                    Address = "1PxH3K1Shdjb7gSEoTX7UPDZ6SH4qGPrvq",
                    AddressType = AddressType.Compressed
                },
                   new Puzzle
                {
                    Number = "88",
                    HexStart = "0000000000000000000000000000000000000000008000000000000000000000",
                    HexStop  = "000000000000000000000000000000000000000000ffffffffffffffffffffff",
                    Address = "16AbnZjZZipwHMkYKBSfswGWKDmXHjEpSf",
                    AddressType = AddressType.Compressed
                },
                 new Puzzle
                {
                    Number = "89",
                    HexStart = "0000000000000000000000000000000000000000010000000000000000000000",
                    HexStop  = "000000000000000000000000000000000000000001ffffffffffffffffffffff",
                    Address = "19QciEHbGVNY4hrhfKXmcBBCrJSBZ6TaVt",
                    AddressType = AddressType.Compressed
                },

                new Puzzle
                {
                    Number = "91",
                    HexStart = "0000000000000000000000000000000000000000040000000000000000000000",
                    HexStop  = "000000000000000000000000000000000000000007ffffffffffffffffffffff",
                    Address = "1EzVHtmbN4fs4MiNk3ppEnKKhsmXYJ4s74",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "92",
                    HexStart = "0000000000000000000000000000000000000000080000000000000000000000",
                    HexStop  = "00000000000000000000000000000000000000000fffffffffffffffffffffff",
                    Address = "1AE8NzzgKE7Yhz7BWtAcAAxiFMbPo82NB5",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "93",
                    HexStart = "0000000000000000000000000000000000000000100000000000000000000000",
                    HexStop  = "00000000000000000000000000000000000000001fffffffffffffffffffffff",
                    Address = "17Q7tuG2JwFFU9rXVj3uZqRtioH3mx2Jad",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "94",
                    HexStart = "0000000000000000000000000000000000000000200000000000000000000000",
                    HexStop  = "00000000000000000000000000000000000000003fffffffffffffffffffffff",
                    Address = "1K6xGMUbs6ZTXBnhw1pippqwK6wjBWtNpL",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "96",
                    HexStart = "0000000000000000000000000000000000000000800000000000000000000000",
                    HexStop  = "0000000000000000000000000000000000000000ffffffffffffffffffffffff",
                    Address = "15ANYzzCp5BFHcCnVFzXqyibpzgPLWaD8b",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "97",
                    HexStart = "0000000000000000000000000000000000000001000000000000000000000000",
                    HexStop  = "0000000000000000000000000000000000000001ffffffffffffffffffffffff",
                    Address = "18ywPwj39nGjqBrQJSzZVq2izR12MDpDr8",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "98",
                    HexStart = "0000000000000000000000000000000000000002000000000000000000000000",
                    HexStop  = "0000000000000000000000000000000000000003ffffffffffffffffffffffff",
                    Address = "1CaBVPrwUxbQYYswu32w7Mj4HR4maNoJSX",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "99",
                    HexStart = "0000000000000000000000000000000000000004000000000000000000000000",
                    HexStop  = "0000000000000000000000000000000000000007ffffffffffffffffffffffff",
                    Address = "1JWnE6p6UN7ZJBN7TtcbNDoRcjFtuDWoNL",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "101",
                    HexStart = "0000000000000000000000000000000000000010000000000000000000000000",
                    HexStop  = "000000000000000000000000000000000000001fffffffffffffffffffffffff",
                    Address = "1CKCVdbDJasYmhswB6HKZHEAnNaDpK7W4n",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "102",
                    HexStart = "0000000000000000000000000000000000000020000000000000000000000000",
                    HexStop  = "000000000000000000000000000000000000003fffffffffffffffffffffffff",
                    Address = "1PXv28YxmYMaB8zxrKeZBW8dt2HK7RkRPX",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "103",
                    HexStart = "0000000000000000000000000000000000000040000000000000000000000000",
                    HexStop  = "000000000000000000000000000000000000007fffffffffffffffffffffffff",
                    Address = "1AcAmB6jmtU6AiEcXkmiNE9TNVPsj9DULf",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "104",
                    HexStart = "0000000000000000000000000000000000000080000000000000000000000000",
                    HexStop  = "00000000000000000000000000000000000000ffffffffffffffffffffffffff",
                    Address = "1EQJvpsmhazYCcKX5Au6AZmZKRnzarMVZu",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "106",
                    HexStart = "0000000000000000000000000000000000000200000000000000000000000000",
                    HexStop  = "00000000000000000000000000000000000003ffffffffffffffffffffffffff",
                    Address = "18KsfuHuzQaBTNLASyj15hy4LuqPUo1FNB",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "107",
                    HexStart = "0000000000000000000000000000000000000400000000000000000000000000",
                    HexStop  = "00000000000000000000000000000000000007ffffffffffffffffffffffffff",
                    Address = "15EJFC5ZTs9nhsdvSUeBXjLAuYq3SWaxTc",
                    AddressType = AddressType.Compressed
                },
                new Puzzle
                {
                    Number = "108",
                    HexStart = "0000000000000000000000000000000000000800000000000000000000000000",
                    HexStop  = "0000000000000000000000000000000000000fffffffffffffffffffffffffff",
                    Address = "1HB1iKUqeffnVsvQsbpC6dNi1XKbyNuqao",
                    AddressType = AddressType.Compressed
                },

            };
        }
    }
}
