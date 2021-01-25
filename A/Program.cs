using System;

namespace A
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            String[] NAMES = { "Пешка", "Конь", "Слон", "Ладья", "Ферзь" };
            Chess_figure[] MAS = new Chess_figure[10];

            for (int i = 0; i < 10; i++)
            {
                MAS[i] = new Chess_figure();
                switch (i % 5)
                {
                    case 0: { MAS[i].Init(1, NAMES[i % 5]); }; break;
                    case 1: { MAS[i].Init(3, NAMES[i % 5]); }; break;
                    case 2: { MAS[i].Init(3, NAMES[i % 5]); }; break;
                    case 3: { MAS[i].Init(5, NAMES[i % 5]); }; break;
                    case 4: { MAS[i].Init(9, NAMES[i % 5]); }; break;
                }

            }



            int N = 10;
            for (int i = 0; i < N; i++)
            {
                MAS[i].Display();
            }



            for (int i = 0; i < N; i++)
            {

                String a = MAS[i].Name;

                for (int j = i + 1; j < N + 1; j++)
                {
                    String b = MAS[j].Name;
                    if (String.Compare(a,b)==0)
                    {
                        for (int z = j; z < N - 1; z++)
                        {
                            MAS[z] = MAS[z + 1];
                        }
                        N -= 1;
                    }
                }
            }

            Console.WriteLine("\n\nМассив после обработки\n\n");
            for (int i = 0; i < N; i++)
            {
                MAS[i].Display();
            }





            Chess_figure fig1 = new Chess_figure();
            fig1.Init(3, "Slon");
            Chess_figure fig2 = new Chess_figure();
            fig2.Init(3, "Queen");


            String str;
            //Параметр не инициолизирован
            fig1.getNameout(out str);
            Console.WriteLine(str);

            //Параметр инициолизирован
            fig2.getNameref(ref str);
            Console.WriteLine(str);






            Chess_Player Magnus = new Chess_Player();
            Magnus.playerInit("Magnus", 10, MAS, 1);


        }
    }
}
