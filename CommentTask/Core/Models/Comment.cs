using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Comment
    {
        static int _id;
        public int Id { get; set; }
        public string Content { get; set; }

        public virtual string ToString()
        {
            return $"Id: {Id} Content: {Content}";
        }
        public Comment(string content)
        {
            _id++;
            Id = _id;
            Content = content;

        }
    }
}
