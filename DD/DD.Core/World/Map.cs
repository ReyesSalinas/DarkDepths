using System.Collections.Generic;

public class Map
{
    public int X { get; set; }
    public int Y { get; set; }
    public string MapImage { get; set; }
    public IEnumerable<ISprite> MapSprites { get; set; }
}