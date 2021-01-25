using System;
namespace A
{
    public class Chess_Player
    {


        private int numbers;
        private String PlayerName;

        private int rank;




        public Chess_figure[] figures = new Chess_figure[16];
        public bool color = true;



        public void playerRead()
        {
            Console.WriteLine("Введите имя игрока");
            PlayerName = Console.ReadLine();


            Console.WriteLine("Введите разряд");
            rank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите колличество фигур");
            numbers = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbers; i++)
            {
                figures[i] = new Chess_figure();
                Console.WriteLine("\tВыберите фигуру\nОсталось выбрать: {0}\n", numbers - i);
                figures[i].Read();

            }
        }


        public void playerInit(String Pn, int numb, Chess_figure[] cf, int razryad)
        {
            PlayerName = Pn;
            numbers = numb;
            for (int i = 0; i < numbers; i++)
            {
                figures[i] = cf[i];
            }
            rank = razryad;
            color = false;
        }


        public void playerDisplay()
        {
            Console.WriteLine(PlayerName);
            Console.WriteLine(rank);
            if (color)
                Console.WriteLine("Играет Белыми\n");
            else
                Console.WriteLine("Играет Чёрными\n");

            Console.WriteLine("Колличество фигур  {0}\n", numbers);
            Console.WriteLine("Фигуры:\n");
            for (int i = 0; i < numbers; i++)
            {

                Console.WriteLine("{0})", i + 1);
                figures[i].Display();
            }
        }



        public void playerCompare(Chess_Player player)
        {
            Console.WriteLine("{0} VS {1}\n", PlayerName, player.PlayerName);


            if (player.rank < rank)
            {
                Console.WriteLine(" Победил {0} ", player.PlayerName);
            }
            if (player.rank > rank)
            {
                Console.WriteLine(" Победил {0} ", PlayerName);
            }
            if (player.rank == rank)
            {
                Console.WriteLine(" Ничья \n");
            }

        }
    }
}
