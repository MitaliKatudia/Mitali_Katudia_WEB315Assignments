using System.Collections.Generic;

public class GroceryIsle
{
    public List<FoodItem> ItemList{ get; set; }
    public int isleNumber { get; set; }
    public string isleName { get; set; }

    public GroceryIsle()
    {
        ItemList=new List<FoodItem>();
    }

    public void AddFoodItem(FoodItem foodItem)
    {
        ItemList.Add(foodItem);
    }


}






    