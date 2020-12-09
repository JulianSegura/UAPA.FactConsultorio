using System;
using System.Collections.Generic;
using System.Text;

namespace UAPA.FactConsultorio.Domain.Entities
{
    public class Receipt:AuditableEntityBase
    {
        public int PatientId { get; set; }
        public decimal ReceiptTotal { get; set; }
        public decimal PaymentTotal { get; set; }
        public int CashierId { get; set; }
        public string Comments { get; set; }

        #region Navigation
        public virtual ICollection<ReceiptLine> Details { get; set; } = new List<ReceiptLine>();
        #endregion
    }

    public class ReceiptLine: EntityBase
    {
        public decimal Value { get; set; }
        public int Quantity { get; set; }

        #region Navigation
        public virtual Receipt Receipt { get; set; }
        public virtual Service Service { get; set; }
        #endregion
    }
}
