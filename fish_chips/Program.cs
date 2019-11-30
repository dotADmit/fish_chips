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
                BackgroundColor = ConsoleColor.Black,
                ForegroundColor = ConsoleColor.Green,
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

            Console.Clear();

            testDisplay.PrintPond();
            testDisplay.Render(gamePoints);

            List<GamePoint> gamePoints2 = new List<GamePoint>();
            gamePoints2.Add(new GamePoint()
            {
                XPosition = 5,
                YPosition = 5,
                BackgroundColor = ConsoleColor.Black,
                ForegroundColor = ConsoleColor.Green,
                Text = "5"
            });
            gamePoints2.Add(new GamePoint()
            {
                XPosition = 7,
                YPosition = 10,
                BackgroundColor = ConsoleColor.Black,
                ForegroundColor = ConsoleColor.Cyan,
                Text = "7"
            });
            gamePoints2.Add(new GamePoint()
            {
                XPosition = 16,
                YPosition = 14,
                BackgroundColor = ConsoleColor.DarkYellow,
                ForegroundColor = ConsoleColor.Black,
                Text = " "
            });

            testDisplay.Render(gamePoints2);

            List<Fishman> fishmen = new List<Fishman>();
            fishmen.Add(new Fishman()
            {
                Name = "Иван",
                FishBoxes = new List<FishBox>()
                {
                    new FishBox() { Type = FishType.Navaga, Volume = 30 },
                    new FishBox() { Type = FishType.Keta, Volume = 20 },
                }
            });
            fishmen.Add(new Fishman()
            {
                Name = "Михаил",
                FishBoxes = new List<FishBox>()
                {
                    new FishBox() { Type = FishType.Halibut, Volume = 50 },
                    new FishBox() { Type = FishType.Keta, Volume = 10 },
                }
            });
            fishmen.Add(new Fishman()
            {
                Name = "Пётр",
                FishBoxes = new List<FishBox>()
                {
                    new FishBox() { Type = FishType.Navaga, Volume = 30 },
                    new FishBox() { Type = FishType.Halibut, Volume = 100 },
                }
            });

            List<FishmanResult> fishmanResults = new List<FishmanResult>();
            fishmanResults.Add(new FishmanResult()
            {
                Fishman = fishmen[0],
                Cost = 5000,
            });
            fishmanResults.Add(new FishmanResult()
            {
                Fishman = fishmen[1],
                Cost = 11000,
            });
            fishmanResults.Add(new FishmanResult()
            {
                Fishman = fishmen[2],
                Cost = 17000,
            });




            testDisplay.PrintStatistics(fishmen, 10, testSettings.StepCount);
            Console.Clear();
            testDisplay.PrintResult(fishmanResults, 100);

            Console.ReadKey();
            
        }
    }
}
