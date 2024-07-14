namespace EldenRingCalculator.Classes
{
    public class EquipWeapon : EquipItem
    {
        public EquipAOW AOW;
        public ToolBox.weaponCategory Category;
        public bool Upgradable;
        public bool SmithingWeapon;
        public ToolBox.reinforceType Reinforce;
        public bool CanChangeReinforce;
        public int[] StatRequirements;
        public double[] BaseDamage;
        public int[] BaseScaling;
        public int[][] ModifiedScalings = [];

        public EquipWeapon(
            string name,
            EquipAOW defaultAOW,
            ToolBox.weaponCategory category,
            bool upgradable,
            bool smithingWeapon,
            ToolBox.reinforceType reinforce,
            bool changeReinforce,
            int[] requirements,
            double[] baseDamage, // Physical, Magic, Fire, Lightning, Holy, Stamina, Poise
            int[] baseScaling //Strength, Dexterity, Intelligence, Faith, Arcane
            ) : base(name, ToolBox.itemType.Weapon)
        {
            AOW = defaultAOW;
            Category = category;
            Upgradable = upgradable;
            SmithingWeapon = smithingWeapon;
            Reinforce = reinforce;
            CanChangeReinforce = changeReinforce;
            StatRequirements = requirements;
            BaseDamage = baseDamage;
            BaseScaling = baseScaling;
        }

        public override EquipWeapon Copy()
        {
            return (EquipWeapon)this.MemberwiseClone();
        }
    }
}
