using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddCategoryViewModel
    {
        [Required]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

        // public CheeseType Type { get; set; }
        //
        // public List<SelectListItem> CheeseTypes { get; set; }
        //
        // public AddCheeseViewModel() {
        //
        //     CheeseTypes = new List<SelectListItem>();
        //
        //     // <option value="0">Hard</option>
        //     CheeseTypes.Add(new SelectListItem {
        //         Value = ((int) CheeseType.Hard).ToString(),
        //         Text = CheeseType.Hard.ToString()
        //     });
        //
        //     CheeseTypes.Add(new SelectListItem
        //     {
        //         Value = ((int)CheeseType.Soft).ToString(),
        //         Text = CheeseType.Soft.ToString()
        //     });
        //
        //     CheeseTypes.Add(new SelectListItem
        //     {
        //         Value = ((int)CheeseType.Fake).ToString(),
        //         Text = CheeseType.Fake.ToString()
        //     });
        //
        // }
    }
}
