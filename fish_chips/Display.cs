using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fish_chips
{
    class Display
    {
        private int _pondHeight;
        private int _pondWidth;
        //private int _numOfFishmen;
        //private int _numOfFish;
        //private int _numOfIter;



        public Display(int PondHeight, int PondWidth)
        {
            _pondHeight = PondHeight;
            _pondWidth = PondWidth;
        }
        public void PrintPond()
        {
            Console.WriteLine($"+{new string('-', _pondWidth)}+");
            for (int i = 0; i < _pondHeight; i++)
            {
                Console.WriteLine($"|{new string(' ', _pondWidth)}|");
            }
            Console.WriteLine($"+{new string('-', _pondWidth)}+");
        }

        public void Render (List<GamePoint> gamePoints)
        {
            const int X_OFFSET = 1;
            const int Y_OFFSET = 1;

            foreach (GamePoint item in gamePoints)
            {
                Console.SetCursorPosition(item.XPosition + X_OFFSET, item.YPosition + Y_OFFSET);
                Console.ForegroundColor = item.ForegroundColor;
                Console.BackgroundColor = item.BackgroundColor;
                Console.WriteLine(item.Text);
                Console.ResetColor();
            }
        }
        public void PrintStatistics (List<Fishman> fishmen, int currentStep, int stepCount)
        {
            Console.SetCursorPosition(0, _pondHeight + 2);
            Console.WriteLine();
            string step = $"Шаг: {currentStep} из {stepCount}.";
            Console.WriteLine($"{step}\n{new string('*', step.Length)}");
            Console.WriteLine("Статистика рыбаков:");

            foreach (Fishman item in fishmen)
            {
                Console.WriteLine($"{item.Name}");
                foreach (FishBox box in item.FishBoxes)
                {
                    Console.WriteLine($"{box.Type, 10}:{box.Volume.ToString("0.00")}");
                }
            }

        }
        public void PrintResult(List<FishmanResult> fishmanResults, int currentStep)
        {
            Console.SetCursorPosition(0, _pondHeight + 2);
            Console.WriteLine();
            Console.WriteLine($"Итоги симуляции после {currentStep} шагов: ");
            foreach (FishmanResult item in fishmanResults)
            {
                Console.WriteLine($"{item.Fishman.Name} - {item.Cost}$");
            }





        }
    }
}
