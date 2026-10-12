using System.ComponentModel.DataAnnotations;

namespace Unit_Conversion_API.Models
{
    public class ConversionRequest
    {         
        public double Value { get; set; }
        public string FromUnit { get; set; }
        public string ToUnit { get; set; }
        public string Category { get; set; }
    }
}
