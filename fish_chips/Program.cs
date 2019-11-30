using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fish_chips
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplaySettings t = new DisplaySettings();
            Settings testSettings = t.GetMainSettings();

            Display testDisplay = new Display(testSettings.PondHeight, testSettings.PondWidth);

            List<GamePoint> gamePoints = new List<GamePoint>();
            gamePoints.Add(new GamePoint()
            {
                XPosition = 5,
                YPosition = 5,
                ForegroundColor = ConsoleColor.Black,
                BackgroundColor = ConsoleColor.Green,
                Text = "5"
            });
            gamePoints.Add(new GamePoint()
            {
                XPosition = 7,
                YPosition = 10,
                BackgroundColor = ConsoleColor.Black,
                ForegroundColor = ConsoleColor.Cyan,
                Text = "7"
            });
            gamePoints.Add(new GamePoint()
            {
                XPosition = 12,
                YPosition = 14,
                BackgroundColor = ConsoleColor.DarkYellow,
                ForegroundColor = ConsoleColor.Black,
                Text = " "
            });


            testDisplay.PrintPond();
            Console.ReadKey();
            
        }
    }
}
