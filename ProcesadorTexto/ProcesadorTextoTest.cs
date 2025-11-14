using FluentAssertions;

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
}

public class Procesador
{
    private readonly string _texto;
    private readonly int _columna;

    public Procesador(string texto, int columna)
    {
        _texto = texto;
        _columna = columna;
    }

    public string Formatear()
    {
       
            return _texto;
 
        
    }
}