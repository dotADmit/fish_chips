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
        private int _numOfFishmen;
        private int _numOfFish;
        private int _numOfIter;



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

        }
        public void PrintStatistics (List<Fishman> fishmen, int currentStep)
        {

        }
        //public void PrintResult( List<FishmanResult> fishmanResults, int currentStep)
        //{

        //}
    }
}
