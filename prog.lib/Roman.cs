using System.Text;

namespace prog.lib;
public static class Roman
{
    
    public static string ConvertRomanForAll(int num)
    {
        return ConvThousands(num) + ConvHundreds(num) + ConvTens(num) + ConvOnes(num);
    }

    public static string ConvOnes(int num)
    {
        const string one  = "I";
        const string five = "V";
        const string ten  = "X";

        var romanNumber = MakeRomanNumber(num, one, five, ten);

        return romanNumber;

    }
    public static string ConvTens(int num)
    {
        num = num / 10;  // get rid of the ones

        const string one  = "X";
        const string five = "L";
        const string ten  = "C";

        var romanNumber = MakeRomanNumber(num, one, five, ten);

        return romanNumber;


    }


    public static string ConvHundreds(int num)
    {

        num = num / 100; // get rid of the tens and ones

        const string one  = "C";
        const string five = "D";
        const string ten  = "M";

        var romanNumber = MakeRomanNumber(num, one, five, ten);

        return romanNumber;


    }


    public static string ConvThousands(int num)
    {
        StringBuilder str = new StringBuilder();
        var numThousand = num / 1000; // get rid of the hundreds and tens and ones

        for (var i = 1; i <= numThousand; i++)
        {
            str.Append("M");
        }

        return str.ToString();
    }



/// <summary>
/// This method is used to make the roman number/// 
/// The digits in num are parsed from left to right and eac digit is converted this way 
/// I use integer division and the modulus function to get the digit
/// </summary>
/// <param name="num">the number to be converted</param>
/// <param name="one">the one roman number</param>
/// <param name="five">the five roman number</param>
/// <param name="ten">the ten roman number</param>
/// <returns>the roman number</returns>

    private static string MakeRomanNumber(int num, string one, string five, string ten)
    {

        StringBuilder str = new StringBuilder();
        var numHundred = num % 10;


        var nine = one + ten;
        var four = one + five;

        if (numHundred == 9)
        {
            str.Append(nine);
        }
        else
        if (numHundred == 4)
        {
            str.Append(four);
        }
        else
        {
            if (numHundred >= 5)
            {
                str.Append(five);
                numHundred -= 5;
            }

            for (var i = 1; i <= numHundred; i++)
            {
                str.Append(one);
            }
        }

        return str.ToString();

    }




}
