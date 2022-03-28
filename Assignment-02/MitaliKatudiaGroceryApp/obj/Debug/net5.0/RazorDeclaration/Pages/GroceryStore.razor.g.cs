// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MitaliKatudiaGroceryApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Semester 2\ASP.Net\Mitali_Katudia_WEB315Assignments\Assignment-02\MitaliKatudiaGroceryApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Semester 2\ASP.Net\Mitali_Katudia_WEB315Assignments\Assignment-02\MitaliKatudiaGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Semester 2\ASP.Net\Mitali_Katudia_WEB315Assignments\Assignment-02\MitaliKatudiaGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Semester 2\ASP.Net\Mitali_Katudia_WEB315Assignments\Assignment-02\MitaliKatudiaGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Semester 2\ASP.Net\Mitali_Katudia_WEB315Assignments\Assignment-02\MitaliKatudiaGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Semester 2\ASP.Net\Mitali_Katudia_WEB315Assignments\Assignment-02\MitaliKatudiaGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Semester 2\ASP.Net\Mitali_Katudia_WEB315Assignments\Assignment-02\MitaliKatudiaGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Semester 2\ASP.Net\Mitali_Katudia_WEB315Assignments\Assignment-02\MitaliKatudiaGroceryApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Semester 2\ASP.Net\Mitali_Katudia_WEB315Assignments\Assignment-02\MitaliKatudiaGroceryApp\_Imports.razor"
using MitaliKatudiaGroceryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Semester 2\ASP.Net\Mitali_Katudia_WEB315Assignments\Assignment-02\MitaliKatudiaGroceryApp\_Imports.razor"
using MitaliKatudiaGroceryApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GroceryStore")]
    public partial class GroceryStore : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Semester 2\ASP.Net\Mitali_Katudia_WEB315Assignments\Assignment-02\MitaliKatudiaGroceryApp\Pages\GroceryStore.razor"
       

    private List<GroceryIsle> groceryIsle = new List<GroceryIsle>();
    private List<FoodItem> items = new List<FoodItem>();
    private string currentIsle = "";

    private void AddProducts()
    {
        //Console.Write("created");
        GroceryIsle isle1 = new GroceryIsle();
        isle1.isleNumber = 1;
        isle1.isleName = "Bakery";
        isle1.ItemList.Add(new FoodItem
        {
            Quantity = 1,
            ItemName = "Chocolate Cake",
            WeightInLb = "1 lb",
            ItemPrice = 25
        });
        isle1.ItemList.Add(new FoodItem
        {
            Quantity = 1,
            ItemName = "Pineapple Cake",
            WeightInLb = "1 lb",
            ItemPrice = 18
        });
        isle1.ItemList.Add(new FoodItem
        {
            Quantity = 1,
            ItemName = "Caramel Cake",
            WeightInLb = "1 lb",
            ItemPrice = 20
        });

        GroceryIsle isle2 = new GroceryIsle();
        isle2.isleNumber = 2;
        isle2.isleName = "Drinks";
        isle2.ItemList.Add(new FoodItem
        {
            Quantity = 6,
            ItemName = "Coca Cola",
            WeightInLb = "1/2 lb each Can",
            ItemPrice = 5.99
        });
        isle2.ItemList.Add(new FoodItem
        {
            Quantity = 6,
            ItemName = "Diet Coke",
            WeightInLb = "1/2 lb each Can",
            ItemPrice = 4.99
        });
        isle2.ItemList.Add(new FoodItem
        {
            Quantity = 6,
            ItemName = "Crush Orange",
            WeightInLb = "1/2 lb each Can",
            ItemPrice = 4.49
        });


        GroceryIsle isle3 = new GroceryIsle();
        isle3.isleName = "Snacks";
        isle3.isleNumber = 3;
        isle3.ItemList.Add(new FoodItem
        {
            Quantity = 1,
            ItemName = "Lays",
            WeightInLb = "1 lb",
            ItemPrice = 2.99
        });
        isle3.ItemList.Add(new FoodItem
        {
            Quantity = 6,
            ItemName = " Chocolate Cookies",
            WeightInLb = "1 lb",
            ItemPrice = 3.99
        });

        groceryIsle.Add(isle1);
        groceryIsle.Add(isle2);
        groceryIsle.Add(isle3);
    }

    private List<FoodItem> GetItems(int isleNumber)
    {
        foreach (var GroceryIsle in groceryIsle)
        {
            if (GroceryIsle.isleNumber == isleNumber)
            {
                currentIsle = GroceryIsle.isleName;
                return GroceryIsle.ItemList;
            }
        }
        return new List<FoodItem>();
    }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
