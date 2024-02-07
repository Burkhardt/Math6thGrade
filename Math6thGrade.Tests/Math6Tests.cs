using Math6thGrade.Library;
using Xunit;

namespace Math6thGrade.Tests
{
	public class Math6Tests
	{
		private readonly Math6 _math6 = new();

		[Theory]
		[InlineData(18, 24, 6)]
		[InlineData(5, 10, 5)]
		[InlineData(17, 13, 1)]
		[InlineData(0, 5, 5)]
		[InlineData(3, 0, 3)]
		[InlineData(12, 16, 4)]
		public void GCF_ReturnsCorrectResult(int a, int b, int expectedResult)
		{
			var result = Math6.GCF(a, b);
			Assert.Equal(expectedResult, result);
		}

		[Theory]
		[InlineData(18, 24, 72)]
		[InlineData(5, 10, 10)]
		[InlineData(17, 13, 221)]
		[InlineData(0, 5, 0)]
		[InlineData(3, 0, 0)]
		[InlineData(51, 21, 357)]
		[InlineData(500,432,54000)]
		public void LCM_ReturnsCorrectResult(int a, int b, int expectedResult)
		{
			var result = Math6.LCM(a, b);
			Assert.Equal(expectedResult, result);
		}
	}
}