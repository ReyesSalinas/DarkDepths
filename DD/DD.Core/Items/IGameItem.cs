using System;
using System.Linq;
public interface IGameItem
{
    int Id { get; set; }
    string Name { get; set; }
    int Bonus { get; set; }
}
