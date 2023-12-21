using System.Text.Json.Serialization;

namespace Domain.Models;

public class User
{
    [JsonIgnore]
    public ICollection<Post> Posts { get; set;}
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    
    public User(){}
}