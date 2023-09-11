namespace Models;

public class CategoriaParaTiposDePecas
{
    public long? CategoriaParaTiposDePecasID { get; set; }
    public string? Nome { get; set; }
    public TipoDePeca? TipoDePeca { get; set; }

    public CategoriaParaTiposDePecas(string nome, TipoDePeca tipoDePeca)
    {
        Nome = nome;
        TipoDePeca = tipoDePeca;

        if (TipoDePeca.CategoriasParaTiposDePecas == null) {
            TipoDePeca.CategoriasParaTiposDePecas = new List<CategoriaParaTiposDePecas>();
        }

        TipoDePeca.CategoriasParaTiposDePecas.Add(this);
    }
}
