﻿namespace DemoDiamondProblem.Entities;

public class Scanner : Device
{
    public override void ProcessDoc(string document)
    {
        Console.WriteLine($"Scanner processing: {document}");
    }

    public string Scan()
    {
        return "Scanner scan result";
    }
}