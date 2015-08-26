using System.IO;
using System.Linq;

namespace PlantingTrees
{
    public class KattisHandler
    {
        public int N;
        public int[] Trees;

        public KattisHandler(Stream ms)
        {
            var reader = new StreamReader(ms);

            N = ReadInt(reader);
            Trees = new int[N];

            for (int i = 0; i < N - 1; i++)
            {
                Trees[i] = ReadInt(reader);
            }
            Trees[N - 1] = ReadInt(reader);
        }

        public KattisHandler()
        {

        }

        public static int ReadInt(TextReader reader)
        {
            int result = reader.Read() - '0';
            var input = reader.Read();

            while (input >= '0' && input <= '9')
            {
                result = (result * 10) + input - '0';
                input = reader.Read();
            }

            return result;
        }

        public int Solve()
        {
            return Trees.OrderByDescending(t => t).Select((t, i) => t + i + 1).Max() + 1;
        }
    }
}