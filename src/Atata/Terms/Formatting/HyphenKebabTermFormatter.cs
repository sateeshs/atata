﻿using System.Linq;

namespace Atata.TermFormatting
{
    public class HyphenKebabTermFormatter : ITermFormatter
    {
        public string Format(string[] words)
        {
            return string.Join("‐", words.Select(x => x.ToLower()));
        }
    }
}
