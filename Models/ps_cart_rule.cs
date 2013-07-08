//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrestaSharp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ps_cart_rule
    {
        public long id_cart_rule { get; set; }
        public long id_customer { get; set; }
        public System.DateTime date_from { get; set; }
        public System.DateTime date_to { get; set; }
        public string description { get; set; }
        public long quantity { get; set; }
        public long quantity_per_user { get; set; }
        public long priority { get; set; }
        public bool partial_use { get; set; }
        public string code { get; set; }
        public decimal minimum_amount { get; set; }
        public bool minimum_amount_tax { get; set; }
        public long minimum_amount_currency { get; set; }
        public bool minimum_amount_shipping { get; set; }
        public bool country_restriction { get; set; }
        public bool carrier_restriction { get; set; }
        public bool group_restriction { get; set; }
        public bool cart_rule_restriction { get; set; }
        public bool product_restriction { get; set; }
        public bool shop_restriction { get; set; }
        public bool free_shipping { get; set; }
        public decimal reduction_percent { get; set; }
        public decimal reduction_amount { get; set; }
        public bool reduction_tax { get; set; }
        public long reduction_currency { get; set; }
        public int reduction_product { get; set; }
        public long gift_product { get; set; }
        public long gift_product_attribute { get; set; }
        public bool highlight { get; set; }
        public bool active { get; set; }
        public System.DateTime date_add { get; set; }
        public System.DateTime date_upd { get; set; }
    }
}