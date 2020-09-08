namespace PDD.Tile
{
    /*
     * Air is special.
     * It will fill all unused block space automatically.
     *
     *   TODO Make above claim true.
     */
    public class Air : Tile
    {
        protected override string TileTexturePath => "Tile/Air";
        internal override bool IsSolid => false;
        internal override bool CanFall => false;
        internal override bool Deadly => false;
        internal override int TileId => 0;
    }
}