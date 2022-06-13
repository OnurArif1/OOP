using System;
public class Admin:Uye
{
    public new  void CikisYap()
    {
        base.CikisYap();

        Console.WriteLine(this.Ad + ": Çerezleri temizledim.");
    }
}