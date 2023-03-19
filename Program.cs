// See https://aka.ms/new-console-template for more information

Console.WriteLine(GetPow(4, 2));
Console.ReadLine();

static int GetPow(int baseNum, int powNum)
{
    int result = 1;

    for(int i = 0; i < powNum; i++)
    {
        result = result * baseNum;
    }
    return result;


}
