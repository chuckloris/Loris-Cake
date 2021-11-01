using System; //what sources the code uses, these sources allow for calling of terraria functions, existing system functions and microsoft vector functions (probably more)
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LorisCake
{
    class LorisCake : Mod
    {
        public LorisCake()
        {
            // Make sure Autoload is true, it saves a lot of code in the Load() hook
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
        public override void AddRecipes()
        {

        }
    }
}