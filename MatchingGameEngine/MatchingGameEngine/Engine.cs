using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MatchingGameEngine
{
    public class Engine
    {
        private Tile[][] _grid;
        public Engine(int columns, int rows)
        {
            _grid = new Tile[rows][];
            Run();
        }

        private void Run()
        {
            while (true)
            {

            }
        }


    }
}
