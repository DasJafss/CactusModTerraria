using Terraria.ID;
using Terraria.ModLoader;

namespace CactusMod.Items
{
	public class KenobiSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("General Kenobi's Lightsaber");
			Tooltip.SetDefault("Hello there");
		}

		public override void SetDefaults() 
		{
			item.damage = 420;
			item.melee = true;
			item.width = 28;
			item.height = 29;
			item.useTime = 19;
			item.useAnimation = 19;
			item.useStyle = 1;
			item.knockBack = 60;
			item.value = 1000000000000;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Cactus, 100);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}