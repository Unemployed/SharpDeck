using System;
using System.Collections.Generic;
using System.Text;

namespace SharpDeck
{
    static class CodeTranslator
    {
        #region Properties
        private static Dictionary<String, String> _valueMap;
        private static Dictionary<String, String> valueMap
        {
            get
            {
                if (_valueMap == null)
                {
                    SetupValueMap();
                }
                return _valueMap;
            }
        }
        #endregion

        #region Setup

        static void SetupValueMap()
        {
            _valueMap = new Dictionary<string, string>();
            _valueMap.Add("A", "Ace");
            _valueMap.Add("2", "Two");
            _valueMap.Add("3", "Three");
            _valueMap.Add("4", "Four");
            _valueMap.Add("5", "Five");
            _valueMap.Add("6", "Six");
            _valueMap.Add("7", "Seven");
            _valueMap.Add("8", "Eight");
            _valueMap.Add("9", "Nine");
            _valueMap.Add("10", "Ten");
            _valueMap.Add("J", "Jack");
            _valueMap.Add("K", "King");
            _valueMap.Add("Q", "Queen");
        }
        #endregion
        public static string Translate(Card card)
        {
            var val = card.Value;
            var suit = card.Suit;
            var sb = new StringBuilder();
            sb.Append(TranslateValue(val));
            sb.Append(" of ");
            sb.Append(TranslateRank(card.Code[card.Code.Length - 1]));
            return sb.ToString();
        }
        private static string TranslateValue(string Val)
        {

            return valueMap[Val];
        }
        private static string TranslateRank(char rankChar)
        {
            switch (rankChar)
            {
                case 'H':
                    return "Hearts";
                case 'D':
                    return "Diamonds";
                case 'C':
                    return "Clubs";
                case 'S':
                    return "Spades";
                default:
                    return "";
            }
        }
    }
}
