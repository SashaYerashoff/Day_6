using System;

namespace Day_6
{
    class Program
    {
        static void Main(string[] args)
        {
			/*Console.WriteLine("Ievadiet skaitli: ");
			string ievads = Console.ReadLine();
			Console.WriteLine(PievienoSkaitli(ievads));
			string izvade = PievienoSkaitli(ievads);
			int skaits = izvade.Length;

			Console.WriteLine(skaits);*/

			Console.WriteLine("ievadi pirmo skaitli");
			string ievade1 = Console.ReadLine();
			double skaitlis1 = Convert.ToDouble(ievade1);

			Console.WriteLine("ievadi otro skaitli");
            ievade1 = Console.ReadLine();
            double skaitlis2 = Convert.ToDouble(ievade1);

			if (skaitlis1 != skaitlis2)
			{
				double izvade = SkaitluSalidzinasana(skaitlis1, skaitlis2);
				Console.WriteLine("Lielākais skaitlis ir: " + izvade);
			}
			else
			{
				Console.WriteLine("Kļūda! Cipari ir vienādi.");
			}
			Console.ReadLine();
        }

		static string PievienoSkaitli(string skaitlis)
		{
			string rezultats = "mans skaitlis ir " + skaitlis;
			return rezultats;
		}
		static double SkaitluSalidzinasana (double skaitlis1, double skaitlis2)
		{
			double rezultats;

			if(skaitlis1 < skaitlis2)
			{
				rezultats = skaitlis2;
				return rezultats;
			}
			else
			{
				if(skaitlis2 < skaitlis1)
				{
					rezultats = skaitlis1;
					return rezultats;
				}
				else
				{
					rezultats = 0;
					Console.WriteLine("kļūda! Rezultāts ir vienāds");
					return rezultats;
				}
			}
			//return rezultats;
		}
    }
}
