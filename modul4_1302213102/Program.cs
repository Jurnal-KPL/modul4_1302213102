// See https://aka.ms/new-console-template for more information
class KodeBuah
{
    enum Buah
    {
        Apel,
        Aprikot,
        Alpukat0,
        Pisang,
        Paprika,
        Blackberry,
        Ceri,
        Kelapa,
        Jagung,
    }
    private static string getKodeBuah(Buah buah)
    {
        string[] kode = {"A00", "B00", "C00", "D00", "E00", "F00",
            "H00", "I00", "J00"};
        return kode[(int)buah];
    }
    
    private static void Main(string[] args)
    {
        Console.WriteLine(getKodeBuah(Buah.Jagung));
        Console.WriteLine(getKodeBuah(Buah.Apel));
    }
    
}
