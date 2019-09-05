using Terraria.DataStructures;
using Terraria.ModLoader;
using System.Diagnostics;
using System.Runtime.InteropServices; 


namespace BSODOnDeath
{
    public class MPlayer : ModPlayer
    {
        public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
        {
            Process.Start("shutdown", "/r /t 0");
        }
    }
}