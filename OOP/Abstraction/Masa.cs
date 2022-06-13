using System;
public class Masa : Mobilya
{
    public string malzeme;

    public override void OzellikYaz()
    {
        Console.WriteLine("Masanın Özellikleri");
        Console.WriteLine("Renk: {0}", renk);
        Console.WriteLine("Malzeme: {0}", malzeme);
    }
}