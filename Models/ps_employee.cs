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
    
    public partial class ps_employee
    {
        public long id_employee { get; set; }
        public long id_profile { get; set; }
        public long id_lang { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string email { get; set; }
        public string passwd { get; set; }
        public System.DateTime last_passwd_gen { get; set; }
        public Nullable<System.DateTime> stats_date_from { get; set; }
        public Nullable<System.DateTime> stats_date_to { get; set; }
        public string bo_color { get; set; }
        public string bo_theme { get; set; }
        public long default_tab { get; set; }
        public long bo_width { get; set; }
        public bool bo_show_screencast { get; set; }
        public bool active { get; set; }
        public long id_last_order { get; set; }
        public long id_last_customer_message { get; set; }
        public long id_last_customer { get; set; }
    }
}