using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG001
{
    class Program
    {
        static STARTSELECT StartSelect()
        {
            
            Console.WriteLine("1. Town");
            Console.WriteLine("2. Battle");
            Console.WriteLine("3. Start Page");

            ConsoleKeyInfo CK1 = Console.ReadKey();
            Console.WriteLine("");
            switch (CK1.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Go to Town");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.D2:
                    Console.WriteLine("Start the battle");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
                default:
                    Console.WriteLine("Wrong Selection");
                    Console.ReadKey();
                    return STARTSELECT.NONSELECT;
                    
            }

        }
        //Error must be included in the ENUM
        enum STARTSELECT
        {
            SELECTTOWN,
            SELECTBATTLE,
            NONSELECT
        }

        static void Town(Player _Player)
        {
            _Player.StatusRender();
            Console.WriteLine("Choose the option");
            Console.WriteLine("1. Restore the HP");
            Console.WriteLine("2. Reinforce the Weapon");
            Console.WriteLine("3. Exit town");



            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    
                    
                    _Player.MaxHeal();

                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("Weapons reinforced!");
                    break;
                case ConsoleKey.D3:
                    break;

            }
            Console.ReadKey();
        }

        static void Battle()
        {
            //Console.WriteLine("It is not open yet");
            //Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            while (true)
            {
                STARTSELECT SelectCheck = StartSelect();

                switch (SelectCheck)
                {
                    case STARTSELECT.SELECTTOWN:
                        Town(NewPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        Battle();
                        break;

                }
            }
            
        }
    }

    class Monster
    {

    }

    class Player
    {
        int AT = 10;
        int HP = 50;
        int MAXHP = 100;


        public void PrintHP()
        {
            Console.WriteLine("Current HP is: "+HP);
        }
        public void MaxHeal()
        {
            if (HP >= MAXHP)
            {
                Console.WriteLine("");
                Console.WriteLine("Your HP is already full!");
                Console.ReadKey();
            } else
            {
                HP = MAXHP;
                PrintHP();
            }
            

            
        }
        public void StatusRender()
        {
            Console.WriteLine("---------------------------");
            Console.Write("AT : ");
            Console.WriteLine(AT);


            Console.Write("HP : ");
            Console.Write(HP);
            Console.Write('/');
            Console.WriteLine(MAXHP);
            Console.WriteLine("---------------------------");
        }
    }


}
