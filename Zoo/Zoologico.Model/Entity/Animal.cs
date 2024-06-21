namespace Zoologico.Domain.Entity;

public abstract class Animal
{
    public string NomeDoAnimal { get; set; } // basta apenas herdar não precisa de abstract

    public abstract void DescreverAnimal(); //obriga o filho a implementar e modificar

    //já virtual poderia ser usado no caso que apenas um ou alguns dos filho precisa sobrescrever a implementação
}