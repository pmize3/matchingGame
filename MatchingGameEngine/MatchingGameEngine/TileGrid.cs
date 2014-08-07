using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MatchingGameEngine
{
    internal class TileGrid
    {
        private int _rowCount;
        private int _colCount;
        private Collection<Collection<Tile>> _grid;

        public TileGrid(int rows, int columns)
        {
            _grid = new Collection<Collection<Tile>>();
            for (int i = 0; i < columns; i++)
                _grid.Add(new Collection<Tile>());
            _rowCount = rows;
            _colCount = columns;
        }

        public int ColumnOf(Tile tile)
        {
            return _grid.IndexOf(_grid.First(c => c.Contains(tile)));
        }

        public int RowOf(Tile tile)
        {
            return _grid.First(c => c.Contains(tile)).IndexOf(tile);
        }

        public void Add(int column, Tile tile)
        {
            if (_colCount <= column && column <= 0)
                throw new ArgumentOutOfRangeException("column");
            _grid[column].Add(tile);
        }
    }
}
