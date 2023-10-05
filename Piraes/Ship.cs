using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
	internal class Ship
	{
		private List<Pirate> pirates = new List<Pirate>();
		private Pirate captain;
		private int captainGrog;
		public Ship()
		{
			captainGrog = 0;
		}
		public void fillShip()
		{
			captain = new Pirate(0);
			int j = captain.callRandom(1, 114);
			for (int i = 1; i < j; i++)
			{
				pirates.Add(new Pirate(i));
			}
		}
		public override string ToString()
		{
			return "Kalózok száma: " + pirates.Count;
		}
	}
}
