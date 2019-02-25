using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naruto
{
	class Personnel
	{
		public string leader;
		
		public void MakeTeam(string leader, string member1, string member2, string member3)
		{
			this.leader = leader;
;
			Console.WriteLine("Which person do you want on your team? Hidan or Asuma?");
			string pickLeader = Console.ReadLine().ToUpper();
			if (pickLeader == "ASUMA")
			{
				Console.WriteLine($"You are part of Team 10, which consists of {leader}, {member1}, {member2}, {member3}. ");
			}
			else if (pickLeader == "HIDAN")
			{
				Akatsuki.MakeTeam("Hidan", "Kakuzu");
			}

			else {
				Console.WriteLine("Incorrect response.  I'll pick your team for you. ");
				Akatsuki.MakeTeam("Hidan", "Kakuzu");

			}

		}
		public virtual void Speak(string name)
		{
			switch (name)
			{
				case "Kakuzu":
					Console.WriteLine("Kakuzu tells Hidan, \"You told me you could beat them youself\" ");
					break;
				case "Hidan":
					Console.WriteLine("Hidan yells, \"KAKUZU! WHAT ARE YOU DOING! HELP ME\" ");
					break;
			}

		}

		public static void attack()
		{
			Console.WriteLine("Who should attack first?");
			string firstAttack = Console.ReadLine().ToUpper();
			if (firstAttack == "ASUMA")
			{
				Konoha.shortRangeAttack();

			}
			else if (firstAttack == "KAKUZU")
			{
				Console.WriteLine("Kakuzu is annoyed and lets Hidan do the fighting.");
			}

			else
			{
				Console.WriteLine("InoShikaCho tried to attack first and put Asuma in danger because Hidan is immortal!");
				
			}
		}

		public static string JoinFight(string name)
		{
			switch (name)
			{
				case "KAKUZU":
					Console.WriteLine("Kakuzu joins the fight!!");
					break;
				case "INO":
					Console.WriteLine("Ino joins the fight!!");
					break;
				case "SHIKAMARU":
					Console.WriteLine("Shikamaru joins the fight!!");
					break;
			}
			return name;
		}

		public static bool isFighting(string name)
		{
			Console.WriteLine("Who should join the fight?!");
			string joinFight = Console.ReadLine().ToUpper();
			if (joinFight == "INO" || joinFight == "SHIKAMARU")
			{
				JoinFight(joinFight);
				
			}
			else if (joinFight == "KAKUZU")
			{
				JoinFight("Kakuzu");
			}
			else
			{
				Console.WriteLine("Here comes Team 10! ");
		
			}
			return false;
		}
		public static void AsumaDies()
		{
			Console.WriteLine("Asuma needed his team.  Asuma is now dead");
		}
		public void shortRangeAttack()
		{
			Console.WriteLine("Time for hand to hand combat!");
			

		}
		public virtual void longRangeAttack()
		{
			Console.WriteLine("Must use weapons...");
		}
		
	}
	class Konoha : Personnel
	{
		public static void shortRangeAttack()
		{
			Console.WriteLine("Asuma uses close-ranged melee combat that revolves around taijutsu.");	

		}
		public override void longRangeAttack()
		{
			Console.WriteLine("Switching to fighting method...");
		}

	}
	class Akatsuki : Personnel
	{
		
		public static void MakeTeam(string member1, string member2)
		{
			Console.WriteLine($"You are part of the Akatsuki and looking for bounty.  On your team is {member1} and {member2}");

		}

		public override void longRangeAttack()
		{
			Console.WriteLine("Hidan wields his Triple Bladed Scythe.  He will inflict the same damage that gets inflicted on him" +
				" if he can cut you and licks the blood");
		}

		public override void Speak(string name)
		{
			if (name == "Kakuzu")
			{
				Console.WriteLine("Kakuzu is annoyed with Hidan, but helps his decapitated friend.");
			}
			else if (name == "Hidan")
			{
				Console.WriteLine("Help me  Kakuzu, so I can sew my head back on!");
			}
			else Console.WriteLine("Kakuzu laughs at Hidan, grabs his head and his body and lets Hidan recover");
		}
	}
}
