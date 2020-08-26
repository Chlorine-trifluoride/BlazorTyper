using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTyper.Client
{
    public class TextManager
    {
        const string TEST_STRING = "Finally, the weekend has arrived. Not only is it the weekend, but it is Labor Day weekend. I’ve just received word from my boyfriend that he may be coming to Mobile to visit me tomorrow if the weather permits. I softly place the telephone back into its cradle and step outside to have an afternoon lounge on the balcony of my apartment. The glass door glides open, and my bare feet brushes against the smooth concrete of the balcony. I squint as my eyes readjust to the beams of sunlight shining down from above and bathing my skin with its warm, golden rays. I arrange myself on the sturdy seat of my lone, wooden chair and let my eyes slowly drift down into the courtyard below.";
        public static ColorCharacter[] colorCharacters;

        public static int numCorrect = 0;
        public static int numInccorect = 0;

        public static int Points => numCorrect - numInccorect;

        private static int index = 0;

        static TextManager()
        {
            colorCharacters = new ColorCharacter[TEST_STRING.Length];

            for (int i = 0; i < colorCharacters.Length; i++)
            {
                colorCharacters[i].c = TEST_STRING[i];
            }
        }

        public static void SetInput(KeyboardEventArgs args)
        {
            if (colorCharacters[index].c == args.Key.ToCharArray()[0])
            { // correct key
                colorCharacters[index].status = CHARACTER_STATUS.CORRECT;
                numCorrect++;
            }

            else
            {
                colorCharacters[index].status = CHARACTER_STATUS.INCORRECT;
                numInccorect++;
            }

            // increment our index
            index++;
        }
    }
}
