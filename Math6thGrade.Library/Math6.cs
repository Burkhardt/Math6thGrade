using System;

namespace Math6thGrade.Library
{
	public class Math6
	{
		// Method to calculate the Greatest Common Factor
		public static int GCF(int a, int b)
		{
			while (b != 0)
			{
				int temp = b;
				b = a % b;
				a = temp;
			}
			return a;
		}

		// Method to calculate the Least Common Multiple
		public static int LCM(int a, int b)
		{
			return (a / GCF(a, b)) * b;
		}
	}
}