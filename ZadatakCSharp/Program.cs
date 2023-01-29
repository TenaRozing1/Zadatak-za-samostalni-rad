
using ZadatakCSharp;

Automobil automobil = new Automobil();

try
{
Console.Write("Unesi naziv automobila: ");
automobil.Naziv = Console.ReadLine();

Console.Write("Unesi godinu proizvodnje: ");
automobil.NaPromjenuGodineProizvodnje += new Automobil.NaPromjenuGodineProizvodnjeDelegat(automobil_NaPromjenuGodineProizvodnje);
automobil.GodinaProizvodnje = int.Parse(Console.ReadLine());


Console.Write("Unesi osnovnu cijenu: ");
automobil.OsnovnaCijena = double.Parse(Console.ReadLine());
}
catch (Exception e)
{

Console.WriteLine("Greška: " + e.Message);
}

FileStream fs = new FileStream("automobil.txt", FileMode.OpenOrCreate);
StreamWriter sw = new StreamWriter(fs);
sw.WriteLine(automobil.Naziv);
sw.WriteLine(automobil.GodinaProizvodnje);
sw.WriteLine(automobil.OsnovnaCijena);
sw.WriteLine(automobil.UkupnaCijena());

sw.Close();
fs.Close();
FileStream fs2 = new FileStream("automobil.txt", FileMode.Open);
StreamReader sr = new StreamReader(fs2);

while (sr.Peek() > -1)
{
Console.WriteLine(sr.ReadLine());
}
sr.Close();

public static partial class Program
{
    static void automobil_NaPromjenuGodineProizvodnje(object sender, EventArgs e)
    {
        Console.WriteLine("Starost automobila: {0}", ((Automobil)sender).Starost());
    }
}