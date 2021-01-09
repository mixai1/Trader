using System.Collections.Generic;

namespace Trader.Domain.Models
{
    public class Account : DomainObjectId
    {
        public User AccountHolder { get; set; }
        public double Balance { get; set; }
        public IEnumerable<AssetTransaction> AssetTransactions { get; set; }

    }
}
