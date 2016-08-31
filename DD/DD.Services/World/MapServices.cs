
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System;

public static class MapsServices
{
	private static Dictionary<int, Point> dic = new Dictionary<int,Point>();

    public static string PlayerControledSprite { get; private set; }

    public static void SetAllPositions(IEnumerable<ISprite> sprites,Map map)
	{
		foreach(ISprite o in sprites.Where(x => x is ObjectSprite))
		{
			
		}
		foreach(ISprite p in sprites.Where(x => x.Type == PlayerControledSprite))
		{
            Point point;
            do
            {
                point = new Point()
                {
                    X = new Random().Next(0, map.X),
                    Y = new Random().Next(0, map.Y)
                };
            }
            while (dic.Values.Any(x => x == point) || point == null);           
		}
	}
	
	public static Point GetPosition(int ID)
	{
		 return dic.Single(x => x.Key == ID).Value;
	}
}
