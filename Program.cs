using System;
namespace ConsoleApp39
{
    class Program
    {
        static void Main()
        {
            int n, m;
            try
            {
                Console.WriteLine("введите кол-во строк ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 1)
                {
                    throw new Exception("не корректно введены данные массив должен быть двумерным");
                }
                Console.WriteLine("введите кол-во столбцов ");
                m = Convert.ToInt32(Console.ReadLine());
                if (m <= 1)
                {
                    throw new Exception("не корректно введены данные массив должен быть двумерным");       
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                p();
                return;
            }
            int[,] array = new int[n, m];//а если 2*2
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rnd.Next(1, 4);
                    Console.Write(array[i, j] + "    ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            string s;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((i == 0 || i == (n - 1)) || (i != 0 && i != (n - 1) && (j == 0 || j == (m - 1))))
                        s = Convert.ToString(array[i, j]);
                    else
                        s = " ";



                    Console.Write(s + "    ");


                }
                Console.WriteLine();
            }

            void p()
            {
                Console.WriteLine("повторить ввод если да то 1 нет то 0");
                string y = Convert.ToString(Console.ReadLine());
                if (y == "1")
                    Main();
                else
                    return;
            }
            p();
            return;
        }
    }
}

