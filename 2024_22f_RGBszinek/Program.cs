using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_22f_RGBszinek
{
	internal class Program
	{
		class RGB
		{
			public int r;
			public int g;
			public int b;
		}

		static void Main(string[] args)
		{
			List<List<RGB>> ll = Beolvas("kep.txt");

			Console.WriteLine(ll[0].Count);

            Console.WriteLine("Adj meg egy sort és egy oszlopot!");
			int sor = int.Parse(Console.ReadLine());
			int oszlop = int.Parse(Console.ReadLine());
			Console.WriteLine($"{ll[sor - 1][oszlop - 1].r}, {ll[sor - 1][oszlop - 1].g}, {ll[sor - 1][oszlop - 1].b} ");

			// m mátrix n-edik sorának k-adik eleme: m[n][k]
			
            
        }

		private static List<List<RGB>> Beolvas(string path)
		{
			List<List<RGB>> ll = new List<List<RGB>>();

			using (StreamReader f = new StreamReader(path))
			{
				while (!f.EndOfStream)
				{
					List<RGB> ujrgbsor = new List<RGB>();
					string sor = f.ReadLine();
					string[] sortomb = sor.Split(' ');
					for (int i = 0; i < sortomb.Length; i+=3)
					{
						RGB rgb = new RGB();
						rgb.r = int.Parse(sortomb[i + 0]);
						rgb.g = int.Parse(sortomb[i + 1]);
						rgb.b = int.Parse(sortomb[i + 2]);
						ujrgbsor.Add(rgb);
					}
					ll.Add(ujrgbsor);
				}
			}

			return ll;

        }
	}
}
