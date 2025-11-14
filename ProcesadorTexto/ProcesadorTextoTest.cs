using FluentAssertions;
using Xunit.Sdk;

namespace ProcesadorTexto;

public class ProcesadorTextoTest
{
    [Fact]
    public void Si_ingresoholay10_Debe_Retornarhola()
    {
        var texte = "hola";
        var columna = 10;
        var procesador = new Procesador(texte, columna);

        procesador.Formatear().Should().Be("hola");

    }

    [Fact]
    public void Si_IngresoVacioy10_Debe_retornarException()
    {
        var texte = "";
        var columna = 10;
        var caller = () => new Procesador(texte, columna);

        caller.Should().ThrowExactly<InvalidOperationException>();
    }
}

public class Procesador
{
    private readonly string _texto;
    private readonly int _columna;

    public Procesador(string texto, int columna)
    {
        if (string.IsNullOrEmpty(texto))
            throw new InvalidOperationException();

        _texto = texto;
        _columna = columna;
    }

    public string Formatear()
    {
        return _texto;
    }
}