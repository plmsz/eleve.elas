namespace Solid
{
    public class Biblioteca{
        private readonly GerenciadorDeLivros gerenciadorDeLivros;
        private readonly GerenciadorEmprestimo gerenciadorEmprestimo;
        private readonly Repositorio repositorio;
        private readonly Relatorio relatorio;

        public Biblioteca(GerenciadorDeLivros gerenciadorDeLivros, GerenciadorEmprestimo gerenciadorEmprestimo, Repositorio repositorio, Relatorio relatorio)
        {
            this.gerenciadorDeLivros = gerenciadorDeLivros;
            this.gerenciadorEmprestimo = gerenciadorEmprestimo;
            this.repositorio = repositorio;
            this.relatorio = relatorio;
        }
    }
    public class GerenciadorDeLivros
    {
        private readonly List<Livro> livros;

        public GerenciadorDeLivros()
        {
            this.livros = [];
        }

        // Métodos relacionados ao gerenciamento de livros
        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public void RemoverLivro(Livro livro)
        {
            livros.Remove(livro);
        }

        public List<Livro> ObterLivros()
        {
            return livros;
        }
    }

    public class GerenciadorEmprestimo(List<Livro> livros, Dictionary<string, RegistroEmprestimo> registrosEmprestimo)
    {
        private readonly List<Livro> livros = livros;
        private readonly Dictionary<string, RegistroEmprestimo> registrosEmprestimo = registrosEmprestimo;

        // Métodos relacionados ao empréstimo de livros
        public void EmprestarLivro(string usuarioId, Livro livro)
        {
            if (livros.Contains(livro))
            {
                registrosEmprestimo[usuarioId] = new RegistroEmprestimo(usuarioId, livro, DateTime.Now);
                livros.Remove(livro);
            }
        }

        public void DevolverLivro(string usuarioId, Livro livro)
        {
            if (registrosEmprestimo.TryGetValue(usuarioId, out var registro) && registro.Livro.Equals(livro))
            {
                livros.Add(livro);
                registrosEmprestimo.Remove(usuarioId);
            }
        }
    }

    public class Multa(Dictionary<string, RegistroEmprestimo> registrosEmprestimo)
    {
        private readonly Dictionary<string, RegistroEmprestimo> registrosEmprestimo = registrosEmprestimo;

        // Métodos relacionados ao cálculo de multas
        public double CalcularMulta(string usuarioId)
        {
            if (registrosEmprestimo.TryGetValue(usuarioId, out var registro))
            {
                var diasEmprestados = (DateTime.Now - registro.DataEmprestimo).TotalDays;
                if (diasEmprestados > 14)
                {
                    return (diasEmprestados - 14) * 0.5;
                }
            }
            return 0.0;
        }
    }

    public class Repositorio
    {
        // Métodos relacionados ao armazenamento em banco de dados
        public void SalvarDadosBiblioteca()
        {
            // Código para salvar dados da biblioteca no banco de dados
        }

        public void CarregarDadosBiblioteca()
        {
            // Código para carregar dados da biblioteca do banco de dados
        }
    }

    public class Relatorio
    {
        // Métodos relacionados à geração de relatórios
        public void GerarRelatorio()
        {
            // Código para gerar relatório de status da biblioteca
        }
    }
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
    }

    public class RegistroEmprestimo(string usuarioId, Livro livro, DateTime dataEmprestimo)
    {
        public string UsuarioId { get; } = usuarioId;
        public Livro Livro { get; } = livro;
        public DateTime DataEmprestimo { get; } = dataEmprestimo;
    }

}
