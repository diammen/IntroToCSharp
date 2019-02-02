using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    class Player
    {
        private string name;
        private int fragCount;
        private int deathCount;
        private float totalDamage;
        private int score;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 1 )
                {
                    name = value;
                }
            }
        }
        public int Frags
        {
            get
            {
                return fragCount;
            }
            set
            {
                fragCount = value;
            }
        }
        public int Deaths
        {
            get
            {
                return deathCount;
            }
            set
            {
                deathCount = value;
            }
        }
        public float DamageTotal
        {
            get
            {
                return totalDamage;
            }
            set
            {
                totalDamage = value;
            }
        }
        public int Score
        {
            get
            {
                return deathCount - fragCount;
            }
        }
    }
}
