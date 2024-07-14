namespace EldenRingCalculator.Classes
{
	public class EquipMagic : EquipItem
	{
		public EquipMagic(string name): base(name, ToolBox.itemType.Magic)
		{

		}

        public override EquipMagic Copy()
        {
            return (EquipMagic)this.MemberwiseClone();
        }
    }
}
