using prog.lib;
namespace prog.xunit;



public class UnitTest1
{

    [Theory()]
    [InlineData(1000, "M")]
    [InlineData(2000, "MM")]
    public void ConvertRomanForThousands(int num, string expected)
    {
        Assert.Equal(expected, Roman.ConvThousands(num));
    }



    [Theory()]
    [InlineData(1, "I")]
    [InlineData(3, "III")]
    [InlineData(4, "IV")]
    [InlineData(5, "V")]
    [InlineData(8, "VIII")]
    [InlineData(9, "IX")]
    public void ConvertRomanForOnes(int num, string expected)
    {
        Assert.Equal(expected, Roman.ConvOnes(num));
    }


    [Theory()]
    [InlineData(10, "X")]
    [InlineData(30, "XXX")]
    [InlineData(40, "XL")]
    [InlineData(50, "L")]
    [InlineData(80, "LXXX")]
    [InlineData(90, "XC")]

    public void ConvertRomanForTens(int num, string expected)
    {

        Assert.Equal(expected, Roman.ConvTens(num));
    }


    [Theory()]
    [InlineData(200, "CC")]
    [InlineData(300, "CCC")]
    [InlineData(400, "CD")]
    [InlineData(500, "D")]
    [InlineData(700, "DCC")]
    [InlineData(800, "DCCC")]
    [InlineData(900, "CM")]
    public void ConvertRomanForHundreds(int num, string expected)
    {
        Assert.Equal(expected, Roman.ConvHundreds(num));
    }



    [Theory()]
    [InlineData(1974, "MCMLXXIV")]
    [InlineData(2000, "MM")]
    [InlineData(522, "DXXII")]
    [InlineData(3, "III")]
    public void ConvertRomanForAll(int num, string expected)
    {
        Assert.Equal(expected, Roman.ConvertRomanForAll(num));
    }



}