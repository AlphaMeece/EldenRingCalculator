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
	}
}
