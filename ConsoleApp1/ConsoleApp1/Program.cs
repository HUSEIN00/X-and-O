using System;

namespace Game
{
    class Game
    {
        public String Player = "Player";
        public String Mashine = "Mashine";
        public String Draw = "Draw";
        public String PlayerCont = "X";
        public String MashineCont = "O";
        public int MashChose = 0;

        public Game(String Player = "Player", String Mashine = "Mashine", String PlayerCont = "X", String MashineCont = "O", String Draw = "Draw", int MashChose = 0)
        {
            this.Player = Player;
            this.Mashine = Mashine;
            this.PlayerCont = PlayerCont;
            this.MashineCont = MashineCont;
            this.Draw = Draw;
            this.MashChose = MashChose;
        }
        public void Victory(string name)
        {
            if (name == "Player")
            {
                Clear();
                Console.WriteLine("Вы выиграли");
                Console.WriteLine("Новая игра:");

            }
            else if (name == "Mashine")
            {
                Clear();
                Console.WriteLine("Вы проиграли");
                Console.WriteLine("Новая игра:");
            }
            else if (name == "Draw")
            {
                Clear();
                Console.WriteLine("Ничья");
                Console.WriteLine("Новая игра:");
            }
        }

        public void Clear()
        {
            for (int i = 0; i < 99; i++)
            {
                Console.WriteLine("\n");
            }
        }

        public void GameReset(String[] arr)
        {
            for (int i = 0; i < 9; i++)
            {
                arr[i] = (i + 1).ToString();
            }
        }



