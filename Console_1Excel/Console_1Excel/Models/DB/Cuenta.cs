using System;
using System.Collections.Generic;

#nullable disable

namespace Console_1Excel.Models.DB
{
    public partial class Cuenta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; }
        public decimal? EEfectivo { get; set; }
        public decimal? GEfectivo { get; set; }
        public decimal? EBanco { get; set; }
        public decimal? GBanco { get; set; }
    }
}
