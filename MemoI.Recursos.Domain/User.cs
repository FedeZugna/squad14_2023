namespace MemoI.Recursos.Domain;

public record User
{
    public int Legajo { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
}