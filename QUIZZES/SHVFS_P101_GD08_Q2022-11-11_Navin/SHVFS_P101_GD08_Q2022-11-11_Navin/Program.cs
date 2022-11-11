namespace P101_Quiz2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int goCount = 5;
            var goArray = new GameObject[5];

            var go1 = new GameObject("1", new Position());
            var go2 = new GameObject("2", new Position());
            var go3 = new GameObject("3", new Position());
            var go4 = new GameObject("4", new Position());
            var go5 = new GameObject("5", new Position());

            goArray[0] = go1;
            goArray[1] = go2;
            goArray[2] = go3;
            goArray[3] = go4;
            goArray[4] = go5;

            for (int i = 0; i < goArray.Length; i++)
            {
                for (int j = 0; j < goArray.Length; j++)
                {
                    if (i == j) continue;

                    if (goArray[i].CheckMatchingPsition(goArray[j]))
                }
            }
                
            


        }
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
            public string Name;
            public Position Position


         

        }

        

    }
   



}