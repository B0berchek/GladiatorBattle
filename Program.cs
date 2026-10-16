using System;

namespace Gladiator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // все переменные
            double health1, health2;
            double armor1, armor2;
            double protection1, protection2;
            double attack1, attack2;
            double damage1, damage2;

            // 1-ый гладиатор
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
                    Console.WriteLine("Ошибка! Защита должна быть в диапазоне от 0 до 100 %");
                    goto rep3;
                }



            // 2-ой гладиатор
            rep4:
                Console.Write("Введите здоровье первого гладиатора -> ");
                health2 = Convert.ToDouble(Console.ReadLine());
                if (health2 <= 0)
                {
                    Console.WriteLine("Ошибка! Здоровье должно быть больше 0.");
                    goto rep4;
                }

            rep5:
                Console.Write("Введите прочность брони первого гладиатора -> ");
                armor2 = Convert.ToDouble(Console.ReadLine());
                if (armor2 <= 0)
                {
                    Console.WriteLine("Ошибка! Прочность брони должна быть больше 0.");
                    goto rep5;
                }


            rep6:
                Console.Write("Введите защиту первого гладиатора в процентах -> ");
                protection2 = Convert.ToDouble(Console.ReadLine());
                if (protection2 < 0 || protection2 > 100)
                {
                    Console.WriteLine("Ошибка! Защита должна быть в диапазоне от 0 до 100 %");
                    goto rep6;
                }


            // случайная сила удара
            Random rnd = new Random();
            attack1 = rnd.Next(10, 101);
            attack2 = rnd.Next(10, 101);

            Console.WriteLine("Удар первого гладиатора: " + attack1);
            Console.WriteLine("Удар второго гладиатора: " + attack2);

            // расчет урона по здоровью
            damage1 = attack1 - attack1 * protection2 / 100;
            damage2 = attack2 - attack2 * protection1 / 100;


            // уменьшаем здоровье
            health1 = health1 - damage2;
            health2 = health2 - damage1;

            // ломаем броню
            armor1 = armor1 - attack2;
            armor2 = armor2 - attack1;

            // результаты боля
            Console.WriteLine("Здоровье 1-ого гладиатора после боя: " + health1);
            Console.WriteLine("Здоровье 2-ого гладиатора после боя: " + health2);

            Console.WriteLine("Прочность брони 1-ого после боя: " + armor1);
            Console.WriteLine("Прочность брони 2-ого после боя: " + armor2);

            Console.ReadKey();
        }
    }
}
