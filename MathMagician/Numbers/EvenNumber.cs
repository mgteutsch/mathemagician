using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    class EvenNumber : Integer //NaturalNumber?
    {
        private int First { get; set; }
        
        public EvenNumber()
        {
            this.First = 2;
        }

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            return current + 2;
        }

        public int[] GetSequence(int how_many)
        {
            int[] inputCounter = new int[how_many];

            for (int i = 0; i < inputCounter.Length; i++)
            {
                inputCounter[i] = i + 2;
            }

            return inputCounter[];
        }

        public string printNumbers(int[] how_many)
        {
            return String.Join(" ", how_many);
        }

        // WHY IS THIS HERE?
        int Integer.GetSequence(int how_many)
        {
            throw new NotImplementedException();
        }
    }
}