        public void MashineStep(String[] arr)
        {



            int countP = 0;


            for (int i = 0; i < 9; i++)
            {

                if (arr[i] == "X")
                {
                    countP++;
                }

                if (countP == 1 && arr[4] != "X")
                {
                    MashChose = 4;
                    arr[MashChose] = "O";



                }
                else if (arr[4] == "X")
                {
                    MashChose = 0;
                    arr[MashChose] = "O";


                }

            }

            bool yes = true;
            //vict row
            //0,1,2
            if (arr[0] == "O" && arr[1] == "O" && arr[2] != "X")
            {
                MashChose = 2;
                arr[MashChose] = "O";
                yes = false;

            }
            else if (arr[1] == "O" && arr[2] == "O" && arr[0] != "X")
            {
                MashChose = 0;
                arr[MashChose] = "O";
                yes = false;
            }
            else if (arr[0] == "O" && arr[2] == "O" && arr[1] != "X")
            {
                MashChose = 1;
                arr[MashChose] = "O";
                yes = false;
            }
            //3,4,5
            else if (arr[3] == "O" && arr[4] == "O" && arr[5] != "X")
            {
                MashChose = 5;
                arr[MashChose] = "O";
                yes = false;
            }
            else if (arr[4] == "O" && arr[5] == "O" && arr[3] != "X")
            {
                MashChose = 3;
                arr[MashChose] = "O";
                yes = false;
            }
            else if (arr[3] == "O" && arr[5] == "O" && arr[4] != "X")
            {
                MashChose = 4;
                arr[MashChose] = "O";
                yes = false;
            }
            //6,7,8
            else if (arr[6] == "O" && arr[7] == "O" && arr[8] != "X")
            {
                MashChose = 8;
                arr[MashChose] = "O";
                yes = false;
            }
            else if (arr[7] == "O" && arr[8] == "O" && arr[6] != "X")
            {
                MashChose = 6;
                arr[MashChose] = "O";
                yes = false;
            }
            else if (arr[6] == "O" && arr[8] == "O" && arr[7] != "X")
            {
                MashChose = 7;
                arr[MashChose] = "O";
                yes = false;
            }

            //vict colm
            //0,3,6
            else if (arr[0] == "O" && arr[3] == "O" && arr[6] != "X")
            {
                MashChose = 6;
                arr[MashChose] = "O";
                yes = false;
            }
            else if (arr[3] == "O" && arr[6] == "O" && arr[0] != "X")
            {
                MashChose = 0;
                arr[MashChose] = "O";
                yes = false;
            }
            else if (arr[0] == "O" && arr[6] == "O" && arr[3] != "X")
            {
                MashChose = 3;
                arr[MashChose] = "O";
                yes = false;
            }

            //1,4,7
            else if (arr[1] == "O" && arr[4] == "O" && arr[7] != "X")
            {
                MashChose = 7;
                arr[MashChose] = "O";
                yes = false;
            }
            else if (arr[4] == "O" && arr[7] == "O" && arr[1] != "X")
            {
                MashChose = 1;
                arr[MashChose] = "O";
                yes = false;
            }
            else if (arr[1] == "O" && arr[7] == "O" && arr[4] != "X")
            {
                MashChose = 4;
                arr[MashChose] = "O";
                yes = false;
            }

            //2,5,8
            else if (arr[2] == "O" && arr[5] == "O" && arr[8] != "X")
            {
                MashChose = 8;
                arr[MashChose] = "O";
                yes = false;
            }
            else if (arr[5] == "O" && arr[8] == "O" && arr[2] != "X")
            {
                MashChose = 2;
                arr[MashChose] = "O";
                yes = false;
            }
            else if (arr[2] == "O" && arr[8] == "O" && arr[5] != "X")
            {
                MashChose = 5;
                arr[MashChose] = "O";
                yes = false;
            }

            //vict corner

            //0,4,8
            else if (arr[0] == "O" && arr[4] == "O" && arr[8] != "X")
            {
                MashChose = 8;
                arr[MashChose] = "O";
                yes = false;
            }
            else if (arr[4] == "O" && arr[8] == "O" && arr[0] != "X")
            {
                MashChose = 0;
                arr[MashChose] = "O";
                yes = false;
            }
            else if (arr[0] == "O" && arr[8] == "O" && arr[4] != "X")
            {
                MashChose = 4;
                arr[MashChose] = "O";
                yes = false;
            }

            //2,4,6
            else if (arr[2] == "O" && arr[4] == "O" && arr[6] != "X")
            {
                MashChose = 6;
                arr[MashChose] = "O";
                yes = false;
            }
            else if (arr[4] == "O" && arr[6] == "O" && arr[2] != "X")
            {
                MashChose = 2;
                arr[MashChose] = "O";
                yes = false;
            }
            else if (arr[2] == "O" && arr[6] == "O" && arr[4] != "X")
            {
                MashChose = 4;
                arr[MashChose] = "O";
                yes = false;
            }

            //block
            //0,1,2
            if (arr[0] == "X" && arr[1] == "X" && arr[2] != "O" && yes == true)
            {
                MashChose = 2;
                arr[MashChose] = "O";



            }
            else if (arr[1] == "X" && arr[2] == "X" && arr[0] != "O" && yes == true)
            {
                MashChose = 0;
                arr[MashChose] = "O";


            }
            else if (arr[0] == "X" && arr[2] == "X" && arr[1] != "O" && yes == true)
            {
                MashChose = 1;
                arr[MashChose] = "O";


            }

            //,3,4,5
            else if (arr[3] == "X" && arr[4] == "X" && arr[5] != "O" && yes == true)
            {
                MashChose = 5;
                arr[MashChose] = "O";

            }
            else if (arr[4] == "X" && arr[5] == "X" && arr[3] != "O" && yes == true)
            {
                MashChose = 3;
                arr[MashChose] = "O";

            }
            else if (arr[3] == "X" && arr[5] == "X" && arr[4] != "O" && yes == true)
            {
                MashChose = 4;
                arr[MashChose] = "O";


            }

            //6,7,8
            else if (arr[6] == "X" && arr[7] == "X" && arr[8] != "O" && yes == true)
            {
                MashChose = 8;
                arr[MashChose] = "O";

            }
            else if (arr[7] == "X" && arr[8] == "X" && arr[6] != "O" && yes == true)
            {
                MashChose = 6;
                arr[MashChose] = "O";

            }
            else if (arr[6] == "X" && arr[8] == "X" && arr[7] != "O" && yes == true)
            {
                MashChose = 7;
                arr[MashChose] = "O";


            }

            //0, 3 ,6
            else if (arr[0] == "X" && arr[3] == "X" && arr[6] != "O" && yes == true)
            {
                MashChose = 6;
                arr[MashChose] = "O";

            }
            else if (arr[3] == "X" && arr[6] == "X" && arr[0] != "O" && yes == true)
            {
                MashChose = 0;
                arr[MashChose] = "O";

            }
            else if (arr[0] == "X" && arr[6] == "X" && arr[3] != "O" && yes == true)
            {
                MashChose = 3;
                arr[MashChose] = "O";


            }
            //1, 4 ,7
            else if (arr[1] == "X" && arr[4] == "X" && arr[7] != "O" && yes == true)
            {
                MashChose = 7;
                arr[MashChose] = "O";

            }
            else if (arr[4] == "X" && arr[7] == "X" && arr[1] != "O" && yes == true)
            {
                MashChose = 1;
                arr[MashChose] = "O";

            }
            else if (arr[1] == "X" && arr[7] == "X" && arr[4] != "O" && yes == true)
            {
                MashChose = 4;
                arr[MashChose] = "O";


            }

            //2, 5 ,8
            else if (arr[2] == "X" && arr[5] == "X" && arr[8] != "O" && yes == true)
            {
                MashChose = 8;
                arr[MashChose] = "O";

            }
            else if (arr[5] == "X" && arr[8] == "X" && arr[2] != "O" && yes == true)
            {
                MashChose = 2;
                arr[MashChose] = "O";

            }
            else if (arr[2] == "X" && arr[8] == "X" && arr[5] != "O" && yes == true)
            {
                MashChose = 5;
                arr[MashChose] = "O";



            }

            //0,4,8
            else if (arr[0] == "X" && arr[4] == "X" && arr[8] != "O" && yes == true)
            {
                MashChose = 8;
                arr[MashChose] = "O";

            }
            else if (arr[4] == "X" && arr[8] == "X" && arr[0] != "O" && yes == true)
            {
                MashChose = 0;
                arr[MashChose] = "O";

            }
            else if (arr[0] == "X" && arr[8] == "X" && arr[4] != "O" && yes == true)
            {
                MashChose = 4;
                arr[MashChose] = "O";


            }
            else if (arr[0] == "X" && arr[8] == "X" && arr[4] == "O" && yes == true)
            {
                if (arr[2] != "X" && arr[2] != "O")
                {
                    MashChose = 2;
                    arr[MashChose] = "O";

                }
                else if (arr[6] != "X" && arr[6] != "O")
                {
                    MashChose = 6;
                    arr[MashChose] = "O";


                }


            }
            //2,4,6
            else if (arr[2] == "X" && arr[4] == "X" && arr[6] != "O" && yes == true)
            {
                MashChose = 6;
                arr[MashChose] = "O";

            }
            else if (arr[4] == "X" && arr[6] == "X" && arr[2] != "O" && yes == true)
            {
                MashChose = 2;
                arr[MashChose] = "O";

            }
            else if (arr[2] == "X" && arr[6] == "X" && arr[4] != "O" && yes == true)
            {
                MashChose = 4;
                arr[MashChose] = "O";


            }
            else if (arr[2] == "X" && arr[6] == "X" && arr[4] == "O" && yes == true)
            {
                if (arr[0] != "X" && arr[0] != "O")
                {
                    MashChose = 0;
                    arr[MashChose] = "O";

                }
                else if (arr[8] != "X" && arr[8] != "O")
                {
                    MashChose = 8;
                    arr[MashChose] = "O";

                }


            }
            //1,5=2
            else if (arr[1] == "X" && arr[5] == "X" && yes == true)
            {

                if (arr[2] != "O" && arr[2] != "X")
                {
                    MashChose = 2;
                    arr[MashChose] = "O";

                }
                else if (arr[2] == "O" && arr[2] == "X")
                {
                    MashChose = 6;
                    arr[MashChose] = "O";

                }


            }

            //1,3=0
            else if (arr[1] == "X" && arr[3] == "X" && yes == true)
            {

                if (arr[0] != "X" && arr[0] != "O")
                {
                    MashChose = 0;
                    arr[MashChose] = "O";

                }
                else if (arr[0] == "X" && arr[0] == "O")
                {
                    MashChose = 8;
                    arr[MashChose] = "O";

                }

            }


            //3,7=6
            else if (arr[3] == "X" && arr[7] == "X" && yes == true)
            {

                if (arr[6] != "O" && arr[6] != "X")
                {
                    MashChose = 6;
                    arr[MashChose] = "O";

                }
                else if (arr[6] == "O" && arr[6] == "X")
                {
                    MashChose = 2;
                    arr[MashChose] = "O";

                }
            }

            //7,5=8
            else if (arr[7] == "X" && arr[5] == "X" && yes == true)
            {

                if (arr[8] != "O" && arr[8] != "X")
                {
                    MashChose = 8;
                    arr[MashChose] = "O";

                }
                else if (arr[8] == "O" && arr[8] == "X")
                {
                    MashChose = 0;
                    arr[MashChose] = "O";

                }
            }
            //1,7=6
            else if (arr[7] == "X" && arr[1] == "X" && arr[6] != "X" && yes == true)
            {
                MashChose = 6;
                arr[MashChose] = "O";
            }
            //3,5=8
            else if (arr[3] == "X" && arr[5] == "X" && arr[8] != "X" && yes == true)
            {
                MashChose = 8;
                arr[MashChose] = "O";
            }

            CheckGame(Mashine, MashineCont, arr);

        }


