using HW_Game.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Game
{
    internal interface IDamageable
    {
        int DealDamage(int bonusDamage = 0);
        void TakeDamage(int damageDealt, int bonusArmor = 0);
    }

    internal abstract class Creature
    {
        public string Name { get; set; }
        public int MaxHealthPoints { get; set; } = 100;
        public int HealthPoints { get; set; }
        protected const int BaseDamage = 10;
        protected const int BaseArmor = 10;

        protected Creature (string name, int maxHealthPoints)
        {
            Name = name;
            MaxHealthPoints = maxHealthPoints;
            HealthPoints = MaxHealthPoints;
        }

        // Deal damage: 1d20 + base damage + bonus damage
        public int DealDamage(int bonusDamage = 0)
        {
            Random random = new Random();
            int diceRoll = random.Next(1, 21); // 1d20
            int totalDamage = diceRoll + BaseDamage + bonusDamage;
            return totalDamage;
        }

        // Take damage: damage dealt - armor - bonus armor
        public void TakeDamage(int damageDealt, int bonusArmor = 0)
        {
            int damageReduction = BaseArmor + bonusArmor;
            int actualDamage = Math.Max(0, damageDealt - damageReduction); // Ensure damage is never negative
            HealthPoints = Math.Max(0, HealthPoints - actualDamage); // Ensure health doesn't go below 0
        }

        // Check if creature is alive
        public bool IsAlive()
        {
            return HealthPoints > 0;
        }
    }

    internal class Character : Creature, IDamageable
    {
        public int BulkLimit { get; set; } = 10;
        
        // Inventory slots
        public Armor? ArmorSlot { get; set; } = null;
        public Backpack? BackpackSlot { get; set; } = null;
        
        // Hand management - array with constraints
        public Item?[] Hands { get; set; } = new Item?[2];  // Fixed array of 2 hands
        private const int MaxHands = 2;      // Maximum total hands used
        
        // Inventory list
        public List<Item> Inventory { get; set; } = new List<Item>();

        public Character(string name, int maxHealthPoints) : base(name, maxHealthPoints)
        {
        }

        // Try to add item to inventory
        public bool TryAddToInventory(Item item)
        {
            // Calculate current inventory bulk
            int currentBulk = Inventory.Sum(i => i.Bulk);
            
            // Calculate total bulk limit (base + backpack bonus)
            int totalBulkLimit = BulkLimit;
            if (BackpackSlot != null)
            {
                totalBulkLimit += BackpackSlot.BulkBonus;
            }
            
            // Check if adding the item would exceed the limit
            if (currentBulk + item.Bulk <= totalBulkLimit)
            {
                Inventory.Add(item);
                return true;
            }
            
            return false;
        }

        // Calculate total damage bonus from weapons in hands
        public int GetWeaponDamageBonus()
        {
            int totalBonus = 0;
            foreach (var item in Hands)
            {
                if (item is IsWeapon weapon)
                {
                    totalBonus += weapon.DamageModifyer;
                }
            }
            return totalBonus;
        }

        // Calculate total armor bonus from armor and shields
        public int GetArmorBonus()
        {
            int totalArmor = 0;
            
            // Add armor bonus
            if (ArmorSlot != null)
            {
                totalArmor += ArmorSlot.ArmorModifyer;
            }
            
            // Add shield armor bonus
            foreach (var item in Hands)
            {
                if (item is IsArmor armor)
                {
                    totalArmor += armor.ArmorModifyer;
                }
            }
            
            return totalArmor;
        }

        // Implement DealDamage to include weapon bonuses
        public int DealDamage(int bonusDamage = 0)
        {
            Random random = new Random();
            int diceRoll = random.Next(1, 21); // 1d20
            int weaponBonus = GetWeaponDamageBonus();
            int totalDamage = diceRoll + BaseDamage + weaponBonus + bonusDamage;
            return totalDamage;
        }

        // Implement TakeDamage to include armor bonuses
        public void TakeDamage(int damageDealt, int bonusArmor = 0)
        {
            int armorBonus = GetArmorBonus();
            int damageReduction = BaseArmor + armorBonus + bonusArmor;
            int actualDamage = Math.Max(0, damageDealt - damageReduction); // Ensure damage is never negative
            HealthPoints = Math.Max(0, HealthPoints - actualDamage); // Ensure health doesn't go below 0
        }

        // Get total carrying capacity (base + backpack bonus)
        public int GetTotalCarryingCapacity()
        {
            int totalCapacity = BulkLimit;
            if (BackpackSlot != null)
            {
                totalCapacity += BackpackSlot.BulkBonus;
            }
            return totalCapacity;
        }

        // Get current inventory bulk
        public int GetCurrentInventoryBulk()
        {
            return Inventory.Sum(i => i.Bulk);
        }

        // Check if inventory has space for an item
        public bool CanCarryItem(Item item)
        {
            return GetCurrentInventoryBulk() + item.Bulk <= GetTotalCarryingCapacity();
        }
    }

    internal class Enemy : Creature, IDamageable
    {
        public List<Item> Loot { get; set; } = new List<Item>();
        private int ArmorBonus = 0;
        private int DamageBonus = 0;
        private Rarity Rarity = 0;

        public Enemy(string name, int maxHealthPoints, int armorBonus, int damageBonus, List<Item> loot, Rarity rarity) : base(name, maxHealthPoints)
        {
            ArmorBonus = armorBonus;
            DamageBonus = damageBonus;
            Loot = loot;
            Rarity = rarity;
        }

        public int DealDamage(int bonusDamage = 0)
        {
            Random random = new Random();
            int diceRoll = random.Next(1, 21); // 1d20
            int totalDamage = diceRoll + BaseDamage + DamageBonus + bonusDamage;
            return totalDamage;
        }

        // Implement TakeDamage to include armor bonuses
        public void TakeDamage(int damageDealt, int bonusArmor = 0)
        {
            int damageReduction = BaseArmor + ArmorBonus;
            int actualDamage = Math.Max(0, damageDealt - damageReduction); // Ensure damage is never negative
            HealthPoints = Math.Max(0, HealthPoints - actualDamage); // Ensure health doesn't go below 0
        }
    }
}
