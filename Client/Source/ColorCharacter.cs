using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTyper.Client
{
    public enum CHARACTER_STATUS
    {
        UNDEFINED = 0,
        CORRECT = 1,
        INCORRECT = 2
    }

    public struct ColorCharacter
    {
        public char c;
        public CHARACTER_STATUS status;
        public string color;

        public ColorCharacter(char c, string color)
        {
            this.c = c;
            this.color = color;
            this.status = CHARACTER_STATUS.UNDEFINED;
        }

        public string GetColor()
        {
            switch (status)
            {
                case CHARACTER_STATUS.UNDEFINED:
                    return "black";

                case CHARACTER_STATUS.CORRECT:
                    return "green";

                case CHARACTER_STATUS.INCORRECT:
                    return "red";
            }

            return "black";
        }

        public string GetSpaceColor()
        {
            switch (status)
            {
                case CHARACTER_STATUS.UNDEFINED:
                    return "white";

                case CHARACTER_STATUS.CORRECT:
                    return "green";

                case CHARACTER_STATUS.INCORRECT:
                    return "red";
            }

            return "white";
        }
    }
}
