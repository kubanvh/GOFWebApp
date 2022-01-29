using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GOFWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace GOFWebApp.Models
    {
        public class Category
        {
            public int CategoryID { get; set; }
            public string CategoryName { get; set; }
            //public string Description { get; set; }
            public ICollection<Item> Items { get; set; }
        }
    }

}
