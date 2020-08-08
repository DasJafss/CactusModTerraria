using CactusMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CactusMod.Items
{
	public class CactusYoyo : ModItem
	{
		public override void SetStaticDefaults()
		{
           		DisplayName.SetDefault("Cactus Yoyo");
            		Tooltip.SetDefault("Cactus is mighty.");

			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.width = 30;
			item.height = 26;
			item.useAnimation = 25;
			item.useTime = 4;
			item.shootSpeed = 16f;
			item.knockBack = 5;
			item.damage = 12;
			item.rare = 0;
			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.UseSound = SoundID.Item1;
			item.shoot = ModContent.ProjectileType<CactusYoyoProjectile>();
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Cactus, 21);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
