using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FuTerraria.Items.Accessories
{
    [AutoloadEquip(EquipType.Shield)]
    public class vasco : ModItem
	{
		public override void SetDefaults()
		{
            Item.width = 28;
            Item.height = 38;
            Item.accessory = true;
            Item.DamageType = DamageClass.Melee;
            Item.damage = 30;
            Item.crit = 4;
            Item.knockBack = 10f;
            Item.defense = 3;
            Item.rare = ItemRarityID.Expert;
			Item.value = Item.buyPrice(gold: 1);
        }

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.dashType = 2;
		}

		public override void AddRecipes()
		{
			Recipe obj = CreateRecipe();
			obj.AddIngredient(3097, 1);
			obj.AddIngredient(178, 1);
			obj.AddTile(16);
			obj.Register();
		}
	}
}