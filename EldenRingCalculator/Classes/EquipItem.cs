using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace EldenRingCalculator.Classes
{
	public class EquipItem
	{
		public ToolBox.itemType ItemType;
		public string Name;
		
		public EquipItem(string name, ToolBox.itemType type)
		{
			Name = name;
			ItemType = type;
		}

		public virtual EquipItem Copy()
		{
			return (EquipItem)this.MemberwiseClone();
		}
	}
}
