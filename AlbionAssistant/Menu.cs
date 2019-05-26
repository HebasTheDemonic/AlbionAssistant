using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbionAssistant
{
    public class Menu
    {
        public int CheckChoice(int maxOption, string Choice)
        {
            if (IsDouble(Choice))
            {
                if (IsInt32(Choice))
                {
                    int result = Convert.ToInt32(Choice);
                    if (maxOption < result || result <= 0)
                    {
                        throw new InputIsOutOfBoundsException($"Input must be between 1 and {maxOption}.");
                    }
                    return result;
                }
                else
                {
                    throw new InputIsNotAnIntegerException();
                }
            }
            else
            {
                throw new MustInputANumberException();
            }
        }

        public int CheckInput(string Choice)
        {
            if (IsDouble(Choice))
            {
                if (IsInt32(Choice))
                {
                    int result = Convert.ToInt32(Choice);
                    if (result < 0)
                    {
                        throw new InputIsOutOfBoundsException();
                    }
                    return result;
                }
                else
                {
                    throw new InputIsNotAnIntegerException();
                }
            }
            else
            {
                throw new MustInputANumberException();
            }
        }

        public bool IsDouble(string text)
        {
            Double num;
            bool isDouble = false;


            if (string.IsNullOrEmpty(text))
            {
                return isDouble;
            }

            isDouble = Double.TryParse(text, out num);

            return isDouble;
        }

        public bool IsInt32(string text)
        {
            Int32 num;
            bool isInt32 = false;


            if (string.IsNullOrEmpty(text))
            {
                return isInt32;
            }

            isInt32 = Int32.TryParse(text, out num);

            return isInt32;
        }
    }
}
