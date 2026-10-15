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
            Console.Write("Введите здоровье первого гладиатора -> ");
            health1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите прочность брони первого гладиатора -> ");
            armor1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите защиту первого гладиатора в процентах -> ");
            protection1 = Convert.ToDouble(Console.ReadLine());

            // 2-ой гладиатор
            Console.Write("Введите здоровье второго гладиатора -> ");
            health2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите прочность брони второго гладиатора -> ");
            armor2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите защиту второго гладиатора в процентах -> ");
            protection2 = Convert.ToDouble(Console.ReadLine());


            // случайная сила удара
            Random rnd = new Random();

            attack1 = rnd.Next(10, 51);
            attack2 = rnd.Next(10, 51);

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
