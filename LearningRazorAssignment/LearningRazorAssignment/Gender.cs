using System;
using System.Collections.Generic;

#nullable disable

namespace LearningRazorAssignment
{
    public partial class Gender
    {
        public Gender()
        {
            Products = new HashSet<Product>();
        }

        public int GenderId { get; set; }
        public string GenderName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
