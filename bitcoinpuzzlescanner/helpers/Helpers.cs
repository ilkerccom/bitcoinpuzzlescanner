using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Threading.Tasks;
using NBitcoin;

namespace bitcoinpuzzlescanner
{
    public static class Helpers
    {
        /// <summary>
        /// Write console message.
        /// </summary>
        /// <param name="Message">Message to show</param>
        public static void WriteInfo(string Message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Message);
            Console.ForegroundColor = ConsoleColor.Green;
        }

        /// <summary>
        /// Write mesagge to console if address found
        /// </summary>
        public static void WriteFound(string Address, string PrivateKey)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("(!) Congratulations. Target address found. Details can be found below and in the generated text file in /found folder. (!)");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Address);
            Console.WriteLine(PrivateKey);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("The address where you can donate if you feel like it => 1eosEvvesKV6C2ka4RDNZhmepm1TLFBtw <=");
        }

        /// <summary>
        /// Generate random big integer in range
        /// </summary>
        /// <param name="_Random"></param>
        /// <param name="Min"></param>
        /// <param name="Max"></param>
        /// <returns>Random BigInteger</returns>
        public static BigInteger RandomBigInteger(this Random _Random, BigInteger Min, BigInteger Max)
        {
            if (Min > Max) throw new ArgumentException();
            if (Min == Max) return Min;
            BigInteger _Z = Max - 1 - Min;
            byte[] Bytes = _Z.ToByteArray();
            byte LastByteMask = 0b11111111;
            for (byte Mask = 0b10000000; Mask > 0; Mask >>= 1, LastByteMask >>= 1)
            {
                if ((Bytes[Bytes.Length - 1] & Mask) == Mask) break;
            }
            while (true)
            {
                _Random.NextBytes(Bytes);
                Bytes[Bytes.Length - 1] &= LastByteMask;
                var Result = new BigInteger(Bytes);
                if (Result <= _Z) return Result + Min;
            }
        }

        /// <summary>
        /// Random generate single HEX value in range
        /// </summary>
        /// <param name="Start">HEX start</param>
        /// <param name="End">HEX end</param>
        /// <returns>Hex value</returns>
        public static string RandomHex(string Start, string End)
        {
            BigInteger HexStart = BigInteger.Parse(Start, System.Globalization.NumberStyles.HexNumber);
            BigInteger HexEnd = BigInteger.Parse(End, System.Globalization.NumberStyles.HexNumber);
            BigInteger Random = RandomBigInteger(new Random(), HexStart, HexEnd);

            return String.Format("{0:x64}", Random);
        }

        /// <summary>
        /// Get maximum keys length in HEX range
        /// </summary>
        /// <param name="Start">HEX start</param>
        /// <param name="End">HEX ed</param>
        /// <returns>Max. keys length</returns>
        public static BigInteger GetMaxKeys(string Start, string End)
        {
            BigInteger HexStart = BigInteger.Parse(Start, System.Globalization.NumberStyles.HexNumber);
            BigInteger HexEnd = BigInteger.Parse(End, System.Globalization.NumberStyles.HexNumber);

            return (HexEnd - HexStart) + 1;
        }

        /// <summary>
        /// Random generate array HEX value list in range
        /// </summary>
        /// <param name="Start">HEX start</param>
        /// <param name="End">Hex end</param>
        /// <param name="KeysPerPage">Keys per page</param>
        /// <returns></returns>
        public static List<models.Key> RandomHexList(string Start, string End, int ParallelScan = 1000)
        {
            BigInteger HexStart = BigInteger.Parse(Start, System.Globalization.NumberStyles.HexNumber);
            BigInteger HexEnd = BigInteger.Parse(End, System.Globalization.NumberStyles.HexNumber);
            BigInteger Random = RandomBigInteger(new Random(), HexStart, HexEnd);

            List<models.Key> KeyList = new List<models.Key>();
            for (int i = 0; i < ParallelScan; i++)
            {
                string Hex = String.Format("{0:x64}", Random);
                string Address = HexToAddress(Hex);
                KeyList.Add(new models.Key { Address = Address, PrivateKey = Hex });
                Random++;

                if (Random > HexEnd)
                    Random = HexEnd;
            }

            return KeyList;
        }

        /// <summary>
        /// Generate hex from start to end
        /// </summary>
        /// <param name="Start">HEX start</param>
        /// <param name="End">HEX end</param>
        /// <param name="ParallelScan">Keys per page</param>
        /// <returns></returns>
        public static List<models.Key> RandomHexList(BigInteger Start, string End, int ParallelScan = 1000)
        {
            BigInteger HexStart = Start;
            BigInteger HexEnd = BigInteger.Parse(End, System.Globalization.NumberStyles.HexNumber);

            List<models.Key> KeyList = new List<models.Key>();
            for (int i = 0; i < ParallelScan; i++)
            {
                string Hex = String.Format("{0:x64}", HexStart);
                string Address = HexToAddress(Hex);
                KeyList.Add(new models.Key { Address = Address, PrivateKey = Hex });
                HexStart++;

                if (HexStart > HexEnd)
                    HexStart = HexEnd;
            }

            return KeyList;
        }

        /// <summary>
        /// Generate hex from end to start
        /// </summary>
        /// <param name="Start">HEX start</param>
        /// <param name="End">HEX end</param>
        /// <param name="ParallelScan">Keys per page</param>
        /// <returns></returns>
        public static List<models.Key> RandomHexList(string Start, BigInteger End, int ParallelScan = 1000)
        {
            BigInteger HexStart = BigInteger.Parse(Start, System.Globalization.NumberStyles.HexNumber);
            BigInteger HexEnd = End;

            List<models.Key> KeyList = new List<models.Key>();
            for (int i = 0; i < ParallelScan; i++)
            {
                string Hex = String.Format("{0:x64}", HexEnd);
                string Address = HexToAddress(Hex);
                KeyList.Add(new models.Key { Address = Address, PrivateKey = Hex });
                HexEnd--;

                if (HexEnd <= HexStart)
                    HexEnd = HexStart;
            }

            return KeyList;
        }

        /// <summary>
        /// Converts HEX string to Biginteger
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        public static BigInteger HexToBigInteger(string Hex)
        {
            return BigInteger.Parse(Hex, System.Globalization.NumberStyles.HexNumber);
        }

        /// <summary>
        /// Converts HEX value to Bitcoin Wallet Address
        /// </summary>
        /// <param name="Hex">Hex value</param>
        /// <param name="IsCompressed">Return compressed address or no</param>
        /// <returns></returns>
        public static string HexToAddress(string Hex, bool IsCompressed = true)
        {
            string PrivateKey = "80" + Hex;
            string Hash1 = SHA256(PrivateKey);
            string Hash2 = SHA256(Hash1);
            string First4Bytes = Hash2.Substring(0, 8);
            string Checksum = (PrivateKey + First4Bytes);
            byte[] Data = StringToByteArray(Checksum);
            string WIF = NBitcoin.DataEncoders.Encoders.Base58.EncodeData(Data);

            if (IsCompressed)
            {
                var Secret = new BitcoinSecret(WIF, Network.Main);
                return Secret.PubKey.Compress().GetAddress(ScriptPubKeyType.Legacy, Network.Main).ToString();
            }
            else
            {
                var Secret = new BitcoinSecret(WIF, Network.Main);
                return Secret.GetAddress(ScriptPubKeyType.Legacy).ToString();
            }
        }

        /// <summary>
        /// Parse string to enum
        /// </summary>
        /// <typeparam name="T">Enum type to try parse</typeparam>
        /// <param name="Value">String to convert enum</param>
        /// <returns></returns>
        public static T ParseEnum<T>(string Value)
        {
            return (T)Enum.Parse(typeof(T), Value, true);
        }

        /// <summary>
        /// Convert string to SHA256
        /// </summary>
        /// <param name="Value"></param>
        /// <returns>Hashed string</returns>
        public static string SHA256(string Value)
        {
            byte[] Bytes = StringToByteArray(Value);
            SHA256Managed Sha = new SHA256Managed();
            string HashString = String.Empty;
            byte[] encrypt = Sha.ComputeHash(Bytes);
            foreach (byte _Byte in encrypt)
            {
                HashString += _Byte.ToString("x2");
            }
            return HashString;
        }

        /// <summary>
        /// Convert string to byte array
        /// </summary>
        /// <param name="Value"></param>
        /// <returns>byte array</returns>
        public static byte[] StringToByteArray(string Value)
        {
            return Enumerable.Range(0, Value.Length)
                         .Where(x => x % 2 == 0)
                         .Select(x => Convert.ToByte(Value.Substring(x, 2), 16))
                         .ToArray();
        }

        /// <summary>
        /// Saves a file into found folder
        /// </summary>
        /// <param name="PrivateKey"></param>
        /// <param name="Address"></param>
        public static void SaveFile(string PrivateKey, string Address)
        {
            // Save file
            string[] Lines = { PrivateKey, Address, DateTime.Now.ToLongDateString() };
            string AppPath = AppDomain.CurrentDomain.BaseDirectory + "/found/";
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(AppPath, PrivateKey + ".txt")))
            {
                foreach (string Line in Lines)
                    outputFile.WriteLine(Line);
            }
        }
    }
}
