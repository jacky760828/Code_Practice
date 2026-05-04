using ConsoleApp1;

namespace ZeroToMaster;

// 靜態類別不能有實例成員 (物件)
// 靜態類別只能有靜態成員
internal static class AutoFeeder
{
    private static Random Rnd = new Random();
    private static string[] _foods = new string[] { "meat", "fish", "vegetable" };
    public static event EventHandler<Foodtype>? FoodMade;

    public static Foodtype MakeFood()
    {
        //int index = Rnd.Next(_foods.Length);  // 0, 1, 2

        var food=(Foodtype)Rnd.Next(Enum.GetValues<Foodtype>().Length);
       
        Console.WriteLine($"==>New Food: {food}");

        FoodMade?.Invoke(null, food);
        //return _foods[index];
        return food;
    }
}
