﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SharpDeck
{
    static class CodeTranslator
    {
        public static string Translate(Card card)
        {
            var rank = card.Rank;
            var suit = card.Suit;
            var rankString = Enum.GetName(typeof(Rank), rank);
            var suitString = Enum.GetName(typeof(Suit), suit);
            var sb = new StringBuilder();
            sb.Append(rankString);
            if (!card.IsJoker)
            {

                sb.Append(" of ");
                sb.Append(suitString);
            }
            return sb.ToString(); //"Ace of Spades", "Joker"
        }
    }
}
