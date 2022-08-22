// See https://aka.ms/new-console-template for more information
namespace exponetialLoop;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(GetPow(3, 5));
    }
    static int GetPow(int baseNum, int powNum)
    {
        int result = 1;
        for(int i = 0; i < powNum; i++)
        {
            result = result * baseNum;
        }
        return result;
    }
}
