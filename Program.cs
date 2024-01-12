using System;

namespace karakter_degistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle giriniz : ");
            string ifade = Console.ReadLine();
            KarakterDegistirme(ifade);
        }

        static void KarakterDegistirme(string ifade)
        {
            string[] kelimeDizisi = ifade.Split(' ');
            char ilkHarf;
            char sonHarf;
            string yeniKelime;
            for (int i = 0; i < kelimeDizisi.Length; i++)
            {
                yeniKelime = String.Empty;
                ilkHarf = kelimeDizisi[i][0];
                sonHarf = kelimeDizisi[i][kelimeDizisi[i].Length - 1];
                for (int j = 0; j < kelimeDizisi[i].Length; j++)
                {
                    if(j == 0)
                    {
                        yeniKelime += sonHarf;
                    }
                    else if (j == kelimeDizisi[i].Length - 1)
                    {
                        yeniKelime += ilkHarf;
                    }
                    else
                    {
                        yeniKelime += kelimeDizisi[i][j];
                    }
                }
                
                kelimeDizisi[i] = yeniKelime;
            }

            Console.Write("Çıktı : ");
            foreach (string kelime in kelimeDizisi)
            {
                Console.Write(kelime + " ");
            }
        }
    }
}
