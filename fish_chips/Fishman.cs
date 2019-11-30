using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fish_chips
{
    class Fishman
    {
        public string Name;
        public List<FishBox> FishBoxes
        {
            get
            {
                List<FishBox> fishBoxes = new List<FishBox>();
                foreach (FishBox box in _fishBoxes)
                {
                    fishBoxes.Add(new FishBox()
                    {
                        Type = box.Type,
                        Volume = box.Volume
                    });
                }
                return fishBoxes;
            }
        }
        private List<FishBox> _fishBoxes;
        private Random _rnd;

        public Fishman()
        {
            _rnd = new Random();
            _fishBoxes = new List<FishBox>();
        }

        public void SetFishBoxes(List<FishBox> fishBoxes)
        {
            _fishBoxes = fishBoxes;
        }
        public Direction GetDirection()
        {
            Direction direction = (Direction)_rnd.Next(0, 4);
            return direction;
        }
        public int GetDistance()
        {
            return _rnd.Next(1, 10);
        }

        public int GetCatchSize()
        {
            return _rnd.Next(50, 100);
        }
        public void AddFish(Fish fish)
        {
            AddFish(fish.Type, fish.Volume);
        }

        public void AddFish(FishType type, double volume) // BEST !!!!
        {
            foreach (FishBox box in _fishBoxes)
            {
                if (box.Type == type)
                {
                    box.Volume += volume;
                    break;
                }
            }
        }

    }
}
