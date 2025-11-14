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

    // [Fact]
    // public void Si_Envioabcdefghijy3_Debe_Retornarabc_ndef_nghi_nj()
    // {
    //     var result = Wrap("abcdefghij", 3);
    //
    //     result.Should().Be("abc\ndef\nghi\nj");
    // }

    private static string Wrap(string text, int col)
    {
        var tamano = text.Length;

        if (tamano <= col)
            return text;

        var respuesta = "";
        var tamanoReglon = 0;

        for (int i = 0; i < tamano; i++)
        {
            if (tamanoReglon < col && text[i] != ' ')
            {
                respuesta += text[i];
                tamanoReglon++;
            }
            else
            {
                respuesta += "\n";
                tamanoReglon = 0;
                if (text[i] != ' ')
                {
                    respuesta += text[i];
                    tamanoReglon = 1;
                }
            }
        }

        return respuesta;
    }
}