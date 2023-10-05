using System;
using UnityEngine;

namespace Tile
{
    [DisallowMultipleComponent]
    public class Move : MonoBehaviour
    {
        [SerializeField] private TileGrid _grid;

        private void Update()
        {
            throw new NotImplementedException();
        }

        private void MoveTiles(Vector2Int direction, TileMoveProperty tileMovePropertyX, TileMoveProperty tileMovePropertyY)
        {
            for (int x = tileMovePropertyX.Start; x >= 0 && x < _grid.Width; x += tileMovePropertyX.Increment)
            {
                for (int y = tileMovePropertyY.Start; y >= 0 && y < _grid.Height; y += tileMovePropertyY.Increment)
                {
                    // TODO: Move tiles here
                }
            }
        }
    }
}
