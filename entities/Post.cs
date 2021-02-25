using System;
using System.Collections.Generic;

namespace dot.entities
{
    public class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }
        public Post(DateTime moment, string title, string content)
        {
            Moment = moment;
            Title = title;
            Content = content;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void DellComment(Comment comment)
        {
            Comments.Remove(comment);
        }
    }
}