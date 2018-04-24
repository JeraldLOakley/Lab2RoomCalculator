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

			Console.WriteLine("Hello ,and welcome to \"The Room Calculator 3000 \"");
			Console.WriteLine();





			Start:
			Console.Write("Please enter a Length in feet: ");
			double Length = Double.Parse(Console.ReadLine());
			Console.WriteLine();

			Console.Write("Please enter a Width in feet: ");
			double Width = Double.Parse(Console.ReadLine());
			Console.WriteLine();

			Console.Write("Please enter a Height in feet: ");
			double Height = Double.Parse(Console.ReadLine());
			Console.WriteLine();

			double Area = (Length * Width);
			double Perimeter = (Length * 2 + Width * 2);
			double Volume = (Length * Width * Height);

			Console.WriteLine($"The area of the room is {Perimeter}ft");
			Console.WriteLine($"The area of the room is {Area}sqft");
			Console.WriteLine($"The volume of the room is {Volume}cbft");


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
