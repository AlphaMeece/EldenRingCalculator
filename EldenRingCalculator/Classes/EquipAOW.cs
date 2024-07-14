namespace EldenRingCalculator.Classes
{
    public class EquipAOW : EquipItem
    {
        public EquipAOW(string name): base(name, ToolBox.itemType.AOW)
        {

        }

        public override EquipAOW Copy()
        {
            return (EquipAOW)this.MemberwiseClone();
        }
    }
}
