# Bitcoin-Puzzle-Scanner

![bitcoin-puzzle-scanner](https://i.ibb.co/v4QmWtL/Ekran-Resmi-2022-01-18-20-15-58.png)

## Tarama Tipleri

Aşağıdaki tarama tiplerini kullanabilirsiniz.

- **next** : İlk HEX değerinden başlayarak, en son HEX değerine kadar sıralı bir tarama yapar.
- **prev** : Son HEX değerinden başlayarak, ilk HEX değerine kadar ters sıralı tarama yapar.
- **random** : Tamamen rastgele HEX değerleri oluşturularak tarama yapar. Oluşturulan HEX değerleri, girilen Puzzle'ın HEX aralıklarında türetilir.


> Macbook Pro 2019, Core i9 2.3Ghz bilgisayarda 4 thread ile saniyede yaklaşık 20.000 adres taratılmaktadır. 

> Sadece CPU üzerinde çalışıyor. Ekran kartlarını şuan için desteklemiyor.

> Tarama sayısının oldukça düşük olduğunun farkındayım, fırsat buldukça hız arttırma yöntemlerini geliştirmeyi düşünüyorum.

## Varsayılan Puzzle'lar

### Puzzle #64 (0.64 BTC)

Henüz çözülmemiş bir puzzle olan 64 numaralı Puzzle bilgisi. 

> Başlangıç HEX değeri
> 0000000000000000000000000000000000000000000000008000000000000000

> Bitiş HEX değeri
> 000000000000000000000000000000000000000000000000ffffffffffffffff

> Hedef cüzdan adresi
> 16jY7qLJnxb7CHZyqBP8qca9d51gAjyXQN

### Diğer Puzzle'lar

Puzzle 1 ve 10 test amaçlı eklenmiştir.

Eğer yeni bir puzzle eklemek isterseniz aşağıdaki dosyayı kullanabilirsiniz.

    /list/PuzzleList.cs

Her yeni puzzle'ı bir Puzzle objesi olarak tanımlayabilirsiniz;

    new Puzzle
    {
        Number = "10",
        HexStart = "0000000000000000000000000000000000000000000000000000000000000200",
        HexStop = "00000000000000000000000000000000000000000000000000000000000003ff",
        Address = "1LeBZP5QCwwgXRtmVUvTVrraqPUokyLHqe",
        AddressType = AddressType.Compressed
    },

Puzzla ile ilgili Bitcoin işlemine aşağıdan ulaşabilirsiniz;

[Blockchain (16jY7qLJnxb7CHZyqBP8qca9d51gAjyXQN)](https://www.blockchain.com/btc/tx/08389f34c98c606322740c0be6a7125d9860bb8d5cb182c02f98461e5fa6cd15)

### Şansım yaver giderse?
Eğer hedef cüzdan adresi bulunursa uygulamanın çalıştırıldığı dizinde **/found/** klasörüne yeni bir **txt** dosyası oluşturulacak ve konsol ekranında da ayrıca ilgili bilgiler gösterilecektir.

## .NET Core

Platform bağımsız, dilediğiniz işletim sisteminde kullanabilirsiniz. Windows, Macos, Linux gibi platformlar için  **.NET Runtime 3.1.0** yüklenmeli. 

Aşağıdaki bağlantıdan indirebilirsiniz;
https://dotnet.microsoft.com/en-us/download/dotnet/3.1

**Eğer hoşunuza gittiyse bağış yapabilirsiniz (Bitcoin BTC)**

    1eosEvvesKV6C2ka4RDNZhmepm1TLFBtw

## Disclaimer
ALL THE CODES, PROGRAM AND INFORMATION ARE FOR EDUCATIONAL PURPOSES ONLY. USE IT AT YOUR OWN RISK. THE DEVELOPER WILL NOT BE RESPONSIBLE FOR ANY LOSS, DAMAGE OR CLAIM ARISING FROM USING THIS PROGRAM.

**Yararlanılan kütüphaneler**
https://github.com/MetacoSA/NBitcoin