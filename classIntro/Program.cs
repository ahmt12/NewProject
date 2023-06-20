namespace classIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 80;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Ahmet Aslan";
            kurs2.IzlenmeOrani = 90;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " : " + kurs.IzlenmeOrani);
            }
        }

    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen  { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}