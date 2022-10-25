using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace KataLab
{
    public class DiamondKata
    {

        char[] Alphabet { get; set; } = new char[26];

        public DiamondKata()
        {
            Alphabet[0] = 'A';
            Alphabet[1] = 'B';
            Alphabet[2] = 'C';
            Alphabet[3] = 'D';
            Alphabet[4] = 'E';
            Alphabet[5] = 'F';
            Alphabet[6] = 'G';
            Alphabet[7] = 'H';
            Alphabet[8] = 'I';
            Alphabet[9] = 'J';
            Alphabet[10] = 'K';
            Alphabet[11] = 'L';
            Alphabet[12] = 'M';
            Alphabet[13] = 'N';
            Alphabet[14] = 'O';
            Alphabet[15] = 'P';
            Alphabet[16] = 'W';
            Alphabet[17] = 'R';
            Alphabet[18] = 'S';
            Alphabet[19] = 'T';
            Alphabet[20] = 'U';
            Alphabet[21] = 'V';
            Alphabet[22] = 'W';
            Alphabet[23] = 'X';
            Alphabet[24] = 'Y';
            Alphabet[25] = 'Z';
        }

        public List<string> CreateDiamond(char input)
        {
            List<string> output = new List<string>();

            if (input == 'A')
            {
                //The diamond's starting character is A, no matter what.
                //So, if the user inputs A, A is all that need be returned.
                output.Add("A");
                return output;
            }
            else if (input > 'A')
            {
                //initializing necessary variables to be used by loops
                int indexValue = Array.IndexOf(Alphabet, input);

                double diamondArea = (4 * (0.5 * (indexValue + 1) * (indexValue + 1)));

                double diamondDiagonal = ((2 * diamondArea) / ((indexValue + 1) * 2)) - 1;

                int middlePos = Convert.ToInt32(Math.Ceiling(diamondDiagonal / 2)) - 1;

                char[] blankLine = new char[Convert.ToInt32(diamondDiagonal)];

                //creating a blank *template* line to insert into
                for (int i = 0; i < diamondDiagonal; i++)
                {
                    blankLine[i] = '·';
                }

                //Converts the blankLine charArray to a string
                string blankString = string.Join("", blankLine);

                //iterating over template line, including values where necessary
                //iterates up to the index value indicated, including alphabetical values to the left and right of middle
                for (int i = 0; i < indexValue+1; i++)
                {
                    string temp1 = ReplaceAt(blankString, middlePos - i, Alphabet[i]);
                    string updatedString = ReplaceAt(temp1, middlePos + i, Alphabet[i]);
                    output.Add(updatedString);
                }

                //iterating over template line, including values where necessary
                //iterates down from the index value indicated, including alphabetical values to the left and right of middle
                for (int i = indexValue-1; i > -1; i--)
                {
                    string temp1 = ReplaceAt(blankString, middlePos - i, Alphabet[i]);
                    string updatedString = ReplaceAt(temp1, middlePos + i, Alphabet[i]);
                    output.Add(updatedString);
                }

                return output;
            }
            else
            {
                //If implemented in an actual program, I'd have an option to loop back,
                //prompting the user for more input here if input == invalid.
                //As it is, I just have this returning output as blank to make the method happy.
                Console.WriteLine("I'm sorry, please enter a alphabetical character.");
                return output;
            }
            

        }

        //Method to print the diamond, if this program were implemented in main
        public void PrintDiamond(List<string> output)
        {
            foreach (string item in output)
            {
                Console.WriteLine(item);
            }
        }

        //Method to create a new string with the desired new char at the desired index
        //Converts input string into a charArray to make it easier to insert these values
        public string ReplaceAt(string input, int index, char newChar)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }
            char[] chars = input.ToCharArray();
            chars[index] = newChar;
            return new string(chars);
        }

    }
}
