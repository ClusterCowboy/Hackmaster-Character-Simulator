using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Armor.ArmorCatalog;
using static GenericEnums.GenericEnums;
using Universals;

namespace Armor
{
    public enum ShieldType
    {
        Buckler,
        SpikedBuckler,
        Small,
        Medium,
        Body
    }

    public class Shield : IWeight, IItemName, IMoney
    {
        public double Weight { get; set; }
        public string ItemName { get; set; }
        public int MaxAC { get; set; }
        public int CurrentAC { get; set; }
        // AC, points left
        public Dictionary<int, int> ShieldHPRemaining { get; set; }
        public Dictionary<int, int> ShieldHPWhenUndamaged { get; set; }
        public ShieldType ShieldType { get; set; }
        public ItemBulk Bulk { get; set; }
        public double Value { get; set; }
    }
}
