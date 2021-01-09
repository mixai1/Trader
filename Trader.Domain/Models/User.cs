namespace Trader.Domain.Models
{
    public class User : DomainObjectId
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
