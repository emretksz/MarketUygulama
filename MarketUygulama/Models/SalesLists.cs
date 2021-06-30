//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketUygulama.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesLists
    {
        public int SalesListId { get; set; }
        public Nullable<int> CashierId { get; set; }
        public string FaturaNu { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public string ToplamTutar { get; set; }
        public string KasaNu { get; set; }
        public string UrunAdi { get; set; }
        public string Adet { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyAdi { get; set; }
        public string Kasiyer { get; set; }
        public string TcNu { get; set; }
    
        public virtual Cashiers Cashiers { get; set; }
        public virtual Customers Customers { get; set; }
        public virtual Products Products { get; set; }
    }
}