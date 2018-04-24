using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	class Program
	{




		static void Main(string[] args)
		{
			//tasks: calculate the perimeter and the area of the rooms
			Console.WriteLine("Hello ,and welcome to \"The Room Calculator 3000 \"");
			Console.WriteLine();





			Start:
			Console.WriteLine("Please enter a Length");
			double Length = Double.Parse(Console.ReadLine());
			Console.WriteLine();
			Console.WriteLine("Please enter a Width");
			double Width = Double.Parse(Console.ReadLine());
			Console.WriteLine();

			Double Area = (Length * Width);
			Double Perimeter = ((Length + Length) + (Width + Width));

			Console.WriteLine("The area of the room is " + Perimeter + "ft");

			Console.WriteLine("The area of the room is " + Area + "ft");

			Console.WriteLine("Would you like to measure another room? Y//N");
			string Continue = Console.ReadLine();
			string Yes = "Y";
			string No = "N";


			if (Continue.ToUpper() == Yes || Continue.ToLower() == Yes)
			{

				goto Start;
			}
			else if (Continue.ToUpper() == No || Continue.ToLower() == No)
			{
				Console.Read();
			}
			
				
			

		}
	}
}
