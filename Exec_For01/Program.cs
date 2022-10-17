using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 5; i >= 1; i--)
			{

				int countStar = i;
				string row = new string('*', countStar);
				Console.WriteLine(row);
			}
		}
	}
}
