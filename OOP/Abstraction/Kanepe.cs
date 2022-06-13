using System;

public class Kanepe : Mobilya
{
    public string kumas;
    public override void OzellikYaz()
    {
        Console.WriteLine("Kanepenin Özellikleri");
        Console.WriteLine("Renk: {0}",renk);
        Console.WriteLine("Kumaş: {0}", kumas);
    }
    
}