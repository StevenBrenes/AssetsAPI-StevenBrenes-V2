using System;
using System.Collections.Generic;

namespace AssetsAPI_StevenBrenes_V2.Models
{
    public partial class Asset
    {
        public int IdAsset { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public int Cost { get; set; }
    }
}
