using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Animal
{
    public int Id { get; set; }

    [Required]
    public string Brinco { get; set; } = null!;

    public DateOnly DataEntradaFazenda { get; set; }

    public bool Ativo { get; set; } = true;

    // Navegação
    public ICollection<Pesagem> Pesagens { get; set; } = new List<Pesagem>();
    public ICollection<ManejoAnimal> Manejos { get; set; } = new List<ManejoAnimal>();
    public ICollection<HistoricoLote> HistoricoLotes { get; set; } = new List<HistoricoLote>();
}
