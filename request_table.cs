//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class request_table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public request_table()
        {
            this.application_table = new HashSet<application_table>();
        }
    
        public string manager_name { get; set; }
        public string project_name { get; set; }
        public Nullable<int> period_month { get; set; }
        public Nullable<int> noof_vacancies { get; set; }
        public string skill { get; set; }
        public string pgm_languages { get; set; }
        public Nullable<int> exp_years { get; set; }
        public string req_desc { get; set; }
        public int req_id { get; set; }
        public string reqstatus { get; set; }
        public string desg { get; set; }
        public Nullable<System.DateTime> date_request { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<application_table> application_table { get; set; }
    }
}
