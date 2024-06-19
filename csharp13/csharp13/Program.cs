internal class Program
{
    public class Test
    {
        private string _nome = null!;

        public string Nome
        {
            get => _nome.Trim().ToUpper();
            set => _nome = value;
        }
    }

    //Essa feauture vai quebrar se em algum lugar do projeto tiver a palavra field
    public class Test2
    {
        public string Nome
        {
            get => field.Trim().ToUpper();
            set => field = value;
        }

        private static void Main()
        {
            Test t = new() { Nome = "  sOu EmOxInHa " };
            Console.WriteLine(t.Nome);
        }
    }