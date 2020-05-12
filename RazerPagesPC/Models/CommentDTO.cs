using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using RazerPagesPC.Models;

namespace RazerPagesPC.Models
{
    public class CommentDTO
    {
        [DataMember]
        public int CommentId { get; set; }
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public int PostPostId { get; set; }
        [DataMember]
        public virtual PostDTO PostDTO { get; set; }
    }
}
