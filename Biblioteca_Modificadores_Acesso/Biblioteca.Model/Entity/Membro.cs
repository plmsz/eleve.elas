namespace Biblioteca.Model.Entity;

public class Membro
{
    public string Nome { get; set; }
    private long Id { get; set; }

    internal void PedirEmprestimo()
    { }

    protected void ObterInformacoesDetalhadas()
    {
        Console.WriteLine($"Nome: {Nome} \nID: {Id}");
    }
}