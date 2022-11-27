using System.Text.RegularExpressions;

namespace Roll_Initiative
{
    public class InitiativeValue
    {
        private const string PLUS_SIGN = "+";
        private const string MINUS_SIGN = "-";
        //private static char[] MODIFIER_CHARS = new char[] { PLUS_SIGN[0], MINUS_SIGN[0] };

        private int value;
        private InitiativeModifier modifier;
        bool valid;

        public InitiativeValue(int v) : this(v, InitiativeModifier.Neutral) { }

        public InitiativeValue(int v, InitiativeModifier m)
        {
            value = v;
            modifier = m;
            valid = true;
        }

        public InitiativeValue(string s)
        {
            Regex initiativeExpression = new Regex(Constants.INITIATIVE_PATTERN);

            MatchCollection matches = initiativeExpression.Matches(s);

            if (matches.Count > 0)
            {
                List<string> valueAndMod = Split(matches[0].Value);
                value = Int32.Parse(valueAndMod[0]);
                if (valueAndMod.Count > 1)
                {
                    switch (valueAndMod[1])
                    {
                        case PLUS_SIGN:
                            modifier = InitiativeModifier.Plus;
                            break;
                        case MINUS_SIGN:
                            modifier = InitiativeModifier.Minus;
                            break;
                        default:
                            modifier = InitiativeModifier.Neutral;
                            break;
                    }
                }
                else
                {
                    modifier = InitiativeModifier.Neutral;
                }
                valid = true;
            }
            else
            {
                value = -1;
                modifier = InitiativeModifier.Neutral;
                valid = false;
            }
        }

        public bool IsValid()
        {
            return valid;
        }

        public int CompareTo(InitiativeValue other)
        {
            int intCompare = value.CompareTo(other.value);

            if (intCompare != 0)
            {
                return intCompare;
            }
            else
            {
                int myMod = (int)modifier;
                int otherMod = (int)(other.modifier);
                intCompare = myMod.CompareTo(otherMod);
                return intCompare;
            }
        }

        private List<string> Split(string numWithSymbol)
        {
            List<string> returnString = new List<string>();
            returnString.Add("");

            int i = 0;
            while (i < numWithSymbol.Length && numWithSymbol[i] >= '0' && numWithSymbol[i] <= '9')
            {
                returnString[0] += numWithSymbol[i++];
            }

            if (i < numWithSymbol.Length)
            {
                returnString.Add("");
                returnString[1] = "" + numWithSymbol[i];
            }

            return returnString;
        }
    }

    public enum InitiativeModifier
    {
        Minus = 0,
        Neutral = 1,
        Plus = 2
    }
}
