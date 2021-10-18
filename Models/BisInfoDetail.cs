using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APIBankLoan.Models
{
    [Serializable]
    public class BisInfoDetail
    {
        [Key]
        //[IgnoreDataMember]
        //[JsonIgnore]
        //public Guid IDGuid = new();
        [Column(TypeName = "varchar(255)", Order = 1)]
        public string RefID { get; set; }
        [Column(TypeName = "varchar(255)", Order =2)]
        public string Cifno { get; set; }
        [Column(TypeName = "varchar(255)", Order =3)]
        public string signature { get; set; }
        [Column(TypeName = "varchar(255)", Order =4)]
        public string sourceCode { get; set; }
        [Column(TypeName = "varchar(255)", Order =5)]
        public string type { get; set; }
        [Column(TypeName = "varchar(255)", Order =6)]
        public string businessNo { get; set; }
        [Column(TypeName = "varchar(255)", Order =7)]
        public string businessName { get; set; }
        [Column(TypeName = "varchar(255)", Order =8)]
        public string businessAddress { get; set; }
        [Column(TypeName = "varchar(255)", Order =9)]
        public string businessEmail { get; set; }
        [Column(TypeName = "varchar(255)", Order =10)]
        public string businessPhoneNo { get; set; }
        [Column(TypeName = "varchar(255)", Order =11)]
        public string initiatorId { get; set; }
        [Column(TypeName = "varchar(255)", Order =12)]
        public string contactPerson { get; set; }
        [Column(TypeName = "varchar(255)", Order =13)]
        public string contactPhoneNo { get; set; }
        [Column(TypeName = "varchar(255)", Order =14)]
        public string roleID { get; set; }
        [Column(TypeName = "varchar(255)", Order =15)]
        public string reqBy { get; set; }
        [Column(TypeName = "varchar(255)", Order = 4)]
        public int status { get; set; }

        [ForeignKey("RefID")]
        public ICollection<authorizers> Authorizers { get; set; }

    }
}