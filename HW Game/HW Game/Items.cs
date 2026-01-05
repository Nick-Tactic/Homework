using HW_Game.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HW_Game
{
    internal interface IsWeapon
    {
        public WeaponType WeaponType { get; set; }
        public int Hands { get; set; }
        public int DamageModifyer { get; set; }
    }

    internal interface IsArmor
    {
        public ArmorType ArmorType { get; set; }
        public int ArmorModifyer { get; set; }
    }

    internal interface IsBulkBonus
    {
        public int BulkBonus { get; set; }
    }
    
    internal class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Bulk { get; set; } = 0;
        public int Price { get; set; } = 0;
        public Rarity Rarity { get; set; } = 0;

        public Item(string name, string description, int bulk, int price) { 
            Name = name;
            Description = description;
            Bulk = bulk;
            Price = price;
        }
    }

    internal class Weapon: Item, IsWeapon
    {
        public WeaponType WeaponType { get; set; } = 0;
        public int Hands { get; set; } = 1;
        public int DamageModifyer { get; set; } = 0;

        public Weapon(string name, string description, int bulk, int price, WeaponType weaponType, int hands, int damageModifyer) : base(name, description, bulk, price)
        {
            WeaponType = weaponType;
            Hands = hands;
            DamageModifyer = damageModifyer;
        }
    }

    internal class Armor : Item, IsArmor
    {
        public ArmorType ArmorType { get; set; } = 0;
        public int ArmorModifyer { get; set; } = 0;

        public Armor(string name, string description, int bulk, int price, ArmorType armorType, int armorModifyer) : base(name, description, bulk, price)
        {
            ArmorType = armorType;
            ArmorModifyer = armorModifyer;
        }
    }

    internal class Shield: Item, IsArmor, IsWeapon
    {
        public WeaponType WeaponType { get; set; } = 0;
        public int Hands { get; set; } = 1;
        public int DamageModifyer { get; set; } = 0;
        public ArmorType ArmorType { get; set; } = 0;
        public int ArmorModifyer { get; set; } = 0;

        public Shield(string name, string description, int bulk, int price, WeaponType weaponType, int hands, int damageModifyer, ArmorType armorType, int armorModifyer) : base(name, description, bulk, price)
        {
            WeaponType = weaponType;
            Hands = hands;
            DamageModifyer = damageModifyer;
            ArmorType = armorType;
            ArmorModifyer = armorModifyer;
        }
    }

    internal class Backpack : Item, IsBulkBonus
    {
        public int BulkBonus { get; set; } = 0;

        public Backpack(string name, string description, int bulk, int price, int bulkBonus) : base(name, description, bulk, price)
        {
            BulkBonus = bulkBonus;
        }
    }
}
