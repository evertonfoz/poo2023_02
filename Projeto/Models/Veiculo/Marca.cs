namespace Models;

public class MarcaVeiculo
{
    public long MarcaVeiculoID { get; set; }
    public string Nome { get; set; }
    public List<ModeloVeiculo>  Modelos { get; set; }

}
