namespace Login_Page.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("employee")]
    public partial class employee
    {
        [Key]
        [StringLength(20)]
        public string EID { get; set; }

        [StringLength(20)]
        public string Lastname { get; set; }

        [StringLength(20)]
        public string Firstname { get; set; }

        [StringLength(1)]
        public string Midinitial { get; set; }

        [StringLength(1)]
        public string gender { get; set; }

        [StringLength(20)]
        public string street { get; set; }

        [StringLength(20)]
        public string city { get; set; }
    }
}
