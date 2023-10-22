namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zebra zebra = new Zebra("Holmes", 90);
            zebra.PrintInfo();
            Console.WriteLine();

            Cheetah cheetah = new Cheetah("Larry", 10, 100);
            cheetah.PrintInfo();
            cheetah.CanCheetahCatchZebra(zebra);
            Console.WriteLine();

            Tiger tiger = new Tiger("Mike", 10);
            tiger.PrintInfo();
            Console.WriteLine();

            Elephant elephant = new Elephant("George", 0.7);
            elephant.PrintInfo();
            Console.WriteLine();

            Lion lion = new Lion("Simba", 12, true);
            lion.PrintInfo();
            Console.WriteLine();

            zebra.MakeSound();
            cheetah.MakeSound();
            tiger.MakeSound();
            elephant.MakeSound();
            lion.MakeSound();

            Console.WriteLine();
            Console.Write("Press Any Key To Exit The Program: ");
            Console.ReadKey();
        }
    }
}