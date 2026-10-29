using System;

namespace Gladiator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Все переменные
            string name1, name2;
            double health1, health2;
            double armor1, armor2;
            double protection1, protection2;
            double attack1, attack2;
            double damage1, damage2;
            int round = 0;
            int blows = 0;

            // Первый гладиатор
            Console.Write("Введите имя первого гладиатора -> ");
            name1 = Console.ReadLine();

        rep1:
            Console.Write("Введите здоровье первого гладиатора -> ");
            health1 = Convert.ToDouble(Console.ReadLine());

            if (health1 <= 0)
            {
                Console.WriteLine("Ошибка! Здоровье должно быть больше 0.");
                goto rep1;
            }

        rep2:
            Console.Write("Введите прочность брони первого гладиатора -> ");
            armor1 = Convert.ToDouble(Console.ReadLine());

            if (armor1 <= 0)
            {
                Console.WriteLine("Ошибка! Прочность брони должна быть больше 0.");
                goto rep2;
            }

        rep3:
            Console.Write("Введите защиту первого гладиатора в процентах -> ");
            protection1 = Convert.ToDouble(Console.ReadLine());

            if (protection1 < 0 || protection1 > 100)
            {
                Console.WriteLine("Ошибка! Защита должна быть от 0 до 100 %.");
                goto rep3;
            }

            // Второй гладиатор
            Console.WriteLine();
            Console.Write("Введите имя второго гладиатора -> ");
            name2 = Console.ReadLine();

        rep4:
            Console.Write("Введите здоровье второго гладиатора -> ");
            health2 = Convert.ToDouble(Console.ReadLine());

            if (health2 <= 0)
            {
                Console.WriteLine("Ошибка! Здоровье должно быть больше 0.");
                goto rep4;
            }

        rep5:
            Console.Write("Введите прочность брони второго гладиатора -> ");
            armor2 = Convert.ToDouble(Console.ReadLine());

            if (armor2 <= 0)
            {
                Console.WriteLine("Ошибка! Прочность брони должна быть больше 0.");
                goto rep5;
            }

        rep6:
            Console.Write("Введите защиту второго гладиатора в процентах -> ");
            protection2 = Convert.ToDouble(Console.ReadLine());

            if (protection2 < 0 || protection2 > 100)
            {
                Console.WriteLine("Ошибка! Защита должна быть от 0 до 100 %.");
                goto rep6;
            }

            // Генератор случайных чисел
            Random rnd = new Random();

            // Цикл боя
            while (health1 > 0 && health2 > 0)
            {
                round = round + 1;
                Console.WriteLine();
                Console.WriteLine("================== Раунд " + round + " ==================");

                // Случайный урон 10 до 100
                attack1 = rnd.Next(10, 101);
                attack2 = rnd.Next(10, 101);
                blows = blows + 2;

                Console.WriteLine("Удар гладиатора " + name1 + ": " + attack1);
                Console.WriteLine("Удар гладиатора " + name2 + ": " + attack2);

                // Урон по второму гладиатору
                if (armor2 > 0)
                {
                    if (attack1 > armor2)
                    {
                        damage1 = armor2 - armor2 * protection2 / 100;
                        damage1 = damage1 + (attack1 - armor2);
                    }
                    else
                    {
                        damage1 = attack1 - attack1 * protection2 / 100;
                    }
                }
                else
                {
                    damage1 = attack1;
                }

                // Урон по первому гладиатору
                if (armor1 > 0)
                {
                    if (attack2 > armor1)
                    {
                        damage2 = armor1 - armor1 * protection1 / 100;
                        damage2 = damage2 + (attack2 - armor1);
                    }
                    else
                    {
                        damage2 = attack2 - attack2 * protection1 / 100;
                    }
                }
                else
                {
                    damage2 = attack2;
                }

                // Уменьшаем здоровье
                health1 = health1 - damage2;
                health2 = health2 - damage1;

                // Уменьшаем прочность брони первого
                if (armor1 > 0)
                {
                    armor1 = armor1 - attack2;

                    if (armor1 <= 0)
                    {
                        armor1 = 0;
                        Console.WriteLine("Броня гладиатора " + name1 + " сломана!");
                    }
                    else
                    {
                        Console.WriteLine("Броня гладиатора " + name1 + " выдержала!");
                    }
                }

                // Уменьшаем прочность брони второго
                if (armor2 > 0)
                {
                    armor2 = armor2 - attack1;

                    if (armor2 <= 0)
                    {
                        armor2 = 0;
                        Console.WriteLine("Броня гладиатора " + name2 + " сломана!");
                    }
                    else
                    {
                        Console.WriteLine("Броня гладиатора " + name2 + " выдержала!");
                    }
                }

                // Результаты раунда
                Console.WriteLine();
                Console.WriteLine("Урон по " + name1 + ": " + damage2);
                Console.WriteLine("Урон по " + name2 + ": " + damage1);

                if (health1 < 0)
                {
                    health1 = 0;
                }
                if (health2 < 0)
                {
                    health2 = 0;
                }

                Console.WriteLine("Здоровье " + name1 + ": " + health1 + ", броня: " + armor1);
                Console.WriteLine("Здоровье " + name2 + ": " + health2 + ", броня: " + armor2);
            }

            // Определяем победителя
            Console.WriteLine();
            Console.WriteLine("=============== БОЙ ЗАВЕРШЁН ===============");

            if (health1 <= 0 && health2 <= 0)
            {
                Console.WriteLine("Ничья! Оба гладиатора повержены.");
            }
            else if (health1 <= 0)
            {
                Console.WriteLine("Победил " + name2 + "!");
            }
            else
            {
                Console.WriteLine("Победил " + name1 + "!");
            }

            Console.WriteLine("Всего ударов за бой: " + blows);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}