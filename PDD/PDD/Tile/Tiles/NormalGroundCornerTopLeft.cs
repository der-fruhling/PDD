namespace PDD.Tile
{
    public class NormalGroundCornerTopLeft : Tile
    {
        protected override string TileTexturePath => "Tile/NormalGroundCornerTL";
        internal override bool IsSolid => true;
        internal override bool CanFall => false;
        internal override bool Deadly => false;
        internal override int TileId => 11;
    }
}