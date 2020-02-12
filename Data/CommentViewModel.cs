using System;

namespace BlazorArticleExample.Data
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}