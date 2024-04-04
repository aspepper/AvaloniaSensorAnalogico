using ConsoleDeTeste;

internal class Program
{

    [STAThread]
    private static void Main(string[] args)
    {
        Console.WriteLine("Testing...");
        var experiments = new Experiments();
        experiments.Validate(null, (ValidateContent)ValidateContentFunc, System.Globalization.CultureInfo.CurrentCulture);
    }

    static void ValidateContentFunc(object? e)
    {
        if (e == null) { Console.WriteLine("Erro"); }
    }

}