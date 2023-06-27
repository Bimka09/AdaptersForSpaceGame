using SpaceGame.Adapters;
using SpaceGame.Model;
using System.Numerics;

var starship = new Starship(-7, 1, 3);
var moveAdapter = new MovableAdpater(starship);
var rotateAdapter = new RotableAdapter(starship);
moveAdapter.SetPosition(new Vector2(12,5));
moveAdapter.Move();
Console.WriteLine();