        public void PlayerStep(int chose, string name, string sign, String[] arr)
        {
            if (arr[chose - 1] != "O" && sign == "X")
            {
                arr[chose - 1] = sign;
            }
        }



        public void CheckGame(string name, string sign, String[] arr)
        {


            if (arr[0] == sign && arr[1] == sign && arr[2] == sign)
            {
                Victory(name);
                GameReset(arr);

            }
            else if (arr[3] == sign && arr[4] == sign && arr[5] == sign)
            {
                Victory(name);
                GameReset(arr);
            }
            else if (arr[6] == sign && arr[7] == sign && arr[8] == sign)
            {
                Victory(name);
                GameReset(arr);
            }
            //Бок
            else if (arr[0] == sign && arr[4] == sign && arr[8] == sign)
            {
                Victory(name);
                GameReset(arr);
            }
            else if (arr[2] == sign && arr[4] == sign && arr[6] == sign)
            {
                Victory(name);
                GameReset(arr);
            }
            //колонны
            else if (arr[0] == sign && arr[3] == sign && arr[6] == sign)
            {
                Victory(name);
                GameReset(arr);
            }
            else if (arr[1] == sign && arr[4] == sign && arr[7] == sign)
            {
                Victory(name);
                GameReset(arr);
            }
            else if (arr[2] == sign && arr[5] == sign && arr[8] == sign)
            {
                Victory(name);
                GameReset(arr);
            }
            else if (arr[0] != "1" && arr[1] != "2" && arr[2] != "3" && arr[3] != "4" && arr[4] != "5" && arr[5] != "6" && arr[6] != "7" && arr[7] != "8" && arr[8] != "9")
            {

                Victory(Draw);
                GameReset(arr);

            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            String[] arr = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Game gm = new Game();



            while (true)
            {

                Console.WriteLine($"[{arr[0]}] [{arr[1]}] [{arr[2]}]\n[{arr[3]}] [{arr[4]}] [{arr[5]}]\n[{arr[6]}] [{arr[7]}] [{arr[8]}]");
                Console.WriteLine();
                Console.Write("Введите ход: ");
                try
                {
                    int stepPlayer = int.Parse(Console.ReadLine());
                    gm.Clear();
                    gm.PlayerStep(stepPlayer, gm.Player, gm.PlayerCont, arr);
                    gm.CheckGame(gm.Player, gm.PlayerCont, arr);
                    gm.MashineStep(arr);

                }
                catch
                {

                }


            }

        }
    }
}
