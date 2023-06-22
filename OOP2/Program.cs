namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Aslan";
            musteri1.tcNo = "324243";
            musteri1.MusteriNo = "1234";
            musteri1.Id = 1;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.SirketAdi = "XXX";
            musteri2.Id = 2;
            musteri2.vergiNo = "324324";
            musteri2.MusteriNo = "2131";


            
        }
    }
}