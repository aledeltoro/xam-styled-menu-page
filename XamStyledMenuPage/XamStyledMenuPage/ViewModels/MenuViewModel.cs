using System;
using System.Collections.Generic;
using System.Text;
using XamStyledMenuPage.Models;

namespace XamStyledMenuPage.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public MenuOption BarAndHotelsOption { get; }
        public MenuOption FineDiningOption { get; }
        public MenuOption CafesOption { get; }
        public MenuOption NearbyOption { get; }
        public MenuOption FastFoodsOption { get; }
        public MenuOption FeaturedFoodsOption { get; }

        public MenuViewModel()
        {
            BarAndHotelsOption = new MenuOption("Bar & Hotels", "42 Places", "outline_sports_bar_black_48.png");
            FineDiningOption = new MenuOption("Fine Dining", "15 Places", "outline_restaurant_black_48.png");
            CafesOption = new MenuOption("Cafes", "28 Places", "outline_storefront_black_48.png");
            NearbyOption = new MenuOption("Nearby", "34 Places", "outline_place_black_48.png");
            FastFoodsOption = new MenuOption("Fast Foods", "29 Places", "outline_fastfood_black_48.png");
            FeaturedFoodsOption = new MenuOption("Featured Foods", "21 Places", "outline_local_pizza_black_48.png");
        }
    }
}
