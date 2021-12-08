using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Model
{
    [Table(name: "Profile")]
    public class Profile
    {
        [Key]
        public long ID { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        [Required]
        public string Customer_Name { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        [Required]
        public string Mobile { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        [Required]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        [Required]
        public string Password { get; set; }
        [Column(TypeName = "datetime")]
        [Required]
        public DateTime InsertedDate { get; set; }
        [Column(TypeName = "datetime")]
        [Required]
        public DateTime ModifiedDate { get; set; }
        [Column(TypeName = "int")]
        public long InsertedId { get; set; }
        [Column(TypeName = "int")]
        public long ModifiedId { get; set; }
        [Column(TypeName = "bit")]
        public bool Active { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Status { get; set; }
        [Column(TypeName = "bit")]
        public bool IsAvailable { get; set; }







    }
}
