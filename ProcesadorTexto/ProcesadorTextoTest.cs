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
    private static string Wrap(string text, int col)
         {
             return "";
         }   

}