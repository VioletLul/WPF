using System.Windows.Controls;

namespace ErrorTemplates
{
    public class NoEmptyStringValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            string valueFromSource = value.ToString();

            if (valueFromSource == "")
            {
                return new ValidationResult(false, "Das Feld darf nicht leer sein!");
            }

            return new ValidationResult(true, null);
        }
    }
}
