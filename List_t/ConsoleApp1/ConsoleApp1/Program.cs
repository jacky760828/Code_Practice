using ConsoleApp1;
using ZeroToMaster;

//var dog = new Dog("Max");
//var cat = new Cat("Luna");
//var sheep = new Sheep("Dolly");

//var animals = new Animal[] {dog, cat, sheep};

//foreach (var animal in animals)
//{
//    Console.WriteLine(animal.Sound());
//}
//List<int> intList= new List<int> { 1, 2, 3, 4, 5 };
//var doubledList = new List<double> { 1.1, 1.2, 1.3, 1.4, 1.5 };
//var stringList = new List<string> { "Hello", "World", "C#", "Generics" ,"jacky"};
//var doglist = new List<Dog> { new Dog("Max"), new Dog("Buddy"), new Dog("Charlie") };
//var animals = new List<Animal> { new Dog("Max"), new Cat("Luna"), new Sheep("Dolly") };

//foreach (var animal in animals)
//{
//    Console.WriteLine(animal.Sound());
//}
//var stack = new My_Steak<string>();
//stack.Push("1");
//stack.Push("2.4");
//stack.Push("3");

//Console.WriteLine($"Stack:{stack.Peek()}");
//Console.WriteLine($"Stack:{stack.Pop()}");
//Console.WriteLine($"Stack:{stack.Pop()}");

var dog = new Dog("Max");
//dog.SubscribeFood();
AutoFeeder.FoodMade+=dog.FoodNotified;

var cat = new Cat("Luna");
cat.SubscribeFood();
AutoFeeder.FoodMade -= cat.FoodNotified;
//cat.SubscribeFood();
for (int i = 0; i < 10; i++)
{
   var food =AutoFeeder.MakeFood();
}