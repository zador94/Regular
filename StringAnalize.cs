using System.Text.RegularExpressions;

namespace RegularWord;

public class StringAnalize
{
    private string patternRegExp;
    

    public StringAnalize(string patternRegExp = "")
    {
        this.patternRegExp = patternRegExp;
    }

    public string getPattern()
    {
        return this.patternRegExp;
    }

    public void setPattern(string newPattern)
    {
        this.patternRegExp = newPattern;
    }

    public bool matchNumberToPattern(string number)
    {
        Regex regex = new Regex(patternRegExp);
        
            return regex.IsMatch(number);
    }

    
}