﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public struct Enemy
    {
        public string name { get; set; }
        public float curHealth { get; set; }
        public float maxHealth { get; set; }
        public float gil { get; set; }
        public bool isRare { get; set; }

        public Enemy(string _name, float _curHealth, float _maxHealth, float _gil, bool _isRare)
        {
            name = _name;
            curHealth = _curHealth;
            maxHealth = _maxHealth;
            gil = _gil;
            isRare = _isRare;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CustomSerializer serialize = new CustomSerializer();
            Enemy test = new Enemy("Dryad", 10, 10, 25, true);

            string data = serialize.Serialize(test);

            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
