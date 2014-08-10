using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MatchingGameEngine
{
    internal class Tile
    {
        private int _value;
        private int xLoc;
        private int yLoc;
        private Collection<Tile> _owner;

        public int Value
        {
            get { return _value; }
            set { _value = value;}
        }

        public int X
        {
            get { return xLoc; }
            set { xLoc = value; }
        }

        public int Y
        {
            get { return yLoc; }
            set { yLoc = value; }
        }

        public Tile()
        {
        }

        // JM: It may be a good idea to create a class to represent a
        //     column for easier future feature implementation. (i.e the
        //     column may want to have a reference to the owning grid, etc.)
        public Tile(int pValue, int x, Collection<Tile> column)
        {
            _value = pValue;
            xLoc = x;
            yLoc = column.Count;
            column.Add(this);
            _owner = column;
        }

        public bool Matches(Tile tile)
        {
            return tile._value == this._value;
        }

        // JM: Does it make sense to clear the value here? We may
        // want to know the value of tiles even after we remove them.
        public void Remove()
        {
            _owner.Remove(this);
            _value = -1;
            xLoc = -1;
            yLoc = -1;
        }
    }
}
