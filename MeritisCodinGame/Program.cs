namespace MeritisCodinGame
{
    public class Tutorial
    {
        public static void Main(string[] args)
        {
            int[] ints = new int[1000];
            for(int i=0;i<1000;i++)
            {
                ints[i]=i;
            }
            Console.WriteLine(ints[500]);
        }
    }
}