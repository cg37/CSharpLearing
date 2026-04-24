namespace  CSharpLearning;

internal class Program
{
    static void Main()
    {
        /*
         *一个打印99乘法表的代码片段
         */
        for (short i = 1; i < 10; ++i)
        {
            for (short j = 1; j <= i; ++j)
            {
                Console.Write($"{j, 3} * {i} = {i * j};");
            }
            Console.WriteLine();
        }
    }
}