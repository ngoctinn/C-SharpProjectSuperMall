using System;

namespace Models
{
    public class Discount
    {
        private static int s_autoId = 1000000;
        public int DiscountId { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string DiscounType { get; set; }
        public int DiscountPriceAmount { get; set; }
        public int DiscountPercent { get; set; }

        public Discount()        {        }

        public Discount(int discountId, string name, DateTime startTime, 
            DateTime endTime, string discounType, int discountPriceAmount, int discountPercent)
        {
            DiscountId = discountId;
            Name = name;
            StartTime = startTime;
            EndTime = endTime;
            DiscounType = discounType;
            DiscountPriceAmount = discountPriceAmount;
            DiscountPercent = discountPercent;
        }

        public override bool Equals(object obj)
        {
            return obj is Discount discount &&
                   DiscountId == discount.DiscountId;
        }

        public override int GetHashCode()
        {
            return 1574009819 + DiscountId.GetHashCode();
        }

        public static void UpdateAutoId(int v)
        {
            s_autoId = v;
        }
    }
}
