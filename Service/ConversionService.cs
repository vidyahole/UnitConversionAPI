namespace Unit_Conversion_API.Service
{
    public class ConversionService
    {
        public double Convert(double value, string fromUnit, string toUnit, string category)
        {
            switch (category.ToLower())
            {
                case "length":
                    return ConvertLength(value, fromUnit, toUnit);
                case "weight":
                    return ConvertWeight(value, fromUnit, toUnit);
                case "temperature":
                    return ConvertTemperature(value, fromUnit, toUnit);
                default:
                    throw new ArgumentException("Unsupported category");
            }
        }

        private double ConvertLength(double value, string from, string to)
        {
            if (from == "meter" && to == "feet") return value * 3.28084;
            if (from == "feet" && to == "meter") return value / 3.28084;
            throw new ArgumentException("Unsupported length conversion");
        }

        private double ConvertWeight(double value, string from, string to)
        {
            if (from == "kg" && to == "pound") return value * 2.20462;
            if (from == "pound" && to == "kg") return value / 2.20462;
            throw new ArgumentException("Unsupported weight conversion");
        }

        private double ConvertTemperature(double value, string from, string to)
        {
            if (from == "celsius" && to == "fahrenheit") return (value * 9 / 5) + 32;
            if (from == "fahrenheit" && to == "celsius") return (value - 32) * 5 / 9;
            throw new ArgumentException("Unsupported temperature conversion");
        }
    }
}
