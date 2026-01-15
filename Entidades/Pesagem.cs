using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Pesagem
{
    public int Id { get; set; }

    [Required]
    public int AnimalId { get; set; }

    public DateOnly Data { get; set; }

    public decimal PesoKg { get; set; }

    public string? Observacao { get; set; }

    // Navegação
    public Animal Animal { get; set; } = null!;
}
