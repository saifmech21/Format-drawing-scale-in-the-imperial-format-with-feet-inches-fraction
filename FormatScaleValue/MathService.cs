
namespace FormatScaleValue
{
	internal class MathService
	{
		/// <summary>
		/// Finds the Greatest Common Divisor (GCD) of two integers using the Euclidean Algorithm.
		/// </summary>
		/// <param name="a">An integer value.</param>
		/// <param name="b">Another integer value.</param>
		/// <returns>Returns the GCD</returns>
		public static int FindGcd(int a, int b)
		{
			if (b == 0) return a;
			return FindGcd(b, a % b);
		}
	}
}
