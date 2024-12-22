using QuestionManagementAPI.Attributes;
using QuestionManagementAPI.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class Question
{
    public int Id { get; set; }

    [JsonPropertyName("title")]
    [Required(ErrorMessage = "Titel är obligatorisk.")]
    [StringLength(100, ErrorMessage = "Titeln får inte överstiga 100 tecken.")]
    [NotEmptyString(ErrorMessage = "Titel får inte vara tom.")]
    public string Title { get; set; }

    [JsonPropertyName("description")]
    [Required(ErrorMessage = "Beskrivning är obligatorisk.")]
    [StringLength(500, ErrorMessage = "Beskrivningen får inte överstiga 500 tecken.")]
    [NotEmptyString(ErrorMessage = "Titel får inte vara tom.")]
    public string Description { get; set; }

    [JsonPropertyName("status")]
    [Required(ErrorMessage = "Status är obligatorisk.")]
    [NotEmptyString(ErrorMessage = "Status får inte vara tom.")]
    public QuestionStatus Status { get; set; }
    
    [JsonPropertyName("linkedObject")]
    [Required(ErrorMessage = "Status är obligatorisk.")]
    [NotEmptyString(ErrorMessage = "Status får inte vara tom.")]
    public string LinkedIfcObjectId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
