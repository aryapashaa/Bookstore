namespace Client.Models;
public class Book
{
    public int Id { get; set; }
    public string Isbn { get; set; }
    public string Title { get; set; }
    public DateTime ReleaseYear { get; set; }
    public string Synopsis { get; set; }
    public int PageNumber { get; set; }
    public int Price { get; set; }
    public string Genre { get; set; }
    public string? PictureUrl { get; set; }
    public int PublisherId { get; set; }
    public int AuthorId { get; set; }
    public int LanguageId { get; set; }
}
