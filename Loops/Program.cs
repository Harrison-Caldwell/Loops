using System;

namespace Loops
{
    class Program
    {
        static int positionx = 0;
        static int positiony = 0;



        static void Main(string[] args)
        {
            //Console.WriteLine("Loops: ");
            

            //for (int i = 1; i <= 10; i = i + 1)
            {
                //Console.WriteLine(i);
            }

            bool gameOver = false;




            void PlayerUpdate()
            {
                


                ConsoleKeyInfo readkeyinput = Console.ReadKey(true);
                

                if (readkeyinput.Key == ConsoleKey.W)
                {
                    positiony = positiony - 1;
                }
                if (readkeyinput.Key == ConsoleKey.A)
                {
                    positionx = positionx - 1;
                }
                if (readkeyinput.Key == ConsoleKey.D)
                {
                    positionx = positionx + 1;
                }
                if (readkeyinput.Key == ConsoleKey.S)
                {
                    positiony = positiony + 1;
                }

                if (positionx <= 0)
                {
                    positionx = 0;
                }
                if (positionx >= 60)
                {
                    positionx = 60;
                }
                if (positiony <= 0)
                {
                    positiony = 0;
                } 
                if (positiony >= 30)
                {
                    positiony = 30;
                }
                if (readkeyinput.Key == ConsoleKey.Escape)
                {
                    gameOver = true;
                }







            }


            void PlayerDraw(int X, int Y)
            {
                Console.SetCursorPosition(positionx, positiony);
            }


            while (gameOver == false)
            {
                PlayerDraw(positionx, positiony);
                PlayerUpdate();
            }
        }





        

        
    }
}
