using Zoologico.Domain.Interface;

namespace Zoologico.Domain.Entity;

public abstract class AveVoadora : Animal, IVoar
{
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
}