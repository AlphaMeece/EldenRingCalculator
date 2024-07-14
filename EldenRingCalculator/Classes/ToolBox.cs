namespace EldenRingCalculator.Classes
{
	public static class ToolBox
	{
        public enum itemType { Weapon, Arrow, Bolt, AOW, Head, Chest, Pants, Boots, Talisman, Buff, Magic };
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
			None,
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

		public static StatScale?[] Scales = {
			new StatScale([ 1, 18, 60, 80, 150 ], [ 0, 25, 75, 90, 110 ], [ 1.2, -1.2, 1, 1, 1 ]), //Default- 0
			new StatScale([ 1, 20, 60, 80, 150 ], [ 0, 35, 75, 90, 110 ], [ 1.2, -1.2, 1, 1, 1 ]), //Heavy- 1
            new StatScale([ 1, 20, 60, 80, 150 ], [ 0, 35, 75, 90, 110 ], [ 1.2, -1.2, 1, 1, 1 ]), //Keen- 2
			null, //Unused- 3
			new StatScale([ 1, 20, 50, 80, 99 ], [ 0, 40, 80, 95, 100 ], [ 1, 1, 1, 1, 1 ]), //Elements- 4
			new StatScale([ 1, 20, 40, 80, 99 ], [ 0, 75, 225, 270, 300 ], [ 1, 1, 1, 1, 1 ]), //Serpent Bow poison- 5
			new StatScale([ 1, 25, 45, 60, 99 ], [ 0, 10, 75, 90, 100 ], [ 1, 1, 1, 1, 1 ]), //General status- 6
			new StatScale([ 1, 20, 60, 80, 150 ], [ 0, 35, 75, 90, 110 ], [ 1.2, -1.2, 1, 1, 1 ]), //Occult- 7
			new StatScale([ 1, 16, 58, 80, 150 ], [ 0, 25, 75, 90, 110 ], [ 1.2, -1.2, 1, 1, 1 ]), //Quality- 8
			null, //Unused- 9
			new StatScale([ 1, 15, 30, 50, 99 ], [ 0, 10, 50, 60, 70 ], [ 1, 1, 1, 1, 1 ]), //Consumable/Ripple blade status- 10
			new StatScale([ 1, 25, 45, 60, 99 ], [ 0, 6, 15, 18, 20 ], [ 1, 1, 1, 1, 1 ]), //Albinauric/Dragon Communion status- 11
			null, //Unknown- 12
			null, //Unknown- 13
			new StatScale([ 1, 20, 40, 80, 99 ], [ 0, 40, 60, 85, 100 ], [ 1, 1, 1, 1, 1 ]), //Demi-Human Queen's Staff- 14
			new StatScale([ 1, 25, 60, 80, 99 ], [ 0, 25, 65, 95, 100 ], [ 1, 1, 1, 1, 1 ]), //Poisoned/Maddening Hand Status- 15
			null, //Unknown- 16
			null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, //Unused- 17-49
			null, //Unknown- 50
			null, //Unknown- 51
			null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, //Unused 52-99
            new StatScale([ 1, 25, 40, 60, 99 ], [ 300, 800, 1450, 1900, 2100 ], [ 1.5, 1.1, -1.2, -1.2, 1 ]), //HP Scaling: Vigor- 100
			new StatScale([ 1, 15, 35, 60, 99 ], [ 50, 95, 200, 350, 450 ], [ 1, 1, -1.2, 1, 1 ]), //FP Scaling: Mind- 101
			new StatScale([ 1, 150, 170, 240, 792 ], [ 40, 100, 120, 135, 155 ], [ 1, 1, 1, 1, 1 ]), //Defense: Soul Level- 102
			null, //Unused
			new StatScale([ 1, 15, 30, 50, 99 ], [ 80, 105, 130, 155, 170 ], [ 1, 1, 1, 1, 1 ]), //Stamina: Endurance- 104
			null, null, null, null, null, //Unused- 105-109
            new StatScale([ 1, 150, 190, 240, 792], [ 75, 105, 145, 160, 180 ], [ 1, 1, 1, 1, 1 ]), //Poison Resistance: Soul Level- 110
			new StatScale([ 1, 150, 190, 240, 792], [ 75, 105, 145, 160, 180 ], [ 1, 1, 1, 1, 1 ]), //Scarlet Rot Resistance: Soul Level- 111
			new StatScale([ 1, 150, 190, 240, 792], [ 75, 105, 145, 160, 180 ], [ 1, 1, 1, 1, 1 ]), //Hemorrhage Resistance: Soul Level- 112
			new StatScale([ 1, 150, 190, 240, 792], [ 75, 105, 145, 160, 180 ], [ 1, 1, 1, 1, 1 ]), //Frostbite Resistance: Soul Level- 113
			new StatScale([ 1, 150, 190, 240, 792], [ 75, 105, 145, 160, 180 ], [ 1, 1, 1, 1, 1 ]), //Sleep Resistance: Soul Level- 114
			new StatScale([ 1, 150, 190, 240, 792], [ 75, 105, 145, 160, 180 ], [ 1, 1, 1, 1, 1 ]), //Madness Resistance: Soul Level- 115
			new StatScale([ 1, 150, 190, 240, 792], [ 75, 105, 145, 160, 180 ], [ 1, 1, 1, 1, 1 ]), //Death Resistance: Soul Level- 116
			null, null, null, //Unused- 117-119
			new StatScale([ 0, 30, 40, 60, 99 ], [ 0, 0, 30, 40, 50 ], [ 1, 1, 1, 1, 1 ]), //Poison Resistance: Vigor- 120
			new StatScale([ 0, 30, 40, 60, 99 ], [ 0, 0, 30, 40, 50 ], [ 1, 1, 1, 1, 1 ]), //Scarlet Rot Resistance: Vigor- 121
			new StatScale([ 0, 30, 40, 60, 99 ], [ 0, 0, 30, 40, 50 ], [ 1, 1, 1, 1, 1 ]), //Hemorrhage Resistance: Endurance- 122
			new StatScale([ 0, 30, 40, 60, 99 ], [ 0, 0, 30, 40, 50 ], [ 1, 1, 1, 1, 1 ]), //Frostbite Resistance: Endurance- 123
			new StatScale([ 0, 30, 40, 60, 99 ], [ 0, 0, 30, 40, 50 ], [ 1, 1, 1, 1, 1 ]), //Sleep Resistance: Mind- 124
			new StatScale([ 0, 30, 40, 60, 99 ], [ 0, 0, 30, 40, 50 ], [ 1, 1, 1, 1, 1 ]), //Madness Resistance: Mind- 125
			new StatScale([ 0, 15, 40, 60, 99 ], [ 0, 15, 30, 40, 50 ], [ 1, 1, 1, 1, 1 ]), //Death Resistance: Arcane- 126
			null, null, null, //Unused- 127-129
			new StatScale([ 0, 30, 40, 60, 99 ], [ 0, 10, 15, 30, 40 ], [ 1, 1, 1, 1, 1 ]), //Physical Defense: Strength- 130
			null, //Physical Defense: Vigor, Unused- 131
			new StatScale([ 0, 20, 35, 60, 99 ], [ 0, 40, 50, 60, 70 ], [ 1, 1, 1, 1, 1 ]), //Magic Defense: Intelligence- 132
			new StatScale([ 0, 30, 40, 60, 99 ], [ 0, 20, 40, 60, 70 ], [ 1, 1, 1, 1, 1 ]), //Fire Defense: Vigor- 133
			null, //Lightning Defense: Endurance, Unused(why)- 134
			new StatScale([ 0, 20, 35, 60, 99 ], [ 0, 40, 50, 60, 70 ], [ 1, 1, 1, 1, 1 ]), //Holy Defense: Arcane- 135
			null, null, null, null, //Unused- 136-139
			new StatScale([ 0, 30, 40, 60, 99 ], [ 0, 30, 40, 60, 99 ], [ 1, 1, 1, 1, 1 ]), //Item Discovery: Arcane- 140
			null, null, null, null, null, null, null, null, null, //Unused- 141-149
			null, //Unknown- 150
			null, null, null, null, null, null, null, null, null, //Unused- 151-159
			null, null, null, null, //Shield Stuff: Unused- 160-163
			null, null, null, null, null, null, //Unused- 164-169
			null, //Weapon Arts: Strength, Unused- 170
			new StatScale([ 0, 10, 30, 60, 99 ], [ 0, 20, 22, 25, 30 ], [ 1, 1, 1, 1, 1 ]), //Weapon Arts: Dexterity- 171
			null, null, null, null, null, null, null, null, null, null,
            null, null, null, null, null, null, null, null, null, null,
            null, null, null, null, null, null, null, null, //Unused- 172-199
			null, //Soul Level cost, Used but not by me :) -200
			null, null, null, null, null, null, null, null, null, //Unused 201-209
			null, null, null, null, null, null, null, null, null, null, //Fall Damage + Unused- 210-219
			new StatScale([ 1, 8, 25, 60, 99 ], [ 45, 45, 72, 120, 160 ], [ 1, 1, 1.1, 1, 1 ]) //Equip Load: Endurance- 220
        };

        public static int Scaling(int stat, int scaleID, int scale = 1) //int currentCap, int previousCap, double exp, int baseValue, int maxValue
        {
			if (Scales[scaleID] != null)
			{
				int id;
				for (id = 0; id < Scales[scaleID].Points.Length; id++)
				{
					if (stat <= Scales[scaleID].Points[id]) break;
				}
				if (id == 0) return Scales[scaleID].Coefficients[0];

				if (Scales[scaleID].Factors[id-1] > 0)
				{
            		return (int)(Scales[scaleID].Coefficients[id-1]*scale + (Scales[scaleID].Coefficients[id]*scale - Scales[scaleID].Coefficients[id - 1] * scale) * Math.Pow(((double)stat - Scales[scaleID].Points[id-1]) / (Scales[scaleID].Points[id] - Scales[scaleID].Points[id-1]), Scales[scaleID].Factors[id-1]));
				}
				return (int)(Scales[scaleID].Coefficients[id-1] * scale + (Scales[scaleID].Coefficients[id] * scale - Scales[scaleID].Coefficients[id-1] * scale) * (1 - Math.Pow(1 - ((double)stat - Scales[scaleID].Points[id-1]) / (Scales[scaleID].Points[id] - Scales[scaleID].Points[id-1]), -1 * Scales[scaleID].Factors[id-1])));
			}
			return -1;
			
        }
    }
}
