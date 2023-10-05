using UnityEngine;

namespace Tile
{
    [DisallowMultipleComponent]
    public class TileRow : MonoBehaviour
    {
        public TileCell[] CellsArray { get; private set; }

        private void Awake()
            => CellsArray = GetComponentsInChildren<TileCell>();
    }
}
