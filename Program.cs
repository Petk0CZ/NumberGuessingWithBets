using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myslimsicisilko_XDDD
{
    class Program
    {
        static void Main(string[] args)
        {
            int vyhra = 0;
            int podminka0 = 0;
            int sazka;
            string odpoved0;
            int skore = 20;
            int podminka = 0;
            int mecislo;
            int myslim;
            string odpoved;
            Random random = new Random();
            Console.WriteLine("Zadej rozsah čísel pro zadání");
            int rozsah = int.Parse(Console.ReadLine());
            while (podminka == 0)
            {
                podminka0 = 0;
                Console.WriteLine("Tvé skóre je {0}", skore);
                Console.WriteLine("Zadej sázku");
                odpoved0 = "ano";
                if (odpoved0 == "ano")
                {
                    while (podminka0 == 0)
                    {
                        Console.WriteLine("Kolik chceš vsadit? V případě výhry dostaneš dvojnásobek sázky");
                        sazka = int.Parse(Console.ReadLine());
                        if (sazka > skore)
                        {
                            Console.WriteLine("Tolik vsadit nemůžeš, vsaď znovu");
                        }
                        else
                        {
                            skore = skore - sazka;
                            vyhra = sazka * 2;
                            Console.WriteLine("Vsadil jsi {0}, v případě výhry tedy získáš {1}", sazka, vyhra);
                            podminka0 = 1;
                        }
                    }
                        
                }else { }
                myslim = random.Next(0, rozsah);
                Console.WriteLine("Myslím si číslo, jaké číslo to je?");
                mecislo = int.Parse(Console.ReadLine());
                if (mecislo == myslim)
                {
                    Console.WriteLine("Uhodl jsi číslo");
                    skore = skore + vyhra;
                }
                else
                {
                    Console.WriteLine("nope, hehehe :))))");
                }
                if (skore == 0)
                {
                    podminka = 1;
                }
                Console.WriteLine("___________________________________________");
                Console.WriteLine("napiš -a- jestli chceš hádat znova");
                Console.WriteLine("___________________________________________");
                odpoved = Console.ReadLine();
                if (odpoved == "a")
                {
                    Console.WriteLine("alrighty then");
                }
                
                else
                {
                    podminka = 1;
                }
                Console.Clear();
            }
            Console.WriteLine("Stiskni jakékoliv tlačítko pro ukončení");
            Console.ReadKey();
        }
    }
}
