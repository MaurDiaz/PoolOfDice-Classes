using System;

namespace Activity4._4._2
{
    class Dice
    {
        private int _sides;
        private Random _rand = new Random((int)DateTime.Now.Ticks);
        public Dice()
        {

        }
        public Dice(int sides)
        {
            this._sides = sides;
        }
        public int Roll()
        {
            return this._rand.Next(1,this._sides+1);
        }
    }
}