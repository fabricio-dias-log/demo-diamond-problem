using DemoDiamondProblem.Entities;

namespace DemoDiamondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");
        }
    }
}