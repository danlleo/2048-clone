using UnityEngine;

namespace Tile
{
    [CreateAssetMenu(fileName = "TileState_", menuName = "Scriptable Objects/TileStates/TileState")]
    public class TileState : ScriptableObject
    {
        [SerializeField] private Color _backgroundColor;
        [SerializeField] private Color _textColor;

        public Color BackgroundColor => _backgroundColor;
        public Color TextColor => _textColor;
    }
}
