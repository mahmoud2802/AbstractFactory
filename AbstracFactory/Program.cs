using System;
using AbstractFactory.AbstractFactory;

namespace AbstractFactory
{
    internal class Program
    {
        public static void Main(string[] args)
        {       
             IFurnitureFactory _factory;
             
             
             _factory=new ModernFurnitureFactory();
             CreateFurniture(_factory);
         
            
             
             _factory=new SimpleFurnitureFactory();
             CreateFurniture(_factory);
            
            
            
            _factory=new VictorianFurnitureFactory();
            CreateFurniture(_factory);


            PrintInstagram();
            Console.ReadKey();
        }

        private static void CreateFurniture(IFurnitureFactory factory)
        {
            IChair chair;
            ITable table;
            ISofa sofa;
            chair = factory.CreateChair();
            table = factory.CreateTable();
            sofa = factory.CreateSofa();
            Console.WriteLine($"* {factory.GetName()} *");
            PrintInfo(chair, table, sofa);
            
        }

        private static void PrintInfo(IChair chair, ITable table, ISofa sofa)
        {
            Console.WriteLine("---");
            Console.WriteLine($"{chair.GetName()} => Price:{chair.Price()}  & hasLeg: {chair.HasLeg() }");
            Console.WriteLine($"{table.GetName()} => Price:{table.Price()}");
            Console.WriteLine($"{sofa.GetName()} => Price:{sofa.Price()}");
            Console.WriteLine("---");

        }
        
        static void PrintInstagram()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Please follow me on Instagram @mahmoud2802");
            Console.WriteLine("************************");
        }
    }
}