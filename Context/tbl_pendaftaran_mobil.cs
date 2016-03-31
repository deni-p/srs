//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SRS.DeskApp.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_pendaftaran_mobil
    {
        public tbl_pendaftaran_mobil()
        {
            this.tbl_transit_scan_id_device = new HashSet<tbl_transit_scan_id_device>();
            this.tbl_transit_scan_id_timbangan = new HashSet<tbl_transit_scan_id_timbangan>();
            this.tbl_transit_timbangan = new HashSet<tbl_transit_timbangan>();
            this.tbl_transit_core_sampling = new HashSet<tbl_transit_core_sampling>();
        }
    
        public int doc_entry { get; set; }
        public Nullable<System.DateTime> doc_date { get; set; }
        public string card_code { get; set; }
        public string card_name { get; set; }
        public string card_code_reg { get; set; }
        public string card_name_reg { get; set; }
        public string tta_number { get; set; }
        public Nullable<System.DateTime> tta_date { get; set; }
        public string num_at_card { get; set; }
        public string car_id { get; set; }
        public string driver { get; set; }
        public string remark { get; set; }
        public string ip_address { get; set; }
        public Nullable<int> user_sign { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public string create_by { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public string update_by { get; set; }
        public Nullable<bool> car_type { get; set; }
    
        public virtual ICollection<tbl_transit_scan_id_device> tbl_transit_scan_id_device { get; set; }
        public virtual ICollection<tbl_transit_scan_id_timbangan> tbl_transit_scan_id_timbangan { get; set; }
        public virtual ICollection<tbl_transit_timbangan> tbl_transit_timbangan { get; set; }
        public virtual ICollection<tbl_transit_core_sampling> tbl_transit_core_sampling { get; set; }
    }
}