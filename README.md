# Last update

Visit the shared link for the GPU-supported solo pool project “bitcrackrandomiser”. Available for puzzle 66,67 & 68.

[Go to bitcrackrandomiser](https://github.com/ilkerccom/bitcrackrandomiser)

[Go to btcpuzzle.info](https://btcpuzzle.info)
 
# Bitcoin-Puzzle-Scanner

![bitcoin-puzzle-scanner](https://i.ibb.co/v4QmWtL/Ekran-Resmi-2022-01-18-20-15-58.png)

## Scan Types

You can use the following scan types.

- **SB** : It scans sequentially from the beginning HEX value to the last HEX value; first to last.
- **SE** : It scans in reverse order from the end HEX value to the beginning HEX value; last to first.
- **R** : It scans by generating completely random HEX values. The generated HEX values are derived from the HEX ranges of the entered Puzzle.


> On a Macbook Pro 2019, Core i9 2.3Ghz computer, approximately 20,000 addresses are scanned per second with 4 threads. 

> It only works on CPU. Currently does not support graphics cards.

> I am aware that the number of scans is quite low, I plan to improve speed increase methods whenever I have the opportunity..

## Default Puzzles

### Puzzle #64 (0.64 BTC)

Puzzle information number 64, which is an unsolved puzzle.

> Start HEX value
> 0000000000000000000000000000000000000000000000008000000000000000

> End HEX value
> 000000000000000000000000000000000000000000000000ffffffffffffffff

> Target wallet address
> 16jY7qLJnxb7CHZyqBP8qca9d51gAjyXQN

### Other Puzzles

Puzzle 1 and 10 have been added for testing purposes.

If you want to add a new puzzle, you can use the file below.

    /list/PuzzleList.cs

You can define each new puzzle as a Puzzle object;

    new Puzzle
    {
        Number = "10",
        HexStart = "0000000000000000000000000000000000000000000000000000000000000200",
        HexStop = "00000000000000000000000000000000000000000000000000000000000003ff",
        Address = "1LeBZP5QCwwgXRtmVUvTVrraqPUokyLHqe",
        AddressType = AddressType.Compressed
    },

You can reach the Bitcoin transaction related to the puzzle below;

[Blockchain (16jY7qLJnxb7CHZyqBP8qca9d51gAjyXQN)](https://www.blockchain.com/btc/tx/08389f34c98c606322740c0be6a7125d9860bb8d5cb182c02f98461e5fa6cd15)

### What if I'm lucky?
If the target wallet address is found, a new **txt** file will be created in the **/found/** folder in the directory where the application is run, and related information will also be displayed on the console screen.

## .NET Core

Platform independent, you can use it on any operating system. **.NET Runtime 3.1.0** should be installed for platforms such as Windows, Macos, Linux.

You can download it from the link below;
https://dotnet.microsoft.com/en-us/download/dotnet/3.1

## Usage
`Select a puzzle` = write **66** (or any puzzle number) and ENTER

`Select a scan type` = write **R** or **SB** or **SE** and ENTER

`Enter CPU threads` = write **8** (or 1-32) and ENTER

## Donate

**If you like it, you can donate (Bitcoin BTC)**

    1eosEvvesKV6C2ka4RDNZhmepm1TLFBtw

## Disclaimer
ALL THE CODES, PROGRAM AND INFORMATION ARE FOR EDUCATIONAL PURPOSES ONLY. USE IT AT YOUR OWN RISK. THE DEVELOPER WILL NOT BE RESPONSIBLE FOR ANY LOSS, DAMAGE OR CLAIM ARISING FROM USING THIS PROGRAM.

**Libraries used**
https://github.com/MetacoSA/NBitcoin
