using System;

namespace Trader.Domain.Models
{
    public class AssetTransaction : DomainObjectId
    {
        public Account Account { get; set; }
        public bool IsPurchase { get; set; }
        public Stock Stock { get; set; }
        public int Shares { get; set; }
        public DateTime DateProcessed { get; set; }
    }
}
