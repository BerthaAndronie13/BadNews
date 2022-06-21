using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BadNews.Models
{
    public class Comment
    {
        public Guid CommentId { get; set; }
        public string Content { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

        public Guid PostId { get; set; }

        public Post Post { get; set; }

    }
}
