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
    
    public partial class ps_customer
    {
        public long id_customer { get; set; }
        public long id_shop_group { get; set; }
        public long id_shop { get; set; }
        public long id_gender { get; set; }
        public long id_default_group { get; set; }
        public Nullable<long> id_lang { get; set; }
        public long id_risk { get; set; }
        public string company { get; set; }
        public string siret { get; set; }
        public string ape { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string passwd { get; set; }
        public System.DateTime last_passwd_gen { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public bool newsletter { get; set; }
        public string ip_registration_newsletter { get; set; }
        public Nullable<System.DateTime> newsletter_date_add { get; set; }
        public bool optin { get; set; }
        public string website { get; set; }
        public decimal outstanding_allow_amount { get; set; }
        public bool show_public_prices { get; set; }
        public long max_payment_days { get; set; }
        public string secure_key { get; set; }
        public string note { get; set; }
        public bool active { get; set; }
        public bool is_guest { get; set; }
        public bool deleted { get; set; }
        public System.DateTime date_add { get; set; }
        public System.DateTime date_upd { get; set; }
    }
}