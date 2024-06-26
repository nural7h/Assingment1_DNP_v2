﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Post
{
    [Key]
    public int Id { get; set; }
    public User Owner { get; set; }
    public int OwnerId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public Post(int ownerId, string title, string content)
    {
        OwnerId = ownerId;
        Title = title;
        Content = content;
    }
    public Post(){}
}