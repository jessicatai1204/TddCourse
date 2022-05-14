using System.Text;

namespace TDD;
/// <summary>
///a > A
///abc > A-Bb-Ccc
///A-> A
///ABC ->A-Bb-Ccc
///aBc -> A-Bb-Ccc
///-a > --A
///aa > A-Aa
/// ""->""
///
/// 大小寫轉換,重複
///not 英文 : 自己做重複 (含空白)
///-連接
///length not limit


///string -> string 
/// </summary>

public class BlackBox
{
    public string Transfer(string input)
    {
        if (input.Equals(String.Empty))
        {
            return "";
        }

        
        var resultStringList = new List<string>();
        var charList = input.ToCharArray();
        for (int i = 0; i < charList.Length; i++)
        {
            resultStringList.Add(Repeat(charList[i],i+1));
        }

        return  String.Join("-", resultStringList);
    }

    private string Repeat(char inputChar,int times)
    {
        var resultStringList = new StringBuilder();
        string outChar = "";
        for (int i = 0; i < times; i++)
        {
            if (i == 0)
            {
                outChar = inputChar.ToString().ToUpper();
            }
            else
            {
                outChar = inputChar.ToString().ToLower();
            }
            resultStringList.Append(outChar);
        }

        return resultStringList.ToString();
    }
}