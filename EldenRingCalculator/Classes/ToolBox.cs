namespace EldenRingCalculator.Classes
{
	public static class ToolBox
	{
        public enum itemType { Weapon, Arrow, Bolt, AOW, Head, Chest, Pants, Boots, Talisman, Buff };
		public enum weaponCategory { 
			None, 
			Dagger = 20, 
			Torch, 
			Claw, 
			StraightSword, 
			Twinblade, 
			Greatsword, 
			ColossalSword, 
			ThrustingSword, 
			CurvedSword, 
			Katana, 
			Axe, 
			ColossalWeapon, 
			Greataxe, 
			Hammer, 
			Flail, 
			GreatHammer, 
			Spear, 
			GreatSpear, 
			Halberd,  
			HeavyThrustingSword,
			CurvedGreatsword,
			Catalyst,
			Fist,
			Whip,
			Bow,
			Greatbow,
			Crossbow,
			Greatshield,
			SmallShield,
			MediumShield,
			Sycthe,
			LightBow,
			Ballista,
			ThrowingBlade,
			HandToHand,
			PerfumeBottle,
			ThrustingShield,
			ReverseHandSword,
			LightGreatsword,
			GreatKatana,
			BeastClaw
		}
		public enum reinforceType
		{
			Standard,
			Heavy,
			Keen,
			Quality,
			Fire,
			FlameArt,
			Lightning,
			Sacred,
			Magic,
			Cold,
			Poison,
			Blood,
			Occult,
			Catalyst,
			Unique,
			UniqueCatalyst,
			CrossbowOrBallista,
			UniqueCrossbowOrBallista,
			PulleyCrossbow,
			SpecialKeen,
			SpecialHeavy,
			SmallShield,
			MediumShield,
			Greatshield,
			UniqueGreatshield,
			CoilShield
		}
        public static int Scaling(int stat, int currentCap, int previousCap, double exp, int baseValue, int maxValue, int scale = 1)
		{
			if (exp > 0)
			{
				return (int)(baseValue*scale + (maxValue*scale - baseValue*scale) * Math.Pow(((double)stat - previousCap) / (currentCap - previousCap), exp));
			}
			return (int)(baseValue*scale + (maxValue*scale - baseValue*scale) * (1 - Math.Pow(1 - ((double)stat - previousCap) / (currentCap - previousCap), -1 * exp)));
		}
	}
}
