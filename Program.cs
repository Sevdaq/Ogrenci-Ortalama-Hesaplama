namespace ConsoleApp44
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Adınızı ve soyadınızı girin:");
            string adSoyad = Console.ReadLine();

            Console.WriteLine("1. NOTUNUZU GİRİN:");
            string notStr = Console.ReadLine();
            int not1 = int.Parse(notStr);

            Console.WriteLine("2. NOTUNUZU GİRİN:");
            string notStr1 = Console.ReadLine();
            int not2 = int.Parse(notStr1);

            Console.WriteLine("3. NOTUNUZU GİRİN:");
            string notStr2 = Console.ReadLine();
            int not3 = int.Parse(notStr2);

            int Ort = (not1 + not2 + not3) / 3;

            Console.WriteLine("{0}:  ,Birinci Notunuz: {1},İkinci Notunuz: {2},Üçüncü Notunuz: {3},ortalamanız: {4}", adSoyad, not1, not2, not3, Ort);

            if (Ort <= 45)
            {
                Console.WriteLine("geçti");
            }
            else
            {
                Console.WriteLine("kaldi");
            }



        }
    }
}
