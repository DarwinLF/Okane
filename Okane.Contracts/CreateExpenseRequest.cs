using System.ComponentModel.DataAnnotations;

namespace Okane.Contracts;

public class CreateExpenseRequest
{
    [Required]
    [Range(1, 1_000_000)]
    public int Amount { get; set; }
    
    [Required]
    [MaxLength(80)]
    public required string Category { get; set; }

    public string? Description { get; set; }
    [RegularExpression(@"^[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b(?:[-a-zA-Z0-9()@:%_\+.~#?&//=]*)$"
    ,ErrorMessage = "Invalid Url")]
    public string? InvoiceUrl { get; set; }
}