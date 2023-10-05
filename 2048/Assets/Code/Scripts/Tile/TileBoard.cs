using System.Collections.Generic;
using UnityEngine;

namespace Tile
{
    [DisallowMultipleComponent]
    public class TileBoard : MonoBehaviour
    {
        private const int TilesNumber = 16;
        private const int DefaultTilesOnBoardNumber = 2;
        private const int DefaultTileNumber = 2;
        
        [SerializeField] private Tile _tilePrefab;
        [SerializeField] private TileGrid _grid;
        [SerializeField] private TileState[] _tileStatesArray;

        private TileState InitialTileState => _tileStatesArray[0];
        
        private List<Tile> _tileList = new(TilesNumber);

        private void Start()
        {
            InitializeDefaultTiles();
        }

        private void CreateTile()
        {
            if (!_grid.TryGetRandomEmptyCell(out TileCell randomEmptyCell)) return;
            
            Tile tile = Instantiate(_tilePrefab, _grid.transform);
            tile.SetState(InitialTileState, DefaultTileNumber);
            tile.SpawnAt(randomEmptyCell);
            _tileList.Add(tile);
        }

        private void InitializeDefaultTiles()
        {
            for (var i = 0; i < DefaultTilesOnBoardNumber; i++)
            {
                CreateTile();
            }
        }
    }
}
