namespace P101_Quiz2
{
    internal class Program
    {


        struct Position
        {
            public int X;
            public int Y;
            public int Z;

           

            public Position(int x, int y, int z)
            { 
                X = x;
                Y = y;
                Z = z;
            
            }


        }

        public class GameObject
        {
            string Name;

         

        }

        public static void Main(string[] args)
        {

            GameObject obj = new GameObject();
            Console.WriteLine("Hello! GoodBye!");
            Console.ReadLine();
        }


    }
   



}