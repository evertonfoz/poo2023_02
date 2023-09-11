namespace Models;

public class TipoDePeca
{
    public long? TipoDePecaID { get; set; }
    public string? Nome { get; set; }
    public List<CategoriaParaTiposDePecas>? CategoriasParaTiposDePecas { get; set; }

    public TipoDePeca(string? nome=null)
    {
        if (nome == null) {
            throw new InvalidDataException("Nome é obrigatório");
        }
        Nome = nome;   
    }
}
