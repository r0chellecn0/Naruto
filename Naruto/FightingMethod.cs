using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naruto
{
	public class FightingMethod
	{
		public string name;

		public virtual void useChakra(string name)
		{
			Console.WriteLine("Charging chakra");
		}

		public virtual void controlChakra (string name)
		{
			Console.WriteLine($"{name} begins to focus their chakra" );
		}
	}
	public class Fire: FightingMethod
	{
		
		public override void useChakra(string name)
		{
			if (name == "Asuma")
			{
				Console.WriteLine($"{name} uses a fire jutsu.  Asuma was badly burned.  No damage was done to Hidan");
			}
		}
	}
	class Taijustsu: FightingMethod
	{
		public override void useChakra(string name)
		{
			this.name = name;
			if (name == "Asuma")
			Console.WriteLine("Asuma infuses knives with chakra");
			else if (name == "Hidan")
			{
				Console.WriteLine("Hidan cut Asuma and draws a Jashin symbol on the ground." +
					" Asuma and Hidan are now linked");
			}
		}
		public static void ChakraBlades()
		{
			Console.WriteLine("Asuma wields his chakra blades and sends an invisble wind force to cut off Hidan's head" +
				" Hidan is now decapitated");
		}

	}
	class Shadow: FightingMethod
	{
		public static void ShadowNeckBinding()
		{
			Console.WriteLine("Shikamaru extends his shadow to strangle Hidan and bind him");
		}
		
	}
	class Ninjustsu: FightingMethod
	{

	}
	class Kunoichi: FightingMethod
	{
		public override void controlChakra(string name)
		{
			if (name == "Ino")
			{
				Console.WriteLine("Ino mind transfers with Hidan.  Hidan is now immobilized");
			}
		}
	}
}
