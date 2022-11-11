

    namespace SHVFS_P101_GD08_Navin
    {
        public struct position
        {
            public float X;
            public float Y;
            public float Z;
            public position(float x, float y, float z)
            {
                X = x;
                Y = y;
                Z = z;

            }



        }

        public class posi
        {
            public position pos;
            public string name;

            public posi(string name, position pos)
            {
                this.pos = pos;
                this.name = name;
            }


            public bool CheckPosition(posi go)
            {
                if (go.pos.X == pos.X && go.pos.Y == pos.Y && go.pos.Z == pos.Z)
                {
                    return true;
                }
                return false;



            }




        }


        public class Program
        {



            public static void Main(string[] args)
            {



                posi[] go = new posi[5];
                go[0] = new posi("0", new position(0, 20, 60));
                go[1] = new posi("1", new position(10, 20, 60));
                go[2] = new posi("2", new position(20, 20, 60));
                go[3] = new posi("3", new position(0, 20, 60));
                go[4] = new posi("4", new position(100, 20, 60));
                for (int i = 0; i < go.Length - 1; i++)
                {

                    for (int j = i + 1; j < go.Length; j++)
                    {


                        if (go[i].CheckPosition(go[j]))

                        {

                            Console.WriteLine($"{go[i].name} and {go[j].name} have the same position");
                        }


                    }


                }



            }




        }







    }
