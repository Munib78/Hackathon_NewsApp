using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Models
{
    [DataContract]
    public class News
    {
        [DataMember]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DataMember]
        [Required]
        public string Source { get; set; }

        [DataMember]
        [Required]
        public string Author { get; set; }

        [DataMember]
        [Required]
        public string Title { get; set; }

        [DataMember]
        [Required]
        public string Description { get; set; }

        [DataMember]
        [Required]
        public DateTime PublishedOn { get; set; } = DateTime.Now;

        [DataMember]
        [Required]
        public string Url { get; set; }

        [DataMember]
        [Required]
        public string UrlToImage { get; set; }

        [DataMember]
        public Category Category { get; set; }
    }
}
