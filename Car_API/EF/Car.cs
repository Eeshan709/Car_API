using System;
using System.Collections.Generic;

#nullable disable

namespace Car_API.EF
{
    public partial class Car
    {
        public int CarId { get; set; }
        public int UserId { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int Year { get; set; }
        public int BodyTypeId { get; set; }
        public string Description { get; set; }
    }
}
