using System;
using System.Collections.Generic;

#nullable disable

namespace Car_API.EF
{
    public partial class Picture
    {
        public int PictureId { get; set; }
        public int CarId { get; set; }
        public string Path { get; set; }
    }
}
