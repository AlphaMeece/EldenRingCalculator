namespace EldenRingCalculator.Classes
{
	public class EquipTalisman : EquipItem
	{
		public EquipTalisman(string name) : base(name, ToolBox.itemType.Talisman)
		{

		}

        public override EquipTalisman Copy()
        {
            return (EquipTalisman)this.MemberwiseClone();
        }
    }
}
