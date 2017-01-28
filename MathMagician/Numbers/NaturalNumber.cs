using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        //This an example of a Property:
        private int First { get; set; }

        //This is an example of a Constructor:
        public NaturalNumber()
        {
            First = 1;
            // this.First = 1;
            // Writing the above says the same thing. 
            // Test it out and see what happens (notice the grey-out)
        }

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            // 'current' argument is read-only
            // meaning you can't change it... I don't know exactly why that is.

            // I originally wrote:
            /*
            current = current + 1;
            return current;
            */
            // But this can be more easilyt written as:

            return current + 1;

        }

        public int[] GetSequence(int how_many)
        {
            int[] inputCounter = new int[how_many];

            for (int i = 0; i <= how_many; i++)
            {
                inputCounter[i] = i + 1;
                // Writing like this, 
                // I can avoid creating a counter variable set to zero initially,
                // which is how I've handled previous similar problems. 

                // Side note to future Mike:
                // For even numbers class, this can be edited to i + 2
                // OR, maybe do i % 2 = 0.... that might be in the even number test, though.


                // In class, this was the example:
                /* 
                int[] numbers = new int[how_many];

                numbers[0] = GetFirst(); // --> i = 1
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = GetNext(number[i-1]);
                }

                return numbers;
                */

            }

            return inputCounter;
            //cannot implicitly convert int to int[]
        }

        public string printNumbers(int[] how_many)
        {
            return String.Join(" ", how_many);
            // or this could be a WriteLine function...
            // Program.cs will print this out, so the Console.WriteLine can be written there.

            /*
                return String.Join(" ", number_array); 
            */ 
        }

        // WHY IS THIS HERE?
        int Integer.GetSequence(int how_many)
        {
            throw new NotImplementedException();
        }
    }
}
