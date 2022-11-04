using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19759005_BoraBerkUzun
{
    class Program
    {
        static int[,] sayilar = new int[10, 6];
        static int kolonSayisi = 0;

        static void Main(string[] args)
        {


            List<int> kolon;
            Random r = new Random();
            while (true)
            {
                try
                {
                    Console.Write("Oynanacak Kolon Sayisi:");
                    kolonSayisi = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("Hatalı değer. Tekrar\n");
                }
            }

            Console.Write("Sayilar Rastgele Oluşturulsun Mu?(E-H)");
            string cevap = Console.ReadLine();
            if (cevap[0] == 'E')
            {
                for (int i = 0; i < kolonSayisi; i++)
                {
                    Console.Write((i + 1) + ". Kolon : ");
                    kolon = new List<int>();
                    for (int k = 0; k < 6; k++)
                    {
                        int rSayi = 0;
                        do
                        {
                            rSayi = r.Next(1, 91);
                        } while (kolon.Contains(rSayi));
                        kolon.Add(rSayi);
                    }
                    kolon.Sort();
                    for (int ki = 0; ki < 6; ki++)
                    {
                        sayilar[i, ki] = kolon[ki];
                        Console.Write(kolon[ki]+ " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.Write("Kolon sayısını tekrardan belirlemek ister misiniz? (E-H)");
                string cevap2 = Console.ReadLine();
                if (cevap2[0] == 'E')
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write("Kolon sayısını tekrardan belirle:");
                            kolonSayisi = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.Write("Hatalı değer. Tekrar \n");
                        }
                    }
                }
                
                    for (int i = 0; i < kolonSayisi; i++)
                    {
                        try
                        {

                            Console.Write((i + 1) + ". Kolon (örnek 1 2 3 4 5 6) : ");
                            string kolonMetni = Console.ReadLine();
                            string[] parca = kolonMetni.Split(' ');
                            kolon = new List<int>();


                            if (parca.Length > 6)
                            {
                                i--;
                                Console.WriteLine("6 dan fazla değer giremezsiniz!!!");
                            }
                            else
                            {
                                for (int k = 0; k < 6; k++)
                                {
                                    int sayi;
                                    sayi = Convert.ToInt32(parca[k]);
                                    if (kolon.Contains(sayi))
                                    {
                                        //Console.WriteLine("Hatalı değer girişi");
                                        sayi = 0;
                                        sayi = 1 / sayi;
                                    }
                                    else
                                    {
                                        kolon.Add(sayi);
                                    }
                                }

                                kolon.Sort();
                                for (int ki = 0; ki < 6; ki++)
                                {
                                    sayilar[i, ki] = kolon[ki];
                                    Console.Write(kolon[ki] + " ");
                                }
                                Console.WriteLine();
                            }

                        }
                        catch
                        {
                            i--;
                            Console.WriteLine("Hatalı Giriş !!!");
                        }
                    }
                
                
            }
            List<int> cekilisSayilari = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                int csayi = r.Next(1,91);
                if (cekilisSayilari.Contains(csayi))
                {
                    i--;
                }
                else
                {
                    cekilisSayilari.Add(csayi);
                }
            }
            cekilisSayilari.Sort();
            Console.WriteLine("Çekiliş Sayıları.");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(cekilisSayilari[i]+" - ");
            }

            int maxBilinenSayi = 0;
            int bilinenSayi = 0;
            for (int i = 0; i < kolonSayisi; i++)
            {
                bilinenSayi = 0;
                for (int k = 0; k < 6; k++)
                {
                    if (cekilisSayilari.Contains(sayilar[i,k]))
                    {
                        bilinenSayi++;
                    }
                }
                if (bilinenSayi>maxBilinenSayi)
                {
                    maxBilinenSayi = bilinenSayi;
                }
            }
            Console.WriteLine("\nTebrikler "+ maxBilinenSayi +" bildiniz...");

            Console.ReadKey();
        }
    }
}
