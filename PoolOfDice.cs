using System;
using System.Collections.Generic;

namespace Activity4._4._2
{
    class PoolOfDice
    {
        private List<Dice> _pool = new List<Dice>();
        private Random _rand = new Random((int)DateTime.Now.Ticks);


        public PoolOfDice()
        {

        }
        public void Add(Dice newDice)
        {
            this._pool.Add(newDice);
        }
        public void Remove()
        {
            this._pool.RemoveAt(this._rand.Next(0,this._pool.Count));
        }
        public int Count
        {
            private set{}
            get {return this._pool.Count;}
        }
        public List<Dice> ListOfDice
        {
            private set{}
            get {return this._pool;}
        }
    }
}