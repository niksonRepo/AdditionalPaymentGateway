using System;

namespace AdditionalPaymentGateway.Api.Types
{
    public class ReceiptDetails
    {
        public int ReceiptNumber { get; set; }
        public int UserId { get; set; }
        public double PayableAmount { get; set; }
        public int PaymentStatus { get; set; }
    }
}
