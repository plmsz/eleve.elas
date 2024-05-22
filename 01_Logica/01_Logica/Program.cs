internal class Program
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public int ExperienciaProfissional { get; set; }
    }

    private static void Main(string[] args)
    {
        // tipo referncia e tipo valor
        int idade = 20;

        int idade2 = idade;
        idade2 = 30;

        Console.WriteLine("idade = " + idade + " idade2 = " + idade2); // idade= 20 idade2= 30

        Funcionario funcionario = new Funcionario() { Nome = "Paulo", ExperienciaProfissional = 2 };
        Funcionario funcionario2 = funcionario;

        funcionario2.ExperienciaProfissional += 1;

        Console.WriteLine("Funcionário 1: " + funcionario2.ExperienciaProfissional
        + " funcionário2 :" + funcionario2.ExperienciaProfissional); // Funcionário 1: 3 funcionário2 :3

        //garbage collector
        //TODO

        // tipos em c #
        char sexo = 'F';
        bool feliz = false;
        DateTime date = DateTime.Now;
        //TODO: outros tipos

        // cast

        Console.WriteLine("Felling good?");

        bool resposta = Convert.ToBoolean(Console.ReadLine());
        if (resposta)
        {
            Console.WriteLine("I feel amazing");
        }
        else
        {
            Console.WriteLine("Sorry");
        }

        // interpolação de strings
        string valor = string.Format("minha idade é {0}", idade);
        string str = $"Hello {funcionario.Nome}. Today is {date}.";

        Console.WriteLine($"{valor}\n{str}");

        Console.ReadKey();
    }
}