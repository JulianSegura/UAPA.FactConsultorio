using System;
using System.Collections.Generic;
using System.Text;

namespace UAPA.FactConsultorio.Domain.Entities
{
    public class Payment:EntityBase
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Reference { get; set; }

        #region Navigation
        public virtual Receipt Receipt { get; set; }
        #endregion
    }
}
