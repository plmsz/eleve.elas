using Zoologico.Domain.Interface;

namespace Zoologico.Domain.Entity;

public class Anfibio : Animal, INadar
{
    public int LimiteProfundidade { get; set; } = 100;

    protected bool VerificarFaseAdulta = false;

    public override void DescreverAnimal()
    {
        throw new NotImplementedException();
    }

    public string Mergulhar()
    {
        if (VerificarFaseAdulta)
        {
            return $"Anfibio - Desce no máx {LimiteProfundidade}m";
        }
        else
        {
            return "Anfibio salta";
        }
    }

    public string Emergir()
    {
        return $"Anfibio - Sobe devagar";
    }
}