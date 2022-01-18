using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace bitcoinpuzzlescanner
{
    class Program
    {
        /// <summary>
        /// Target address is found
        /// </summary>
        private static bool Found = false;

        /// <summary>
        /// Active puzzle number
        /// </summary>
        private static string Puzzle = "";

        /// <summary>
        /// Active total thread(s) count
        /// </summary>
        private static int Thread = 0;

        /// <summary>
        /// Active scan type
        /// </summary>
        private static string ScanType = "";

        /// <summary>
        /// Scanned keys on scan
        /// </summary>
        private static int ParallelScan = 1000;

        /// <summary>
        /// Active and selected puzzle
        /// </summary>
        private static models.Puzzle ActivePuzzle = new models.Puzzle();

        /// <summary>
        /// Founded key
        /// </summary>
        private static models.Key FoundedKey = new models.Key();

        /// <summary>
        /// Generic puzzle info
        /// </summary>
        private static models.PuzzleInfo PuzzleInfo = new models.PuzzleInfo();

        /// <summary>
        /// Attempts
        /// </summary>
        private static int Attempts = 1;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // User select puzzle number
            while (!PuzzleList.GetPuzzles().Any(e => e.Number == Puzzle))
            {
                Helpers.WriteInfo("Select puzzle number [" + String.Join('/', PuzzleList.GetPuzzles().Select(e => e.Number).ToArray()) + "] :");
                Puzzle = Console.ReadLine();
            }

            // User enter scan type
            while (!Enum.GetValues(typeof(models.ScanType)).Cast<models.ScanType>().Any(e => e.ToString().ToLower() == ScanType.ToLower()))
            {
                Helpers.WriteInfo("Select scan type [" + String.Join('/', Enum.GetValues(typeof(models.ScanType)).Cast<models.ScanType>()) + "] :");
                ScanType = Console.ReadLine().ToLower();
            }

            // User enter thread(s) count
            while (Thread <= 0)
            {
                Helpers.WriteInfo("Enter thread(s) count [1-24] :");
                int.TryParse(Console.ReadLine().ToString(), out Thread);
            }

            // Define selected puzzle
            ActivePuzzle = PuzzleList.GetPuzzles().Where(e => e.Number == Puzzle).First();

            // Set puzzle info
            PuzzleInfo = new models.PuzzleInfo
            {
                FirstKey = Helpers.HexToBigInteger(ActivePuzzle.HexStart),
                LastKey = Helpers.HexToBigInteger(ActivePuzzle.HexStop),
                MaxKeys = Helpers.GetMaxKeys(ActivePuzzle.HexStart, ActivePuzzle.HexStop),
                StartDate = DateTime.Now
            };

            // Start scanner with threads and keep running until it finds the target address
            while (!Found)
            {
                Parallel.For(0, Thread, e => Scan(e));
            }

            // Target address found
            if (Found)
            {
                // Write found message
                Helpers.WriteFound(FoundedKey.Address, FoundedKey.PrivateKey);

                // Save as text file
                Helpers.SaveFile(FoundedKey.PrivateKey, FoundedKey.Address);

                Console.Read();
            }
        }

        private static List<models.Key> KeyList = new List<models.Key>();

        /// <summary>
        /// Scan private keys
        /// </summary>
        /// <param name="Thread"></param>
        static void Scan(int Thread)
        {
            // Generate random keys


            // Scan type
            if (Helpers.ParseEnum<models.ScanType>(ScanType) == models.ScanType.Random)
            {
                // Random generate
                KeyList = Helpers.RandomHexList(ActivePuzzle.HexStart, ActivePuzzle.HexStop, ParallelScan);
            }
            else if (Helpers.ParseEnum<models.ScanType>(ScanType) == models.ScanType.Next)
            {
                // From first hex to last hex
                BigInteger NextToScan = Attempts == 1 ? Helpers.HexToBigInteger(ActivePuzzle.HexStart) : Helpers.HexToBigInteger(ActivePuzzle.HexStart) + (Attempts * ParallelScan);
                KeyList = Helpers.RandomHexList(NextToScan, ActivePuzzle.HexStop, ParallelScan);
            }
            else if (Helpers.ParseEnum<models.ScanType>(ScanType) == models.ScanType.Prev)
            {
                // From last hex to first hex
                BigInteger PrevToScan = Attempts == 1 ? Helpers.HexToBigInteger(ActivePuzzle.HexStop) : Helpers.HexToBigInteger(ActivePuzzle.HexStop) - (Attempts * ParallelScan);
                KeyList = Helpers.RandomHexList(ActivePuzzle.HexStart, PrevToScan, ParallelScan);
            }

            // Check for found or not
            if (KeyList.Any(e => e.Address == ActivePuzzle.Address))
            {
                // Set found to true
                Found = true;

                // Define founded key
                FoundedKey = KeyList.Where(e => e.Address == ActivePuzzle.Address).First();
            }
            else
            {
                // Not found
                if (Thread == 0)
                {
                    // Percentage info
                    Console.Clear();
                    double CompletedPercentage = (double)((Attempts * ParallelScan) * 100) / (double)PuzzleInfo.MaxKeys;
                    double LuckyPercentage = (double)(1 * 100) / (double)PuzzleInfo.MaxKeys;

                    // Time info
                    DateTime Current = DateTime.Now;
                    int Days = (int)(Current - PuzzleInfo.StartDate).TotalDays;
                    int Hours = (Current - PuzzleInfo.StartDate).Hours;
                    int Minutes = (Current - PuzzleInfo.StartDate).Minutes;
                    int Seconds = (Current - PuzzleInfo.StartDate).Seconds;
                    int PerSeconds = (int)(Attempts * ParallelScan) / (int)((Current - PuzzleInfo.StartDate).TotalSeconds + 1);

                    // Write info
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(String.Format("Running Bitcoin Puzzle #{0}# for {1} days, {2} hours, {3} minutes, {4} seconds ({5} k/seconds)", ActivePuzzle.Number, Days, Hours, Minutes, Seconds, PerSeconds));
                    Console.WriteLine(String.Format("Target address ({0}) Last address ({1})", ActivePuzzle.Address, KeyList.Last().Address));
                    Console.WriteLine("====================================================================================");
                    Console.WriteLine(String.Format("Lucky ratio  => %{0}", LuckyPercentage.ToString("0.0000000000000000000000000000000000000000000000000000000000000000000")));
                    Console.WriteLine(String.Format("Percentage   => %{0}", CompletedPercentage.ToString("0.0000000000000000000000000000000000000000000000000000000000000000000")));
                    Console.WriteLine(String.Format("Keys scanned => {0} key(s)", (Attempts * ParallelScan)));
                    Console.WriteLine(String.Format("Total keys   => {0} key(s)", PuzzleInfo.MaxKeys));
                    Console.WriteLine("====================================================================================");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(String.Format("Not Found    => {0}", KeyList.Last().PrivateKey));
                }
            }

            // Increase attempts
            Attempts++;
        }
    }
}
