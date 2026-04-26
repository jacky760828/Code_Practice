// See https://aka.ms/new-console-template for more information
int number = new Random().Next(1, 10);

Console.WriteLine("歡迎來到猜數字遊戲！");
Console.Write("請輸入你的名字：");
var name = Console.ReadLine();

Console.WriteLine("你好！{0}", name);
Console.WriteLine("我們開始吧！");
Console.WriteLine();

while (true)
{
    Console.Write("請猜一個數字（1~9）：");
    var input = Console.ReadLine();

    int guess;
    if (int.TryParse(input, out guess))
    {
        if (guess == number)
        {
            Console.WriteLine("恭喜你！猜對了！！！");
            Console.WriteLine();
            break;
        }
        Console.WriteLine("哇！你猜錯了，再試一次！");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("你輸入的不是數字！");
        Console.WriteLine("請輸入 1~9 的數字！");
        Console.WriteLine();
    }
}