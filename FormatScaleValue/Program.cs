namespace FormatScaleValue
{
	internal class Program
	{
		static void Main(string[] args)
		{

			string separator = " - ";
			int subdivisions = 64;
			bool keepZeroFeet = false;
			//Console.WriteLine(DrawingDataFormatting.FormatInchesInFractional(14.74, separator, subdivisions, keepZeroFeet));
			//Console.WriteLine(DrawingDataFormatting.FormatInchesInFractional(12.5, separator, subdivisions, keepZeroFeet));
			//Console.WriteLine(DrawingDataFormatting.FormatInchesInFractional(12, separator, subdivisions, keepZeroFeet));
			//Console.WriteLine(DrawingDataFormatting.FormatInchesInFractional(1.5, separator, subdivisions, keepZeroFeet));
			//Console.WriteLine(DrawingDataFormatting.FormatInchesInFractional(0.5, separator, subdivisions, keepZeroFeet));
			//Console.WriteLine(DrawingDataFormatting.FormatInchesInFractional(1, separator, subdivisions, keepZeroFeet));
			//Console.WriteLine(DrawingDataFormatting.FormatInchesInFractional(0, separator, subdivisions, keepZeroFeet));
			//Console.WriteLine(DrawingDataFormatting.FormatInchesInFractional(-14.74));
			//Console.WriteLine(DrawingDataFormatting.FormatInchesInFractional(-12.5));
			//Console.WriteLine(DrawingDataFormatting.FormatInchesInFractional(-12));
			//Console.WriteLine(DrawingDataFormatting.FormatInchesInFractional(-1.5));
			//Console.WriteLine(DrawingDataFormatting.FormatInchesInFractional(-0.5));
			//Console.WriteLine(DrawingDataFormatting.FormatInchesInFractional(-1));
			//Console.WriteLine(DrawingDataFormatting.FormatInchesInFractional(-0.01));


			double scale = 0.3;
			string formattedScale = "";
			//formattedScale = DrawingDataFormatting.FormatScaleInImperial(scale);
			//Console.WriteLine($"Formatted {scale} as {formattedScale}.");

			scale = 0.705;
			formattedScale = DrawingDataFormatting.FormatScaleInMetric(scale, ":", 3);
			Console.WriteLine($"Formatted {scale} as {formattedScale}.");

		}
	}
}



