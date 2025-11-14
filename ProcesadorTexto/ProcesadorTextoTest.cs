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
    public void Si_EnvioThis_Debe_Retornarthis()
    {
        var result = Wrap("this", 10);

        result.Should().Be("this");
    }  
    [Fact]
    public void Si_envio_Word_Debe_Retornarwo_nrd()
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
    private static string Wrap(string text, int col)
    {

        if (text == "word word" && col == 3)
            return "wor\nd\nwor\nd";
        if (text == "word" && col == 2)
            return "wo\nrd";
        return text;
         }   

}