using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
namespace kursachMain
{
  public class Validations : ValidationRule
    {
        private double min = 100000;
        private double max = Double.MaxValue;

        public double Min
        {
            get { return min; }
            set { min = value; }
        }

        public double Max
        {
            get { return max; }
            set { max = value; }
        }


        public override ValidationResult Validate(object value, System.Globalization.CultureInfo ci)
        {
            double ValuesRange = 0;

            try
            {
                ValuesRange = Double.Parse((string)value);
            }
            catch
            {
                return new ValidationResult(false, "Недопустимые символы.");
            }

            if ((ValuesRange < Min) || (ValuesRange > Max))
            {
                return new ValidationResult(false,
                  "Стоимость не входит в диапазон " + Min + " до " + Max + ".");
            }
            else
            {
                return new ValidationResult(true, null);
            }
        }



    }
}
