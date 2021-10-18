using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System;    
using System.Runtime.InteropServices;

namespace APIBankLoan.Models
{
    public class authorizers
    {
        [Key]
        [IgnoreDataMember]
        [JsonIgnore]
        public Guid Guid { get; set; }
        [Column(TypeName = "varchar(255)", Order =1)]
        public string userId { get; set; }
        [Column(TypeName = "varchar(255)", Order = 2)]
        public string userName { get; set; }
        [Column(TypeName = "varchar(255)", Order = 3)]
        public string userEmail { get; set; }
        [Column(TypeName = "varchar(255)", Order = 4)]
        public string userPhoneNo { get; set; }
        [Column(TypeName = "varchar(255)", Order = 5)]
        public int status { get; set; }

        // [Key]
        [IgnoreDataMember]
        [JsonIgnore]
        [Column(TypeName = "varchar(255)", Order =6)]
        public string RefID { get; set; } //FK
        //public BisInfoDetail bisInfoDetail { get; set; } //Reference navigation
    }
}
