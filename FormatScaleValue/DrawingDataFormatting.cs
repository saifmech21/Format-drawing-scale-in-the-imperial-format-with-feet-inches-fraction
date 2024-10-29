
namespace FormatScaleValue
{
	/// <summary>
	/// A service for formatting a dimension, scale, etc in a specific style
	/// </summary>
	internal class ValueFormatting
	{
        /// <summary>
        /// Formats a scale factor in the Imperial style.
        /// </summary>
        /// <param name="scale">Scale factor to process. Example: 0.3, 1.5, etc.</param>
        /// <param name="subdivisions">[optional] Subdivisions of an inch to use in formatting. Valid values are 2, 4, 8, 16, 32 or 64. A larger value will produce a more accurate representation of the specified scale value. If not specified, 64 will be assumed.</param>
        /// <param name="sideSeparator">[optional] Separator to use in between the left side and right side of the formatted representation. Example: ":", " : ", "=", " = ", " to ", etc. If not specified, " = " will be assumed.</param>
        /// <param name="inchFootSeperator">[optional] Separator to use in between the foot and inch value on each side of the formatted representation. Example: "", "-", " - ", etc. If not specified, " - " will be assumed.</param>
        /// <param name="rightSideInInches">[optional] Value to use on the right side of the formatted representation, specified in inches. Typically, 12 i.e. 1' - 0". If not specified, 12 will be used.</param>
        /// <param name="keepZeroFeet">[optional] Whether of not to keep the feet value when its a zero. If not specified, "false" is assumed.</param>
        /// <returns>The formatted string. Example: </returns>
        public static string FormatScaleInImperial(
			double scale,
            int subdivisions = 64,
            string sideSeparator = " = ",
			string inchFootSeperator = "-",
			double rightSideInInches = 12,
			bool keepZeroFeet = false)
		{
			string strCallDetails = $"{nameof(FormatScaleInImperial)} ({nameof(scale)} = {scale}, {nameof(sideSeparator)} = \"{sideSeparator}\", {nameof(inchFootSeperator)} = \"{inchFootSeperator}\", {nameof(rightSideInInches)} = {rightSideInInches}, {nameof(subdivisions)} = {subdivisions}, {nameof(keepZeroFeet)} = {keepZeroFeet})";
			string log = strCallDetails + "\n";
			//Console.WriteLine(log);

			// make sure it's a positive value
			if (scale <= 0) throw new ArgumentException($"Argument {nameof(scale)} = {scale} was invalid. A non-zero positive quantity was expected.");

			// Validate subdivisions
			if (subdivisions < 2 || Math.Log(subdivisions, 2) % 1 != 0 )
				throw new ArgumentException($"Argument {nameof(subdivisions)} = {subdivisions} was invalid. 2, 4, 8, 16, 32, 64, etc was expected.");


			double leftSideInInches = scale * rightSideInInches;

			return
                FormatInchesInImperial(leftSideInInches, subdivisions, inchFootSeperator, keepZeroFeet) +
				sideSeparator +
                FormatInchesInImperial(rightSideInInches, subdivisions, inchFootSeperator, keepZeroFeet);
		}

		
        /// <summary>
        /// Formats an inch value in the fractional style.
        /// </summary>
        /// <param name="inches">The value in inches. For a negative value, a minus (-) sign will preceed the formatted string.</param>
        /// <param name="subdivisions">[optional] Subdivisions of an inch to use in formatting. Valid values are 2, 4, 8, 16, 32 or 64. A larger value will produce a more accurate representation of the specified scale value. If not specified, 64 will be assumed.</param>
        /// <param name="separator">[optional] Separator to use between the feet value and the inch value. If not specified, " - " will be assumed.</param>
        /// <param name="keepZeroFeet">[optional] Whether of not to keep the feet value when its a zero. If not specified, "false" is assumed.</param>
        /// <returns>The formatted string. If 'inches' is </returns>
        public static string FormatInchesInImperial(double inches, int subdivisions = 64, string separator = "-", bool keepZeroFeet = false)
		{
			string strCallDetails = $"{nameof(FormatInchesInImperial)} ({nameof(inches)} = {inches}, {nameof(separator)} = \"{separator}\", {nameof(subdivisions)} = {subdivisions}, {nameof(keepZeroFeet)} = {keepZeroFeet})";
			string log = strCallDetails + "\n";
            //Console.WriteLine(log);

            // Validate subdivisions
            if (subdivisions < 2 || Math.Log(subdivisions, 2) % 1 != 0)
                throw new ArgumentException($"Argument {nameof(subdivisions)} = {subdivisions} was invalid. 2, 4, 8, 16, 32, 64, etc was expected.");

            bool wasNegative = false;
			if (inches < 0)
			{
				wasNegative = true;
				inches *= -1;
			}

			int wholeInches = (int)inches;
			double fractionPart = inches - wholeInches;

			// participants in the output string
			int feetPart = wholeInches / 12;
			int inchesPart = wholeInches % 12;
			int numeratorPart = (int)Math.Round(fractionPart * subdivisions);
			int denominatorPart = subdivisions;

			log += $"wholeInches = {wholeInches}\n";
			log += $"fractionPart = {fractionPart}\n";
			log += $"feetPart = {feetPart}\n";
			log += $"inchesPart = {inchesPart}\n";
			log += $"numeratorPart = {numeratorPart}\n";
			log += $"GCD = {MathService.FindGcd(4, 32)}";

			// reduce the fraction by the gcd
			int gcd = MathService.FindGcd(numeratorPart, denominatorPart);
			numeratorPart /= gcd;
			denominatorPart /= gcd;

			log += $"inchesPart = {inchesPart}\n";
			log += $"numeratorPart = {numeratorPart}\n";
			log += $"denominatorPart = {denominatorPart}\n";

			string output =
				(wasNegative ? "-" : "") +
				(feetPart == 0 && !keepZeroFeet ? "" : feetPart + "\'" + separator) +
				(inchesPart == 0 ? "" : inchesPart + (numeratorPart == 0 ? "" : " ")) +
				(numeratorPart == 0 ? (inchesPart == 0 ? "0" : "") : numeratorPart + "/" + denominatorPart) + "\"";

			log += $"Output: {output}\n";

			//Console.WriteLine(log);

			return output;
		}

	}
}
