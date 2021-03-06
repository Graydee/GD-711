using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Auralite;

namespace Auralite.Projectiles
{
    public class AuraWatchEffectProj : GlobalProjectile
    {
        public override bool PreAI(Projectile projectile)
        {
            Player player = Main.player[Main.myPlayer];
            AuralitePlayer modPlayer = player.GetModPlayer<AuralitePlayer>(mod);
            if (modPlayer.auraWatch)
            {
                if (player.HasBuff(mod.BuffType("StolenTime")) >= 0)
                {
                    projectile.velocity *= 0;
                    return false;
                }
            }
                return base.PreAI(projectile);
            }
        }
    
}