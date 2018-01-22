using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA5_GreenSteven_PokeDexWithClasses
{

    class Pokemon
    {
        public Pokemon() { }

        public Pokemon( string Name, string Type, int HP, double Height, double Weight)
        {
            _pokeName = Name;
            _pokeType = Type;
            _pokeHP = HP;
            _pokeHeight = Height;
            _pokeWeigh = Weight;

        }

        private string _pokeName;
        public string Name
        {
            get { return _pokeName;}
            set { _pokeName = value; }
        }
        private string _pokeType;
        public string Type
        {
            get { return _pokeType; }
            set { _pokeType = value; }
        }
        private int _pokeHP;
        public int HP
        {
            get { return _pokeHP; }
            set { _pokeHP = value; }
        }
        private double _pokeHeight;
        public double Height
        {
            get { return _pokeHeight; }
            set { _pokeHeight = value; }
        }
        private double _pokeWeigh;
        public double Weight
        {
            get { return _pokeWeigh; }
            set { _pokeWeigh = value; }
        }
    }
}
