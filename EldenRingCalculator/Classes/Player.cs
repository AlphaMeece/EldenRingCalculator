

namespace EldenRingCalculator.Classes
{
	public class Player
	{
		public string Class;
		public int Level;
		public int HP;
		public int FP;
		public int SP;
		public int Poise;
		public double EquipLoad;
		public int Discovery;

		public int[] Stats;
		public int[] OldStats;
		public int[] Defenses;
		public int[] Resistances;

		public string SelectedSlot;
		public EquipItem SelectedItem;

		public Action ValuesChanged;


		public Player()
		{
			Class = "Hero";
			Level = 7;
			HP = 499;
			FP = 75;
			SP = 99;
			Poise = 0;
			EquipLoad = 51.4;
			Discovery = 111;

			Stats = [ 14, 9, 12, 16, 9, 7, 8, 11 ];
			OldStats = [14, 9, 12, 16, 9, 7, 8, 11];
			Defenses = [ 79, 79, 79, 79, 88, 83, 74, 96 ];
			Resistances = [ 92, 92, 92, 103 ];

			SelectedSlot = "Right Hand Armament 1";
			SelectedItem = ItemTable.Weapons["Unarmed"];
		}
		

		public void UpdateClass()
		{
			switch (this.Class)
			{
				case "Hero":
					this.Stats = [14, 9, 12, 16, 9, 7, 8, 11];
					this.Level = 7;
					break;
				case "Bandit":
					this.Stats = [10, 11, 10, 9, 13, 9, 8, 14];
					this.Level = 5;
					break;
				case "Astrologer":
					this.Stats = [9, 15, 9, 8, 12, 16, 7, 9];
					this.Level = 6;
					break;
				case "Warrior":
					this.Stats = [11, 12, 11, 10, 16, 10, 8, 9];
					this.Level = 8;
					break;
				case "Prisoner":
					this.Stats = [11, 12, 11, 11, 14, 14, 6, 9];
					this.Level = 9;
					break;
				case "Confessor":
					this.Stats = [10, 13, 10, 12, 12, 9, 14, 9];
					this.Level = 10;
					break;
				case "Wretch":
					this.Stats = [10, 10, 10, 10, 10, 10, 10, 10];
					this.Level = 1;
					break;
				case "Vagabond":
					this.Stats = [15, 10, 11, 14, 13, 9, 9, 7];
					this.Level = 9;
					break;
				case "Prophet":
					this.Stats = [10, 14, 8, 11, 10, 7, 16, 11];
					this.Level = 7;
					break;
				case "Samurai":
					this.Stats = [12, 11, 13, 12, 15, 9, 8, 8];
					this.Level = 9;
					break;
				default:
					this.Stats = [1, 1, 1, 1, 1, 1, 1, 1];
					this.Level = 0;
					break;
			}
			this.Stats.CopyTo(this.OldStats, 0);
			UpdateStats();
		}

		public void UpdateStats()
		{
			for (int i = 0; i < this.Stats.Length; i++)
			{
				if (this.Stats[i] < 1) this.Stats[i] = 1;
				if (this.Stats[i] > 99) this.Stats[i] = 99;
				if (this.Stats[i] == this.OldStats[i]) continue;
				if (this.Stats[i] > this.OldStats[i]) this.Level += this.Stats[i] - this.OldStats[i];
				else this.Level -= this.OldStats[i] - this.Stats[i];
			}
			this.Stats.CopyTo(this.OldStats, 0);

			if (this.Level > 712) this.Level = 712;
			if (this.Level < 1) this.Level = 1;
			this.Defenses = [0, 0, 0, 0, 0, 0, 0, 0];
			this.Resistances = [0, 0, 0, 0];

			//Level Defenses
			Array.Fill(this.Defenses, ToolBox.Scaling(this.Level + 80, 102, 10));

            //Level Resistances
            Array.Fill(this.Resistances, ToolBox.Scaling(this.Level + 80, 110, 10));

            //Strength Physical Defenses
            this.Defenses[0] += ToolBox.Scaling(this.Stats[3], 130, 10);
            this.Defenses[1] += ToolBox.Scaling(this.Stats[3], 130, 10);
            this.Defenses[2] += ToolBox.Scaling(this.Stats[3], 130, 10);
            this.Defenses[3] += ToolBox.Scaling(this.Stats[3], 130, 10);

            //Intelligence Magic Defenses
            this.Defenses[4] += ToolBox.Scaling(this.Stats[5], 132, 10);

			//Vigor HP
			this.HP = ToolBox.Scaling(this.Stats[0], 100);

            //Vigor Fire Defenses
            this.Defenses[5] += ToolBox.Scaling(this.Stats[0], 133, 10);

            //Vigor Immunity
            this.Resistances[0] += ToolBox.Scaling(this.Stats[0], 120, 10);

            //Mind FP
            this.FP = ToolBox.Scaling(this.Stats[1], 101);

            //Mind Focus
            this.Resistances[2] += ToolBox.Scaling(this.Stats[1], 124, 10);

            //Endurance SP
            this.SP = ToolBox.Scaling(this.Stats[2], 104);

            //Endurance Robustness
            this.Resistances[1] += ToolBox.Scaling(this.Stats[2], 122, 10);

            //Endurance Equip Load
            this.EquipLoad = Math.Round((double)ToolBox.Scaling(this.Stats[2], 220, 100) / 10) / 10;

            //Arcane Holy Defenses
            this.Defenses[7] += ToolBox.Scaling(this.Stats[7], 135, 10);

            //Arcane Vitality
            this.Resistances[3] += ToolBox.Scaling(this.Stats[7], 126, 10);

			//Arcane Discovery ToolBox.Scaling
			this.Discovery = 100 + this.Stats[7];

			this.Defenses = this.Defenses.Select(Defenses => Defenses / 10).ToArray<int>();
			this.Resistances = this.Resistances.Select(resistance => resistance / 10).ToArray<int>();
		}
	}
}
