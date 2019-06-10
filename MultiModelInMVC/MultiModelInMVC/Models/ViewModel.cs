using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiModelInMVC.Models
{
    public class ViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Supplier> Suppliers { get; set; }
    }
}