using JavaExerciserAngular.Domain.Interfaces;

namespace JavaExerciserAngular.Domain.Models;

public class Exercise : IEntity
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required int Size { get; set; }
    public required List<Technique> Techniques { get; set; }
    public required string Instructions { get; set; }
    public required string Solution { get; set; }
    public ExerciseStatus Status { get; set; }
    public DateTime? StatusTime { get; set; }
}