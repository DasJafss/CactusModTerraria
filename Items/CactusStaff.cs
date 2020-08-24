using CactusMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CactusMod.Items
{
	public class CactusStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cactus Staff");
			Tooltip.SetDefault("Cactus is magical.");
		}

		public override void SetDefaults()
		{
			item.useStyle = 3;
			item.width = 36;
			item.height = 36;
			item.useAnimation = 10;
			item.useTime = 10;
			item.damage = 7;
			item.rare = 0;
			item.noMelee = true;
			item.channel = true;
			item.magic = true;
			item.UseSound = SoundID.Item1;
			item.mana = 10;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<CactusStaffProjectile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Cactus, 18);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}