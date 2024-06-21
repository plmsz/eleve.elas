namespace Biblioteca.Model.Entity;

public class Livro
{
    public string Titulo { get; set; }
    protected string Autor { get; set; }
    internal string ISBN { get; set; }
    protected string ResumoDoLivro { get; set; }

    public string ObterResumoDoLivro()
    {
        return ResumoDoLivro;
    }
}