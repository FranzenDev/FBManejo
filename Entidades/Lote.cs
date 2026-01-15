using FBManejoV2.Entidades;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Lote
{
    public int Id { get; set; }

    [Required]
    public string Nome { get; set; } = null!;

    public bool Ativo { get; set; } = true;

    // Navegação
    public ICollection<HistoricoLote> HistoricoLotes { get; set; } = new List<HistoricoLote>();
}
