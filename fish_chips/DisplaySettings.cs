using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fish_chips
{
    class DisplaySettings
    {
        public Settings GetMainSettings()
        {
            Settings settings = new Settings();
            Console.Write($"Введите размер водоёма.\nВведите ширину водоёма (10 - 100): ");
            settings.PondWidth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту водоёма (10 - 100): ");
            settings.PondHeight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество рыбаков (2 - 5): ");
            settings.FishmanCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество наваги (10 - 100): ");
            settings.FishNavagaCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество кеты (10 - 100): ");
            settings.FishKetsCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество палтуса (10 - 100): ");
            settings.FishHalibutCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите максимальное количество шагов в симуляции: ");
            settings.StepCount = Convert.ToInt32(Console.ReadLine());

            return settings;
        }
    }
}
