namespace FormatScaleValue
{
	internal class Program
	{
		static void Main(string[] args)
		{

			double input;
			int subdivisions;

            Console.WriteLine("DECIMAL INCH VALUE TO IMPERIAL REPRESENTATION:");
            Console.WriteLine($"Subdivisions: 64 (default)\n");
            for (int i = 1; i <= 150; i++)
            {
                input = 0.1 * i;
                Console.WriteLine($"{i.ToString().PadLeft(3)}. {nameof(ValueFormatting.FormatInchesInImperial)}(({Math.Round(input, 4)})");
                Console.WriteLine($"     {ValueFormatting.FormatInchesInImperial(input)}\n");
            }


            subdivisions = 128;
            Console.WriteLine("DECIMAL INCH VALUE TO IMPERIAL REPRESENTATION:");
            Console.WriteLine($"Subdivisions: {subdivisions}\n");
            for (int i = 1; i <= 150; i++)
            {
                input = 0.1 * i;
                Console.WriteLine($"{i.ToString().PadLeft(3)}. {nameof(ValueFormatting.FormatInchesInImperial)}(({Math.Round(input, 4)})");
                Console.WriteLine($"     {ValueFormatting.FormatInchesInImperial(input, subdivisions)}\n");
            }


            Console.WriteLine("DECIMAL DECIMAL SCALE TO IMPERIAL REPRESENTATION:");
            Console.WriteLine($"Subdivisions: 64 (default)\n");
            for (int i = 1; i <= 150; i++)
            {
                input = 0.1 * i;
                Console.WriteLine($"{i.ToString().PadLeft(3)}. {nameof(ValueFormatting.FormatScaleInImperial)}(({Math.Round(input, 4)})");
                Console.WriteLine($"     {ValueFormatting.FormatScaleInImperial(input)}\n");
            }


            subdivisions = 128;
            Console.WriteLine("DECIMAL DECIMAL SCALE TO IMPERIAL REPRESENTATION:");
            Console.WriteLine($"Subdivisions: {subdivisions}\n");
            for (int i = 1; i <= 150; i++)
            {
                input = 0.1 * i;
                Console.WriteLine($"{i.ToString().PadLeft(3)}. {nameof(ValueFormatting.FormatScaleInImperial)}(({Math.Round(input, 4)})");
                Console.WriteLine($"     {ValueFormatting.FormatScaleInImperial(input, subdivisions)}\n");
            }



        }
    }
}



