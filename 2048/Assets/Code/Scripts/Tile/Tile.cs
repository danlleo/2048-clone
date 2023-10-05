using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Tile
{
    [DisallowMultipleComponent]
    public class Tile : MonoBehaviour
    {
        public TileState State { get; private set; }
        public TileCell Cell { get; private set; }
        
        public int Number { get; private set; }

        [SerializeField] private Image _background;
        [SerializeField] private TextMeshProUGUI _text;

        public void SetState(TileState state, int number)
        {
            State = state;
            Number = number;

            _text.color = state.TextColor;
            _text.text = $"{number}";
            _background.color = state.BackgroundColor;
        }

        public void SpawnAt(TileCell cell)
        {
            if (Cell != null)
                Cell.Tile = null;
            
            Cell = cell;
            Cell.Tile = this;
            
            transform.position = cell.transform.position;
        }
    }
}
