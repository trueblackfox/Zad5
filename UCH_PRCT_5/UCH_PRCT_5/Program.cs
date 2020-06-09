using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCH_PRCT_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                CheckInt("Введите размерность матрицы: ", out n);
                if (n < 1) Console.WriteLine("Ошибка ввода! Размер матрицы должен быть целым числом > 1");
            } while (n < 1);
            Random rand = new Random();
            int[,] mas = new int[n, n];
            int max = -101;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = rand.Next(-100, 100);
                    Console.Write("{0,4}", mas[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = n / 2; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((j <= i) && (n - 1 <= i + j))
                    {
                        if (mas[i, j] > max)
                            max = mas[i, j];
                    }
                }
            }

            Console.WriteLine("Максимальный элемент в нижней части матрицы={0}", max);
            Console.ReadLine();
        }
        static void CheckInt(string message, out int res)
        {
            bool check; // отвечает за проверку типа переменной
            Console.Write(message);
            do
            {
                string prior = Console.ReadLine();
                check = Int32.TryParse(prior, out res);
                if (check == false) Console.WriteLine("Неправильный ввод, попробуйте ещё раз.");
            } while (check == false);
        } // Проверка входных данных на соответствие типу Int
    }
}
