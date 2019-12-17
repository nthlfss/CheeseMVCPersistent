using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddMenuItemViewModel
    {
        public int cheeseID { get; set; }
        public int menuID { get; set; }

        public Menu Menu { get; set; }
        public List<SelectListItem> Cheeses { get; set; } = new List<SelectListItem>();


        public AddMenuItemViewModel() { }

        public AddMenuItemViewModel(Menu menu, IEnumerable<Cheese> cheeses) 
        {
            Cheeses = new List<SelectListItem>();

            foreach (var field in cheeses)
            {
                Cheeses.Add(new SelectListItem
                {
                    Value = field.ID.ToString(),
                    Text = field.Name
                });
            }

            Menu = menu;
        }
    }
}
