using System;

namespace Models 
{
    public class Bill : IComparable<Bill>
    {
        private static int s_autoId = 1000000;
        public int BillId { get; set; }
        public Cart Cart { get; set; } = new Cart();
        public DateTime CreatedTime { get; set; }
        public int TotalItem { get; set; }
        public long SubTotal { get; set; }
        public long TotalDiscountAmount { get; set; }
        public long TotalAmount { get; set; }
        public string Status { get; set; }

        public Bill()
        {
        }

        public Bill(int id)
        {
            BillId = id > 0 ? id : s_autoId++;
        }

        public Bill(int billId, Cart cart, DateTime createdTime, int totalItem, 
            long subTotal, long totalDiscountAmount, long totalAmount, string status) : this(billId)
        {
            Cart = cart;
            CreatedTime = createdTime;
            TotalItem = totalItem;
            SubTotal = subTotal;
            TotalDiscountAmount = totalDiscountAmount;
            TotalAmount = totalAmount;
            Status = status;
        }

        public int CompareTo(Bill other)
        {
            return BillId - other.BillId;
        }

        public override bool Equals(object obj)
        {
            return obj is Bill bill &&
                   BillId == bill.BillId;
        }

        public override int GetHashCode()
        {
            return 740390073 + BillId.GetHashCode();
        }

        public static void UpdateAutoId(int v)
        {
            s_autoId = v;
        }
    }
}
