namespace Mango.Web.Models
{
    public class CouponDto
    {
        public int CouponId { get; set; }
        public string? CouponCode { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }

        public static implicit operator string(CouponDto v)
        {
            throw new NotImplementedException();
        }
    }
}
