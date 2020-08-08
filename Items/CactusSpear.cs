using CactusMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CactusMod.Items
{
	public class CactusSpear : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Cactus Spear");
			Tooltip.SetDefault("Cactus is ferocious.");
		}

		public override void SetDefaults() {
			item.damage = 12;
			item.useStyle = 5;
			item.useAnimation = 18;
			item.useTime = 24;
			item.shootSpeed = 3f;
			item.knockBack = 8;
			item.width = 36;
			item.height = 36;
			item.rare = 0;
			item.value = 1100;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.autoReuse = true;
			item.UseSound = SoundID.Item1;
			item.shoot = ProjectileType<CactusSpearProjectile>();
		}

		public override bool CanUseItem(Player player) {
			return player.ownedProjectileCounts[item.shoot] < 1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Cactus, 15);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}