using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRolling.Models
{
    public class DieModel
    {
        private static readonly Random _rnd = new Random();
        public DieModel()
        {
            Roll();
        }

        public void Roll()
        {
            this.Value = 1 + (_rnd.Next() % 6);
        }

        public int Value { get; set; }
    }
}
