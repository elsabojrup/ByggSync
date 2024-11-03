using QuestionManagementAPI.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

public class Question
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Titel är obligatorisk.")]
    [StringLength(100, ErrorMessage = "Titeln får inte överstiga 100 tecken.")]
    [NotEmptyString(ErrorMessage = "Titel får inte vara tom.")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Beskrivning är obligatorisk.")]
    [StringLength(500, ErrorMessage = "Beskrivningen får inte överstiga 500 tecken.")]
    [NotEmptyString(ErrorMessage = "Titel får inte vara tom.")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Status är obligatorisk.")]
    [StringLength(20, ErrorMessage = "Beskrivning får inte överstiga 20 tecken.")]
    [NotEmptyString(ErrorMessage = "Titel får inte vara tom.")]
    public string Status { get; set; }
    public string LinkedIfcObjectId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
