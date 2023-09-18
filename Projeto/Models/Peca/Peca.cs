namespace Models;

public class Peca
{
    public long PecaID { get; set; }
    public CategoriaParaTiposDePecas CategoriaParaTiposDePecas { get; set; }
    public TipoDePeca TipoDePeca { get; set; }
    public MarcaVeiculo MarcaVeiculo { get; set; }
    public ModeloVeiculo ModeloVeiculo { get; set; }
}
