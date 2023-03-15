// See https://aka.ms/new-console-template for more information

using modul4_1302213102;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Apel));
        Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Jagung));

        PosisiKarakterGame Posisi = new PosisiKarakterGame();
        Console.WriteLine( "Posisi pertama adalah "+ Posisi.currentState);
        Posisi.ActivateTrigger(PosisiKarakterGame.trigger.TombolW);
        Console.WriteLine("Maka sekarang aku " + Posisi.currentState);
        Posisi.ActivateTrigger(PosisiKarakterGame.trigger.TombolS);
        Console.WriteLine("Maka sekarang aku " + Posisi.currentState);
    }
}

