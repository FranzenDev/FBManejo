namespace Domain.Entities;

public class Manejo
{
    public int Id { get; set; }

    public DateOnly Data { get; set; }

    public TipoManejo TipoManejo { get; set; }

    public string? Observacao { get; set; }

    // Navegação
    public ICollection<ManejoAnimal> Animais { get; set; } = new List<ManejoAnimal>();
}

public enum TipoManejo
{
    Pesagem = 1,
    Vacinacao = 2,
    Vermifugacao = 3,
    Tratamento = 4,
    Apartacao = 5
}
