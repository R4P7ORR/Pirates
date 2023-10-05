using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
	internal class Pirate
	{
		private int intoxication;
		private bool isDead;
		private int passedOut;
		private int id;

        public Pirate(int id)
		{
			this.intoxication = 0;
			this.isDead = false;
			this.passedOut = 0;
			this.id = id;

		}
		public void drinkSomeRum()
		{
			this.intoxication++;
		}
		public void howsItGoingMate()
		{
			if (this.intoxication < 4)
			{
                Console.WriteLine("Pour me anudder!");
            }
			else
			{
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
				passOut();
				intoxication = 0;
            }
		}
		
		public void brawl(Pirate opponent)
		{
			if (this.passedOut > 0 || opponent.passedOut > 0)
			{
                Console.WriteLine("Come on mate! Ye not gonna fight someone four sheets to the wind eh?");
            }
			else
			{
				if (!this.isDead && !opponent.isDead)
				{
					switch (callRandom(0, 3))
					{
						case 0:
							this.die();
							Console.WriteLine($"Avast ye! {this.id} and {opponent.id} are havin a brawl! It seems" +
								$"{this.id} is goin to Davy Jones' locker tonight.");
							break;
						case 1:
							opponent.die();
							Console.WriteLine($"Avast ye! {this.id} and {opponent.id} are havin a brawl! It seems" +
								$"{opponent.id} is goin to Davy Jones' locker tonight.");
							break;
						case 2:
							this.passOut();
							opponent.passOut();
                            Console.WriteLine($"Avast ye! {this.id} and {opponent.id} are havin a brawl, but " +
								$"they bo be carousers, seems they bo be hittin' four sheets to the wind!");
                            break;
					}
				}
				else
				{
					Console.WriteLine("He dead as thee wreck on the sho' mate!");
				}
			}
		}
		public void die()
		{
			this.passedOut = 0;
			this.isDead = true;
		}
		public void passOut()
		{
			this.passedOut = 4;
		}
		public int callRandom(int min, int max)
		{
			Random r = new Random();
			return r.Next(min, max);
		}
	}
}
