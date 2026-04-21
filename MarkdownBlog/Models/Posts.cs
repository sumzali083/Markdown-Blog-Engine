namespace MarkdownBlog.Models
{
public class Posts
{
    public int Id{get;set; }
    public string Title{get;set; }

    public string Content{get;set; }

    public string HTMLContent{get;set; }

    public string Tags{get;set; }

    public  DateTime createdAt {get;set; }

    public DateTime updatedAt {get;set; }
    public Status Status { get; set; }

    public string Slug { get; set; }

}

 public enum Status {
    Draft , 
    Published
 }
}