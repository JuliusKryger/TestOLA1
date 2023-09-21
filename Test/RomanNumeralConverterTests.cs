using Xunit;
using App;  // Assuming your class library's name is 'App'.

namespace Test;

public class RomanNumeralConverterTests
{
    [Fact]
    public void TestToRoman()
    {
        var converter = new RomanNumeralConverter();
        
        Assert.Equal("I", converter.ToRoman(1));
        Assert.Equal("IV", converter.ToRoman(4));
        Assert.Equal("V", converter.ToRoman(5));
        Assert.Equal("IX", converter.ToRoman(9));
        Assert.Equal("X", converter.ToRoman(10));
        Assert.Equal("XL", converter.ToRoman(40));
        Assert.Equal("XC", converter.ToRoman(90));
        Assert.Equal("C", converter.ToRoman(100));
        Assert.Equal("CD", converter.ToRoman(400));
        Assert.Equal("D", converter.ToRoman(500));
        Assert.Equal("CM", converter.ToRoman(900));
        Assert.Equal("M", converter.ToRoman(1000));
        Assert.Equal("MMMCMXCIX", converter.ToRoman(3999));
    }
}