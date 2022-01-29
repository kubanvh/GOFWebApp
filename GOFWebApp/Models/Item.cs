using GOFWebApp.Models.GOFWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GOFWebApp.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter item name")]
        [DisplayName("Item name")]
        public string ItemName { get; set; }
        [Required(ErrorMessage = "Enter item type")]
        [DisplayName("Item type")]
        public string ItemType { get; set; }
        [Required(ErrorMessage = "Enter item size")]
        [DisplayName("Item size")]
        public string ItemSize { get; set; }
        [Required(ErrorMessage = "Enter item price")]
        [DisplayName("Item price")]
        public decimal ItemPrice { get; set; }
        public int? CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
