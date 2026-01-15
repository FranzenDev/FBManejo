namespace Domain.Entities;

public class ManejoAnimal
{
    public int Id { get; set; }

    public int ManejoId { get; set; }
    public int AnimalId { get; set; }

    // Navegação
    public Manejo Manejo { get; set; } = null!;
    public Animal Animal { get; set; } = null!;
}
