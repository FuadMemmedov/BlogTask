using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Blog
    {
        static int _id;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Blog()
        {
            
        }


        public Blog(string title,string description)
        {
            _id++;
            Id = _id;
            Title = title;
            Description = description;
                
        }
        Comment[] Comments = new Comment[] {};
        public override string ToString()
        {
            return $"Id: {Id} Title: {Title} Description: {Description}";
        }
        public void AddComment(Comment comment)
        {
            Array.Resize(ref Comments, Comments.Length + 1);
            Comments[Comments.Length - 1] = comment;

        }
        public object GetComment(int commentId) 
        {
            foreach(var comment in Comments)
            {
                if (comment.Id == commentId)
                {
                     return $" Id: {comment.Id} Content: {comment.Content}";
                }
            }
                
         
            return "Bu id uygun comment yoxdur";
        }
        public Comment[] GetAllComments()
        {
            return Comments;
        }
        public Comment[] RemoveComment(int commentId)
        {
            Comment[] removedComments = new Comment[] {};
            foreach (Comment comment in Comments)
            {
                if (comment.Id != commentId) 
                {
                    Array.Resize(ref removedComments, removedComments.Length + 1);
                    removedComments[removedComments.Length - 1] = comment;
                }
            }
            Comments = removedComments;
            return Comments;

        }
        public Comment[] UptadeComment(int commentId,Comment comment)
        {
            
            foreach (Comment item in Comments)
            {
                if (item.Id == commentId) 
                {
                    
                    item.Content = comment.Content;
                    
                }
             
            }
           
            return Comments;


        }

    }
}
