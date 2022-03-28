public class FoodItem
{
    public int Quantity { get; set; }
    public string ItemName { get; set; }
    public string WeightInLb { get; set; }
    public double ItemPrice { get; set; }

    public void IncreaseQuantity()
    {
        if(Quantity<20)
            Quantity++;
    }

    public void DescreaseQuantity()
    {
        if(Quantity>0)
            Quantity--;
    }

}