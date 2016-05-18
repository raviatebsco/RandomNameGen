using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			var aNames = new string[] {
				"X",
				"7",
				"Zeppelin",
				"Crazy Legs",
				"Sliver",
				"Build-R-Us",
				"The Gang",
				"Pro Pirates",
				"Accolades",
				"Brainy Buddies",
				"Bosco"
			};

			Console.WriteLine(string.Format("And the Winner is : {0}!!!", aNames[(new Random()).Next(0, aNames.Count() - 1)]));
			Console.ReadLine();
		}
	}
}
