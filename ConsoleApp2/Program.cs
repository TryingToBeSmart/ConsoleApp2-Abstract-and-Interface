using ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        // Uncomment the following lines to test the Animal class
        //Animal beast = new Animal();
        //beast.Talk();
        //beast.Greet();
        //beast.Sing();
        //Console.WriteLine();

        // Create a Dog object and test its methods
        Dog bowser = new Dog();
        bowser.Talk();
        bowser.Greet();
        bowser.Sing();
        bowser.Fetch("stick");
        bowser.FeedMe();
        bowser.PetMe();
        Console.WriteLine();

        // Create a Robin object and test its methods
        Robin red = new Robin();
        red.Talk();
        red.Greet();
        red.Sing();
        //red.Fetch("worm");
        //red.FeedMe();
        //red.PetMe();

        // Create an Eagle object and test its methods
        Eagle eagle = new Eagle();
        eagle.Feathers();
        eagle.Sing();
        eagle.Greet();
        Console.WriteLine();

        // Create a Horse object and test its methods
        Horse horse = new Horse();
        horse.Talk();
        horse.Greet();
        horse.FeedMe();
        horse.Go();
        horse.PetMe();
        horse.Sing();
        Console.WriteLine();

        // Create a Falcon object and test its methods
        Falcon falcon = new Falcon();
        falcon.Talk();
        falcon.Greet();
        falcon.Sing();
        falcon.Feathers();

        Console.ReadLine();
    }
}
