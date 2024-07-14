namespace EldenRingCalculator.Classes
{
    public static class ItemTable
    {
        public static Dictionary<string, EquipAOW> SwordArts = new Dictionary<string, EquipAOW>()
        {
            { "None", new EquipAOW("None") },
            { "Kick", new EquipAOW("Kick") }
        };

        public static Dictionary<string, EquipWeapon> Weapons = new Dictionary<string, EquipWeapon>()
        {
            { "None", new EquipWeapon("None", null, ToolBox.weaponCategory.None, false, true, ToolBox.reinforceType.None, false, [], [], []) },
            { "Unarmed", new EquipWeapon("Unarmed", SwordArts["Kick"], ToolBox.weaponCategory.Fist, false, true, ToolBox.reinforceType.None, false, [ 0, 0, 0, 0, 0 ], [ 20, 0, 0, 0, 0, 10, 1 ], [ 50, 50, 0, 0, 0 ]) }
        };

        public static Dictionary<string, EquipTalisman> Talismans = new Dictionary<string, EquipTalisman>()
        {
            { "None", new EquipTalisman("None") }
        };

        public static Dictionary<string, EquipMagic> Magic = new Dictionary<string, EquipMagic>()
        {
            { "None", new EquipMagic("None") }
        };
    }
}
