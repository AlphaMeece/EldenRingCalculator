

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
			Defenses = [ 50, 50, 50, 50, 63, 54, 45, 67 ];
			Resistances = [ 77, 77, 77, 77 ];

			SelectedSlot = "Right Hand Armament 1";
			SelectedItem = ItemTable.Weapons.None;
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
			if (this.Level == 1)
			{
				Array.Fill(this.Defenses, 400);
			}
			else if (this.Level < 70)
			{
				Array.Fill(this.Defenses, ToolBox.Scaling(this.Level, 70, 1, 1, 400, 1000));
			}
			else if (this.Level < 90)
			{
				Array.Fill(this.Defenses, ToolBox.Scaling(this.Level, 90, 70, 1, 1000, 1200));
			}
			else if (this.Level < 160)
			{
				Array.Fill(this.Defenses, ToolBox.Scaling(this.Level, 160, 90, 1, 1200, 1350));
			}
			else
			{
				Array.Fill(this.Defenses, ToolBox.Scaling(this.Level, 712, 160, 1, 1350, 1550));
			}

			//Level Resistances
			if (this.Level == 1)
			{
				Array.Fill(this.Resistances, 750);
			}
			else if (this.Level < 70)
			{
				Array.Fill(this.Resistances, ToolBox.Scaling(this.Level, 70, 1, 1, 750, 1050));
			}
			else if (this.Level < 90)
			{
				Array.Fill(this.Resistances, ToolBox.Scaling(this.Level, 90, 70, 1, 1050, 1450));
			}
			else if (this.Level < 160)
			{
				Array.Fill(this.Resistances, ToolBox.Scaling(this.Level, 160, 90, 1, 1450, 1600));
			}
			else
			{
				Array.Fill(this.Resistances, ToolBox.Scaling(this.Level, 712, 160, 1, 1600, 1800));
			}

			//Strength Physical Defenses
			if (this.Stats[3] == 1)
			{
				this.Defenses[0] += 0;
				this.Defenses[1] += 0;
				this.Defenses[2] += 0;
				this.Defenses[3] += 0;
			}
			else if (this.Stats[3] < 30)
			{
				this.Defenses[0] += ToolBox.Scaling(this.Stats[3], 30, 0, 1, 0, 100);
				this.Defenses[1] += ToolBox.Scaling(this.Stats[3], 30, 0, 1, 0, 100);
				this.Defenses[2] += ToolBox.Scaling(this.Stats[3], 30, 0, 1, 0, 100);
				this.Defenses[3] += ToolBox.Scaling(this.Stats[3], 30, 0, 1, 0, 100);
			}
			else if (this.Stats[3] < 40)
			{
				this.Defenses[0] += ToolBox.Scaling(this.Stats[3], 40, 30, 1, 100, 150);
				this.Defenses[1] += ToolBox.Scaling(this.Stats[3], 40, 30, 1, 100, 150);
				this.Defenses[2] += ToolBox.Scaling(this.Stats[3], 40, 30, 1, 100, 150);
				this.Defenses[3] += ToolBox.Scaling(this.Stats[3], 40, 30, 1, 100, 150);
			}
			else if (this.Stats[3] < 60)
			{
				this.Defenses[0] += ToolBox.Scaling(this.Stats[3], 60, 40, 1, 150, 300);
				this.Defenses[1] += ToolBox.Scaling(this.Stats[3], 60, 40, 1, 150, 300);
				this.Defenses[2] += ToolBox.Scaling(this.Stats[3], 60, 40, 1, 150, 300);
				this.Defenses[3] += ToolBox.Scaling(this.Stats[3], 60, 40, 1, 150, 300);
			}
			else
			{
				this.Defenses[0] += ToolBox.Scaling(this.Stats[3], 99, 60, 1, 300, 400);
				this.Defenses[1] += ToolBox.Scaling(this.Stats[3], 99, 60, 1, 300, 400);
				this.Defenses[2] += ToolBox.Scaling(this.Stats[3], 99, 60, 1, 300, 400);
				this.Defenses[3] += ToolBox.Scaling(this.Stats[3], 99, 60, 1, 300, 400);
			}

			//Intelligence Magic Defenses
			if (this.Stats[4] == 0)
			{
				this.Defenses[4] += 0;
			}
			else if (this.Stats[4] < 20)
			{
				this.Defenses[4] += ToolBox.Scaling(this.Stats[4], 20, 0, 1, 0, 400);
			}
			else if (this.Stats[4] < 35)
			{
				this.Defenses[4] += ToolBox.Scaling(this.Stats[4], 35, 20, 1, 400, 500);
			}
			else if (this.Stats[4] < 60)
			{
				this.Defenses[4] += ToolBox.Scaling(this.Stats[4], 60, 35, 1, 500, 600);
			}
			else
			{
				this.Defenses[4] += ToolBox.Scaling(this.Stats[4], 99, 60, 1, 600, 700);
			}

			//Vigor HP ToolBox.Scaling
			if (this.Stats[0] == 1)
			{
				this.HP = 300;
			}
			else if (this.Stats[0] < 25)
			{
				this.HP = ToolBox.Scaling(this.Stats[0], 25, 1, 1.5, 300, 800);
			}
			else if (this.Stats[0] < 40)
			{
				this.HP = ToolBox.Scaling(this.Stats[0], 40, 25, 1.1, 800, 1450);
			}
			else if (this.Stats[0] < 60)
			{
				this.HP = ToolBox.Scaling(this.Stats[0], 60, 40, -1.2, 1450, 1900);
			}
			else
			{
				this.HP = ToolBox.Scaling(this.Stats[0], 99, 60, -1.2, 1900, 2100);
			}

			//Vigor Fire Defenses
			if (this.Stats[0] == 0)
			{
				this.Defenses[5] += 0;
			}
			else if (this.Stats[0] < 30)
			{
				this.Defenses[5] += ToolBox.Scaling(this.Stats[0], 30, 0, 1, 0, 200);
			}
			else if (this.Stats[0] < 40)
			{
				this.Defenses[5] += ToolBox.Scaling(this.Stats[0], 40, 30, 1, 200, 400);
			}
			else if (this.Stats[0] < 60)
			{
				this.Defenses[5] += ToolBox.Scaling(this.Stats[0], 60, 40, 1, 400, 600);
			}
			else
			{
				this.Defenses[5] += ToolBox.Scaling(this.Stats[0], 99, 60, 1, 600, 700);
			}

			//Vigor Immunity
			if (this.Stats[0] == 0)
			{
				this.Resistances[0] += 0;
			}
			else if (this.Stats[0] < 30)
			{
				this.Resistances[0] += 0;
			}
			else if (this.Stats[0] < 40)
			{
				this.Resistances[0] += ToolBox.Scaling(this.Stats[0], 40, 30, 1, 0, 300);
			}
			else if (this.Stats[0] < 60)
			{
				this.Resistances[0] += ToolBox.Scaling(this.Stats[0], 60, 40, 1, 300, 400);
			}
			else
			{
				this.Resistances[0] += ToolBox.Scaling(this.Stats[0], 99, 60, 1, 400, 500);
			}

			//Mind FP ToolBox.Scaling
			if (this.Stats[1] == 1)
			{
				this.FP = 50;
			}
			else if (this.Stats[1] < 15)
			{
				this.FP = ToolBox.Scaling(this.Stats[1], 15, 1, 1, 50, 95);
			}
			else if (this.Stats[1] < 35)
			{
				this.FP = ToolBox.Scaling(this.Stats[1], 35, 15, 1, 95, 200);
			}
			else if (this.Stats[1] < 60)
			{
				this.FP = ToolBox.Scaling(this.Stats[1], 60, 35, -1.2, 200, 350);
			}
			else
			{
				this.FP = ToolBox.Scaling(this.Stats[1], 99, 60, 1, 350, 450);
			}

			//Mind Focus
			if (this.Stats[1] == 0)
			{
				this.Resistances[2] += 0;
			}
			else if (this.Stats[1] < 30)
			{
				this.Resistances[2] += 0;
			}
			else if (this.Stats[1] < 40)
			{
				this.Resistances[2] += ToolBox.Scaling(this.Stats[1], 40, 30, 1, 0, 300);
			}
			else if (this.Stats[1] < 60)
			{
				this.Resistances[2] += ToolBox.Scaling(this.Stats[1], 60, 40, 1, 300, 400);
			}
			else
			{
				this.Resistances[2] += ToolBox.Scaling(this.Stats[1], 99, 60, 1, 400, 500);
			}

			//Endurance SP ToolBox.Scaling
			if (this.Stats[2] == 1)
			{
				this.SP = 80;
			}
			else if (this.Stats[2] < 15)
			{
				this.SP = ToolBox.Scaling(this.Stats[2], 15, 1, 1, 80, 105);
			}
			else if (this.Stats[2] < 30)
			{
				this.SP = ToolBox.Scaling(this.Stats[2], 30, 15, 1, 105, 130);
			}
			else if (this.Stats[2] < 50)
			{
				this.SP = ToolBox.Scaling(this.Stats[2], 50, 30, 1, 130, 155);
			}
			else
			{
				this.SP = ToolBox.Scaling(this.Stats[2], 99, 50, 1, 155, 170);
			}

			//Endurance Robustness
			if (this.Stats[2] == 0)
			{
				this.Resistances[1] += 0;
			}
			else if (this.Stats[2] < 30)
			{
				this.Resistances[1] += 0;
			}
			else if (this.Stats[2] < 40)
			{
				this.Resistances[1] += ToolBox.Scaling(this.Stats[2], 40, 30, 1, 0, 300);
			}
			else if (this.Stats[2] < 60)
			{
				this.Resistances[1] += ToolBox.Scaling(this.Stats[2], 60, 40, 1, 300, 400);
			}
			else
			{
				this.Resistances[1] += ToolBox.Scaling(this.Stats[2], 99, 60, 1, 400, 500);
			}

			//Equip Load ToolBox.Scaling
			if (this.Stats[2] == 1)
			{
				this.EquipLoad = 45;
			}
			else if (this.Stats[2] < 8)
			{
				this.EquipLoad = 45;
			}
			else if (this.Stats[2] < 25)
			{
				this.EquipLoad = Math.Round((double)ToolBox.Scaling(this.Stats[2], 25, 8, 1, 4500, 7200) / 10) / 10;
			}
			else if (this.Stats[2] < 60)
			{
				this.EquipLoad = Math.Round((double)ToolBox.Scaling(this.Stats[2], 60, 25, 1.1, 7200, 12000) / 10) / 10;
			}
			else
			{
				this.EquipLoad = Math.Round((double)ToolBox.Scaling(this.Stats[2], 99, 60, 1, 12000, 16000) / 10) / 10;
			}

			//Arcane Holy Defenses
			if (this.Stats[7] == 0)
			{
				this.Defenses[7] += 0;
			}
			else if (this.Stats[7] < 20)
			{
				this.Defenses[7] += ToolBox.Scaling(this.Stats[7], 20, 0, 1, 0, 400);
			}
			else if (this.Stats[7] < 35)
			{
				this.Defenses[7] += ToolBox.Scaling(this.Stats[7], 35, 20, 1, 400, 500);
			}
			else if (this.Stats[7] < 60)
			{
				this.Defenses[7] += ToolBox.Scaling(this.Stats[7], 60, 35, 1, 500, 600);
			}
			else
			{
				this.Defenses[7] += ToolBox.Scaling(this.Stats[7], 99, 60, 1, 600, 700);
			}

			//Arcane Vitality
			if (this.Stats[7] == 0)
			{
				this.Resistances[3] += 0;
			}
			else if (this.Stats[7] < 15)
			{
				this.Resistances[3] += ToolBox.Scaling(this.Stats[7], 15, 0, 0, 0, 150); ;
			}
			else if (this.Stats[7] < 40)
			{
				this.Resistances[3] += ToolBox.Scaling(this.Stats[7], 40, 15, 1, 150, 300);
			}
			else if (this.Stats[7] < 60)
			{
				this.Resistances[3] += ToolBox.Scaling(this.Stats[7], 60, 40, 1, 300, 400);
			}
			else
			{
				this.Resistances[3] += ToolBox.Scaling(this.Stats[7], 99, 60, 1, 400, 500);
			}

			//Arcane Discovery ToolBox.Scaling
			this.Discovery = 100 + this.Stats[7];

			this.Defenses = this.Defenses.Select(Defenses => Defenses / 10).ToArray<int>();
			this.Resistances = this.Resistances.Select(resistance => resistance / 10).ToArray<int>();
		}
	}
}
