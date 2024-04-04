using System.Globalization;

namespace ConsoleDeTeste;

delegate void ValidateContent(object e);

public class Experiments
{

    public bool Validate(object? value, object? parameters, CultureInfo culture)
    {
        if (parameters!.GetType().Equals(typeof(ValidateContent)))
        {
            ((ValidateContent)parameters).Invoke(value);
        }
        return true;
    }
}
