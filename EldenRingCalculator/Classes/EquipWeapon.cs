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

        public EquipWeapon(
            string name,
            EquipAOW defaultAOW,
            ToolBox.weaponCategory category,
            bool upgradable,
            bool smithingWeapon,
            ToolBox.reinforceType reinforce,
            bool changeReinforce,
            int[] requirements,
            double[] baseDamage,
            int[] baseScaling
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
    }
}
