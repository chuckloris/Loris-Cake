using System; //what sources the code uses, these sources allow for calling of terraria functions, existing system functions and microsoft vector functions (probably more)
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LorisCake.Items.Ammo //where it's stored, replace Mod with the name of your mod. This file is stored in the folder \Mod Sources\(mod name, folder can't have spaces)\Projectiles.
{
    public class EndlessIchorPouch : ModItem //the class of the projectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Ichor Pouch");
            Tooltip.SetDefault("Much better like this :)");
        }

        public override void SetDefaults()
        {
            item.damage = 13; //how much additional damage your ammo does
            // item.crit = 5; // Pas toucher
            item.ranged = true;
            item.width = 2;
            item.height = 20;

            item.maxStack = 1; //how much fit in one inventory slot
            item.consumable = false; //makes it so the bullet is used on shooting. Delete this if you want an endless ammo pouch

            item.knockBack = 4f; //how much additional knockback your bullet does.
            item.value = 50000; //if value is just a number, it's the sell price in copper coins. This is worth 10 copper. Every 100 means it sells for a silver, every 10000 means gold, and every 1000000 means platinum
            item.rare = 3;
            item.shoot = ProjectileID.IchorBullet;
                // mod.ProjectileType("WoodenBullet"); //IMPORTANT! Make sure you have a projectile for your ammo and this shoots it
            // https://terraria.fandom.com/wiki/Projectile_IDs
            item.shootSpeed = 5.25f; //how much additional velocity it applies to the projectile
            item.ammo = AmmoID.Bullet; //IMPORTANT! This makes the item ammo of the according type. Common ammo types include AmmoID.Arrow, AmmoID.Bullet, and AmmoID.Rocket

        
            // Ce sont des trucs à mettre dans projectiles, pas item :
            // projectile.aiStyle = 0; //projectile moves in a straight line
            // projectile.friendly = true; //player projectile
            // projectile.ranged = true; //ranged projectile

            // projectile.timeLeft = 600; //lasts for 600 frames/ticks. Terraria runs at 60FPS, so it lasts 10 seconds.
            // aiType = ProjectileID.Bullet; //This clones the exact AI of the vanilla projectile Bullet.
        }

        //public override void Kill(int timeLeft)
        //{
        //    Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height);
        //    Main.PlaySound(SoundID.Item10, projectile.position);
        //}

        //public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        //{
        //    target.AddBuff(mod.BuffType(69, 600, false)); // Ichor debuff pendant 10 secondes
        //}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(1335, 3996); //crafted with 3996 ichor bullets
            // https://terraria.fandom.com/wiki/Item_IDs
            recipe.AddTile(125); //crafted at Tile 125, Crystall Ball
            // https://terraria.fandom.com/wiki/Tile_IDs
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}