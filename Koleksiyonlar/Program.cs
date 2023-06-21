namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "Ahmet","Aslan"};
            isimler.Add("Bülent");
            isimler.Add("Cenk");
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

        }
    }
}