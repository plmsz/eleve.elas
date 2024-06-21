using Zoologico.Domain.Interface;

namespace Zoologico.Domain.Entity;

public class AveVoadoraNadadora : Animal, IVoar, INadar
{
    public int LimiteProfundidade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public string LevantarVoo()
    {
        throw new NotImplementedException();
    }

    public string Pousar()
    {
        throw new NotImplementedException();
    }

    public override void DescreverAnimal()
    {
        throw new NotImplementedException();
    }

    public string Mergulhar()
    {
        throw new NotImplementedException();
    }

    public string Emergir()
    {
        throw new NotImplementedException();
    }
}