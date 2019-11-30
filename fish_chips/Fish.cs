using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fish_chips
{
    class Fish
    {
        public readonly FishType Type;
        public double Volume;
        private Random _rnd;

        public Fish(FishType fishType, double volume)
        {
            Type = fishType;
            Volume = volume;

            _rnd = new Random();
        }

        public int GetawayCount()
        {
            switch (Type){
                case FishType.Navaga:
                    return _rnd.Next(0, 20);
                case FishType.Keta:
                    return _rnd.Next(0, 40);
                case FishType.Halibut:
                    return _rnd.Next(0, 60);
                default:
                    return 0;
            }

        }


    }
}
