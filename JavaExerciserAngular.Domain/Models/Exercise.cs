using JavaExerciserAngular.Domain.Interfaces;

namespace JavaExerciserAngular.Domain.Models;

public class Exercise : IEntity
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required int Size { get; set; }
    public required List<string> Techniques { get; set; }
    public required string Instructions { get; set; }
    public Status Status { get; set; }
    public DateTime StatusTime { get; set; }
}