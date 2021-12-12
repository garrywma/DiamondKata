using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Kata
    {
        /// <summary>
        /// The level in the Kata starts at 0
        /// </summary>
        public int Level { get; set; } = 0;

        public char GetCharAtCurrentLevel()
        {
            return (char)((int)'A' + Level);
        }

        public string GetEndStringForCurrentChar(char currentChar)
        {
            return ((currentChar != 'A') ? currentChar.ToString() : "");
        }

        public string GetGapAtCurrentLevel()
        {
            return Level > 0 ? new string(' ', (Level - 1) * 2 + 1) : "";
        }

        public string GetPaddingAtCurrentLevel(char endChar)
        {
            return new string(' ', endChar - GetCharAtCurrentLevel());
        }

        public string GetKataLevel(char endChar)
        {
            char currentChar = GetCharAtCurrentLevel();
            return GetPaddingAtCurrentLevel(endChar) + currentChar + GetGapAtCurrentLevel() + GetEndStringForCurrentChar(currentChar);
        }      

        public List<string> GetKata(char endChar)
        {
            List<string> kata = new List<string>();
            Level = 0;
            while (GetCharAtCurrentLevel() != endChar)
            {
                kata.Add(GetKataLevel(endChar));
                Level++;
            }
            while (Level >= 0)
            {
                kata.Add(GetKataLevel(endChar));
                Level--;
            }
            return kata;
        }
    }
}
