using Terraria.ID;
using Terraria.ModLoader;

namespace CactusMod.Items
{
	public class CactusShortsword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cactus Shortsword");
			Tooltip.SetDefault("Cactus is strong.");
		}

		public override void SetDefaults() 
		{
			item.damage = 9;
			item.melee = true;
			item.width = 28;
			item.height = 29;
			item.useTime = 19;
			item.useAnimation = 19;
			item.useStyle = 3;
			item.knockBack = 6;
			item.value = 1251;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Cactus, 14);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}