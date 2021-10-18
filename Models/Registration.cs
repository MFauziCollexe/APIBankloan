using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System;    
using System.Runtime.InteropServices;

namespace APIBankLoan.Models
{
    public class Registration
    {
        [Key]
        [IgnoreDataMember]
        [JsonIgnore]
        public Guid Guid { get; set; }
        [Column(TypeName = "varchar(255)", Order = 1)]
        public string Email { get; set; }
        [Column(TypeName = "varchar(255)", Order = 2)]
        public string RefID { get; set; }
        [Column(TypeName = "varchar(255)", Order = 3)]
        public string Cifno { get; set; }
        [Column(TypeName = "varchar(255)", Order = 4)]
        public string CheckSum { get; set; }
        
    }
}