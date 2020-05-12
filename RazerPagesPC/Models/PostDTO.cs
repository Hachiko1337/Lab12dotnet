using RazerPagesPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RazerPagesPC.Models
{
    public class PostDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PostDTO()
        {
            this.CommentDTOs = new HashSet<CommentDTO>();
        }

        [DataMember]
        public int PostId { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Domain { get; set; }
        [DataMember]
        public System.DateTime Date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<CommentDTO> CommentDTOs { get; set; }
    }
}
