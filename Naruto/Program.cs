using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naruto
{
	class Program
	{
		public static void doWork()
		{
			
			Konoha team10 = new Konoha();
			team10.MakeTeam("Asuma", "Choji", "Ino", "Shikamaru");

			Taijustsu bukijutsu = new Taijustsu();
			bukijutsu.useChakra("name");


			if (team10.leader == "ASUMA")
			{
				RankS teamAsuma = new RankS();
				teamAsuma.acceptMission();
				Taijustsu asuma = new Taijustsu();
				asuma.useChakra("Asuma");
			}

			Personnel.attack();

			Taijustsu hidanBukijutsu = new Taijustsu();
			hidanBukijutsu.useChakra("Hidan");

			Fire asumaFire = new Fire();
			asumaFire.useChakra("Asuma");

			Personnel.isFighting("string");


			Shadow.ShadowNeckBinding();
			
			Kunoichi ino = new Kunoichi();
			ino.controlChakra("Ino");

			Personnel hidan = new Personnel();
			Personnel kakuzu = new Personnel();
			Akatsuki hidanAgain = new Akatsuki();
			Akatsuki kakuzuAgain = new Akatsuki();

			

			hidan.Speak("Hidan");
			kakuzu.Speak("Kakuzu");

			Taijustsu.ChakraBlades();
	
			hidanAgain.Speak("hidan");
			kakuzuAgain.Speak("Kakuzu");

			Mission newMission = new Mission();
			newMission.getMission();
			RankD.acceptMission();
		}

		static void Main(string[] args)
		{
			doWork();
		}
	}
}
