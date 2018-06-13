namespace BethanyPieShop.ViewModels
{
    using System.Collections.Generic;
    using BethanyPieShop.Models;

    public class HomeViewModel
    {
        public string Title { get; set; }

        public List<Pie> Pies { get; set; }
    }
}
