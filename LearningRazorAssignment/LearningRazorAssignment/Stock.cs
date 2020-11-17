using System;
using System.Collections.Generic;

#nullable disable

namespace LearningRazorAssignment
{
    public partial class Stock
    {
        public int ProductId { get; set; }
        public int? Quantity { get; set; }

        public virtual Product Product { get; set; }
    }
}
