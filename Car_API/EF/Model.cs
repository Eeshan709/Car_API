using System;
using System.Collections.Generic;

#nullable disable

namespace Car_API.EF
{
    public partial class Model
    {
        public int ModelId { get; set; }
        public int MakeId { get; set; }
        public string ModelName { get; set; }
    }
}
