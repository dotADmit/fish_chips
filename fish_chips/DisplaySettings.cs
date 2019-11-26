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
            settings.Width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту водоёма (10 - 100): ");
            settings.Height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество рыбаков (2 - 5): ");
            settings.NumOfFishmen = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество рыбы (10 - 100): ");
            settings.Height = Convert.ToInt32(Console.ReadLine());

            return settings;


        }
    }
}
