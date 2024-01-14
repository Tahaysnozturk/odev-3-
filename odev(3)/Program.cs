using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Araç türünü seçin (Otomobil/O, Kamyon/K, İş Makinası/I): ");
        char aracTuru = char.ToUpper(Console.ReadKey().KeyChar);

        Console.WriteLine("\n\nKalma süresini saat cinsinden girin: ");
        int kalmaSuresi = int.Parse(Console.ReadLine());

        double toplamUcret = HesaplaUcret(aracTuru, kalmaSuresi);

        Console.WriteLine($"\n\nToplam çıkış ücreti: {toplamUcret} TL");

        Console.ReadKey();
    }

    static double HesaplaUcret(char aracTuru, int kalmaSuresi)
    {
        double toplamUcret = 0;

        if (kalmaSuresi <= 2)
        {
            if (aracTuru == 'O') toplamUcret = 5;
            else if (aracTuru == 'K') toplamUcret = 8;
            else if (aracTuru == 'I') toplamUcret = 12;
        }
        else
        {
            if (aracTuru == 'O') toplamUcret = 5 + (kalmaSuresi - 2) / 10 * 1;
            else if (aracTuru == 'K') toplamUcret = 8 + (kalmaSuresi - 2) / 10 * 2;
            else if (aracTuru == 'I') toplamUcret = 12 + (kalmaSuresi - 2) / 8 * 3;
        }

        return toplamUcret;
    }
}
