using System.Collections.Generic;
using DD.Core.Sprites;

public class Map
{
    public int Width { get; set; }
    public int Height { get; set; }
    public string MapImage { get; set; }
    public IEnumerable<ISprite> MapSprites { get; set; }
}