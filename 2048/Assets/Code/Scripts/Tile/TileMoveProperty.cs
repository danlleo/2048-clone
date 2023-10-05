namespace Tile
{
    public struct TileMoveProperty
    {
        public int Start;
        public int Increment;

        public TileMoveProperty(int start, int increment)
        {
            Start = start;
            Increment = increment;
        }
    }
}
