using System;
using System.Drawing;
namespace SeminarsikeOOP;

class SeminarsikeOOP 
{
	public static void Main() 
	{
		
		Player player1 = new Player() 
    {
			Name = GetName(),

		};
		Player player2 = new Player() 
		{
			Name = GetName()
		};


	}

	public static string GetName() 
	{
		Console.Write("Write name: ");
		return Console.ReadLine();
	}

	public static void GetShipCoordinates()
	{

	}
}


class Player 
{
	public required string Name {get; set; }
	private Table playerTable {get; set; } //❤️🙌
	
	public Ship playerShips {get; set; }
	
	private void AttackPlayer(Table enemyTable, Point attackCoordinates)
	{
  	if (enemyTable.SizeOfTable[attackCoordinates.X, attackCoordinates.Y] == 1)
		{
			enemyTable.SizeOfTable[attackCoordinates.X, attackCoordinates.Y] = 0;
		}
	}

	private void LocateShips(Table table, Ship[] playerShips) 
	{
		foreach(var ship in playerShips)
		{ 
			table.SizeOfTable[ship.location.X, ship.location.Y] = 1;
		}
	}
}
class Ship 
{
	public string Name {get; set;}
	public int size {get; set; }

	public Point location {get; set;}
	private int health = locations.Length;
    // отче наш ежели есть ты на небисье да светится имя твоё да придёт царствие твоё ибо не веди нас во искушение
}

class Table
{
	public int[,] SizeOfTable = new int[10, 10]; 
}