namespace Domain.Entities;

public class HistoricoLote
{
    public int Id { get; set; }

    public int AnimalId { get; set; }
    public int LoteId { get; set; }

    public DateOnly DataEntrada { get; set; }
    public DateOnly? DataSaida { get; set; }

    // Navegação
    public Animal Animal { get; set; } = null!;
    public Lote Lote { get; set; } = null!;
}
