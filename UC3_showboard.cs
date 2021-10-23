using System;
using System.Collections.Generic;
using System.Text;

namespace tiktactaoWorkshop
{
    class UC2
    {
        public char[] board = new char[10];
        public static char userLetter;
        public static char computerLatter;
        public const int HEAD = 1;
        public const int TAIL = 0;



        public  void CreateBoard()
        {
            for (int i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }
        }
    
       public static void ChooseLatter()
        {
            Console.WriteLine("choose your latter X or O");
            while(true)
            {
                userLetter = char.ToUpper(Console.ReadLine()[0]);
                
                if (userLetter !='X' && userLetter !='O')
                {
                    Console.WriteLine("invalid input : choose valid latter X or O");
                    continue;
                }
                break;
            }
            computerLatter = (userLetter == 'X') ? 'O' : 'X';
        }
    
        public  void ShowBoard()
        {
            Console.Write(" board");
            for (int i=1; i<10; i++)
            {
                Console.Write(board[i] + "|");
                if (i%3 ==0 && i!=9)
                {
                    Console.WriteLine("\n...............");
                    Console.Write("|");
                }
            }
        }
    
    }


    }
