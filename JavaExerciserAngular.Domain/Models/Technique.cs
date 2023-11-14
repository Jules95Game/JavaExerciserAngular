using JavaExerciserAngular.Domain.Interfaces;

namespace JavaExerciserAngular.Domain.Models;

public class Technique : IEntity
{
    public int Id { get; set; }
    public required string TechniqueName { get; set; }
}