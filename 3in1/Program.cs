namespace _3in1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vibor;
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1.Игра \"Угадай число\"");
            Console.WriteLine("2.Таблица умножения");
            Console.WriteLine("3.Вывод делителей числа");
            vibor = Convert.ToInt32(Console.ReadLine());
            switch (vibor)
            {
                case 1:
                    Random rand = new Random();
                    int random = rand.Next(101);
                    Console.WriteLine("Игра \"Угадай число\"");
                    Console.WriteLine("Угадывайте число");
                    int gadalka = -10;
                    while (gadalka != random)
                    {
                        gadalka = Convert.ToInt32(Console.ReadLine());
                        if (gadalka < random)
                        {
                            Console.WriteLine("Бери больше");
                        }
                        if (gadalka > random)
                        {
                            Console.WriteLine("Бери меньше");
                        }

                    }
                    Console.WriteLine("Молодец, угадал(а)!!!");
                    break;
                case 2:
                    Console.WriteLine("Таблица умножения");
                    int[,] massive = new int [10, 10];
                    for (int i = 1; i < 10; i++)
                    {
                        for (int k = 1; k < 10; k++)
                        {
                            massive[i, k] = i * k;
                        }
                    }
                    for (int i = 1; i < 10; i++)
                    {
                        for (int k = 1; k < 10; k++)
                        {
                            Console.Write(massive[i, k] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    Console.WriteLine("Вывод делителей числа");
                    double chislo = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= chislo; i++)
                    {
                        if (chislo % i == 0){
                            double result = chislo / i;
                            Console.WriteLine(result);
                        }
                    }
                    break;
            }
        }
    }
}