using AwesomeAssertions;

namespace WordWrap.Tests;

public class WordWrapTests
{
    [Fact]
    public void Si_envioVacio_Debe_RetornarVacio()
    {
        var result = Wrap("", 1);

        result.Should().Be("");
    }

    [Fact]
    public void Si_EnvioThisy10_Debe_Retornarthis()
    {
        var result = Wrap("this", 10);

        result.Should().Be("this");
    }

    [Fact]
    public void Si_envio_Wordy2_Debe_Retornarwo_nrd()
    {
        var result = Wrap("word", 2);

        result.Should().Be("wo\nrd");
    }

    [Fact]
    public void Si_Envio_word_wordy3_Debe_Retornarwor_nd_nwor_nd()
    {
        var result = Wrap("word word", 3);

        result.Should().Be("wor\nd\nwor\nd");
    }

    [Fact]
    public void Si_Envioabcdefghijy3_Debe_Retornarabc_ndef_nghi_nj()
    {
        var result = Wrap("abcdefghij", 3);

        result.Should().Be("abc\ndef\nghi\nj");
    }

    [Fact]
    public void e()
    {
        var result = Wrap("word word", 3);

        result.Should().Be("wor\nd\nwor\nd");
    }

    [Fact]
    public void f()
    {
        var result = Wrap("word word", 6);

        result.Should().Be("word\nword");
    }

    [Fact]
    public void f2()
    {
        var result = Wrap("word word", 5);

        result.Should().Be("word\nword");
    }

    [Fact]
    public void g()
    {
        var result = Wrap("word word word", 6);

        result.Should().Be("word\nword\nword");
    }

    [Fact]
    public void Si_Envioword_word_wordy11_Debe_Retornarword_word_nword()
    {
        var result = Wrap("word word word", 11);

        result.Should().Be("word word\nword");
    }

    private static string Wrap(string text, int col)
    {
        var tamano = text.Length;
        var respuesta = "";
        var reglon = 0;
        var salto = "\n";
        
        if (tamano <= col)
            return text;

        for (int i = 0; i < tamano; i++)
        {
            var letra = text[i];
            if (reglon <= col - 1 && letra != ' ')
            {
                respuesta += letra;
                reglon++;
            }
            else if (reglon <= col)
            {
                if (letra == ' ')
                {
                    var longitudSiguientePalabra = LongitudSiguientePalabra(text, tamano, i);

                    var palabraCabe = reglon + 1 + longitudSiguientePalabra <= col;
                    respuesta += palabraCabe ? letra : salto;
                    reglon = palabraCabe ? reglon + 1 : 0;
                }
                else
                {
                    respuesta += salto + letra;
                    reglon = 1;
                }
            }
        }

        return respuesta;
    }

    private static int LongitudSiguientePalabra(string text, int tamano, int i)
    {
        var longitudSiguientePalabra = 0;
        for (int j = i + 1; j < tamano && text[j] != ' '; j++)
        {
            longitudSiguientePalabra++;
        }

        return longitudSiguientePalabra;
    }
}