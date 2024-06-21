namespace Zoologico.Domain.Interface;

internal interface INadar
{
    int LimiteProfundidade { get; set; }

    string Mergulhar();

    string Emergir();
}