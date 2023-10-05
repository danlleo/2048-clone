using UnityEngine;

namespace Tile
{
    [DisallowMultipleComponent]
    public class TileGrid : MonoBehaviour
    {
        public TileRow[] RowsArray { get; private set; }        
        public TileCell[] CellsArray { get; private set; }

        public int Size => CellsArray.Length;
        public int Height => RowsArray.Length;
        public int Width => Size / Height;
        
        private void Awake()
        {
            RowsArray = GetComponentsInChildren<TileRow>();
            CellsArray = GetComponentsInChildren<TileCell>();
        }

        private void Start()
        {
            InitializeCellsCoordinates();
        }

        private void InitializeCellsCoordinates()
        {
            for (var y = 0; y < RowsArray.Length; y++)
            {
                for (var x = 0; x < RowsArray[y].CellsArray.Length; x++)
                {
                    RowsArray[y].CellsArray[x].Coordinates = new Vector2Int(x, y);
                }
            }
        }

        public bool TryGetRandomEmptyCell(out TileCell result)
        {
            int index = Random.Range(0, CellsArray.Length);
            int startingIndex = index;

            while (CellsArray[index].IsOccupied)
            {
                index++;

                if (index >= CellsArray.Length)
                    index = 0;

                if (index != startingIndex) continue;
                
                result = null;
                return false;
            }

            result = CellsArray[index];
            return true;
        }
    }
}
