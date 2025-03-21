namespace DemoDiamondProblem.Entities;

public class ComboDevice : Device, IPrinter, IScanner
{
    public override void ProcessDoc(string document)
    {
        Console.WriteLine($"Combo device processing {document}");
    }

    public string Scan()
    {
        return "Combo device scan result";
    }

    public void Print(string document)
    {
        Console.WriteLine($"Combo device print {document}");
    }
}