using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naruto
{
	class Mission
	{
		public void getMission()
		{
			Console.WriteLine("You were assigned a new mission");
		}
		public virtual  void acceptMission()
		{
			Console.WriteLine("Stack up on supplies, you are leaving for your mission");
		}
	}

	class RankD : Mission
	{
		public static void acceptMission()
		{
			Console.WriteLine("Your mission is to find a cat, head home ASAP.");
		}
	}

	class RankC : Mission
	{
		public override void acceptMission()
		{
			Console.WriteLine("Little to no chance of combat during this mission.  The reward is between 30K and 100K ryo");
		}

	}

	class RankS : Mission
	{
		
		public override void acceptMission()
		{
			Console.WriteLine("Your mission is to supress Akatsuki, reward for completion at minimum is 1 Million ryo");

		}
	}
}

