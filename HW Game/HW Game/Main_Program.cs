using HW_Game;
using HW_Game.Enums;
using System;
using System.Collections.Generic;

namespace HW_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random random = new Random();

            // --- Player creation ---
            Console.WriteLine("Введите имя вашего героя:");
            string name = Console.ReadLine();

            Character hero = new Character(name, 100);

            // --- Create some equipment ---
            Armor leatherArmor = new Armor(
                name: "Кожаная броня",
                description: "Лёгкая защита для начинающих героев.",
                bulk: 3,
                price: 50,
                armorType: ArmorType.Light,
                armorModifyer: 5
            );

            Weapon ironSword = new Weapon(
                name: "Железный меч",
                description: "Прочный меч для ближнего боя.",
                bulk: 4,
                price: 120,
                weaponType: WeaponType.Simple,
                hands: 1,
                damageModifyer: 7
            );

            Backpack smallBag = new Backpack(
                name: "Маленький рюкзак",
                description: "Увеличивает грузоподъёмность.",
                bulk: 2,
                price: 30,
                bulkBonus: 5
            );

            hero.ArmorSlot = leatherArmor;
            hero.Hands[0] = ironSword;
            hero.BackpackSlot = smallBag;

            Console.WriteLine($"\nСоздан герой: {hero.Name}");
            Console.WriteLine($"HP: {hero.HealthPoints}/{hero.MaxHealthPoints}");
            Console.WriteLine($"Оружие: {((Weapon)hero.Hands[0]).Name} (+{hero.GetWeaponDamageBonus()} урона)");
            Console.WriteLine($"Броня: {hero.ArmorSlot.Name} (+{hero.GetArmorBonus()} брони)");
            Console.WriteLine($"Рюкзак: {hero.BackpackSlot.Name} (+{hero.BackpackSlot.BulkBonus} вместимости)");
            Console.WriteLine();

            // --- Random enemy creation ---
            string[] enemyNames = { "Гоблин", "Орк", "Скелет", "Разбойник" };
            string enemyName = enemyNames[random.Next(enemyNames.Length)];
            int enemyHP = random.Next(60, 101);
            int enemyArmor = random.Next(2, 8);
            int enemyDamage = random.Next(2, 8);
            Rarity enemyRarity = (Rarity)random.Next(0, Enum.GetValues(typeof(Rarity)).Length);

            Enemy enemy = new Enemy(
                name: enemyName,
                maxHealthPoints: enemyHP,
                armorBonus: enemyArmor,
                damageBonus: enemyDamage,
                loot: new List<Item>(),
                rarity: enemyRarity
            );

            Console.WriteLine($"На пути героя появился враг: {enemyName} ({enemyRarity})");
            Console.WriteLine($"HP: {enemy.HealthPoints}/{enemy.MaxHealthPoints}");
            Console.WriteLine();

            // --- Battle ---
            Console.WriteLine("⚔️ Битва начинается!");

            int round = 1;
            while (hero.IsAlive() && enemy.IsAlive())
            {
                Console.WriteLine($"\n--- Раунд {round} ---");

                // Hero attacks
                int heroDamage = hero.DealDamage();
                enemy.TakeDamage(heroDamage);
                Console.WriteLine($"{hero.Name} наносит {heroDamage} урона!");
                Console.WriteLine($"{enemy.Name}: {enemy.HealthPoints}/{enemy.MaxHealthPoints} HP");

                if (!enemy.IsAlive())
                {
                    Console.WriteLine($"\n🏆 {hero.Name} победил врага {enemy.Name}!");
                    break;
                }

                // Enemy attacks
                int enemyDamageValue = enemy.DealDamage();
                hero.TakeDamage(enemyDamageValue);
                Console.WriteLine($"{enemy.Name} атакует и наносит {enemyDamageValue} урона!");
                Console.WriteLine($"{hero.Name}: {hero.HealthPoints}/{hero.MaxHealthPoints} HP");

                if (!hero.IsAlive())
                {
                    Console.WriteLine($"\n💀 Герой {hero.Name} пал в бою...");
                    break;
                }

                round++;
            }

            Console.WriteLine("\nБитва завершена!");
            Console.ReadKey();
        }
    }
}
