﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Bookstore_API.Models;
[Table("tb_m_books")]
public class Book
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("isbn"), MaxLength(30)]
    public string Isbn { get; set; }
    [Required, Column("title"), MaxLength(255)]
    public string Title { get; set; }
    [Required, Column("release_year", TypeName = "nchar(4)")]
    public string ReleaseYear { get; set; }
    [Required, Column("synopsis", TypeName ="text")]
    public string Synopsis { get; set; }
    [Required, Column("page_number")]
    public int PageNumber { get; set; }
    [Column("price", TypeName = "numeric(19,0)")]
    public int Price { get; set; }
    [Required, Column("genre"), MaxLength(25)]
    public string Genre { get; set; }
    [Column("picture_url"), MaxLength(255)]
    public string? PictureUrl { get; set; }
    [Required, Column("publisher_id")]
    public int PublisherId { get; set; }
    [Required, Column("author_id")]
    public int AuthorId { get; set; }
    [Required, Column("language_id")]
    public int LanguageId { get; set; }

    // Cardinality
    [JsonIgnore]
    public ShoppingCart? ShoppingCart { get; set; }
    [JsonIgnore]
    [ForeignKey(nameof(PublisherId))]
    public Publisher? Publisher { get; set; }
    [JsonIgnore]
    [ForeignKey(nameof(AuthorId))]
    public Author? Author { get; set; }
    [JsonIgnore]
    [ForeignKey(nameof(LanguageId))]
    public Language? Language { get; set; }
}
