using System;
using Math6thGrade.Library;

namespace Math6thGrade.App
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length != 3)
			{
				Console.WriteLine("Usage: -lcm|-gcf <number1> <number2>");
				return;
			}

			var operation = args[0];
			if (!int.TryParse(args[1], out int number1) || !int.TryParse(args[2], out int number2))
			{
				Console.WriteLine("Please enter valid numbers.");
				return;
			}

			var math6 = new Math6();
			switch (operation)
			{
				case "-gcf":
					Console.WriteLine($"GCF of {number1} and {number2}: {Math6.GCF(number1, number2)}");
					break;
				case "-lcm":
					Console.WriteLine($"LCM of {number1} and {number2}: {Math6.LCM(number1, number2)}");
					break;
				default:
					Console.WriteLine("Invalid operation. Use -lcm or -gcf.");
					break;
			}
		}
	}
}