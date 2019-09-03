using System;
using System.Media;

namespace PalcikasJatek
{
    class Program
    {
        static int stickCount;
        static string[] players;
        static int actPlayer;
        static int[] playerWins;
        const int TEXTBOX = 40;
        enum Orientation
        {
            RIGHT, LEFT, MIDDLE
        }       

        static void Main(string[] args)
        {           
            gameIni();

            do
            {
                matchIni();

                do
                {
                    display();
                    playerActing();
                    nextPlayer();

                } while (hasSticks());

                printResult(whichPlayerWon());
                setStatistics(whichPlayerWon());

            } while (morePlay());

            Console.Clear();
            printStatistics();

            Console.ReadKey();
        }

        private static void gameIni()
       {
            
            vonal('#', ConsoleColor.DarkRed);
            kiir("Üdvözöllek a NovaStick19 játékban!\n",Orientation.MIDDLE,ConsoleColor.Red);
            br();
            kiir("A cél, hogy megadott pálcikák közül az ellenfeled húzza az utolsót!!!\n", Orientation.LEFT, ConsoleColor.DarkRed);
            br();
            kiir("SZABÁLYOK:\n", Orientation.MIDDLE, ConsoleColor.Red);
            kiir("- Kötelező húzni!\n", Orientation.MIDDLE, ConsoleColor.DarkRed);
            kiir("- Maximum két pálcát lehet húzni!\n", Orientation.MIDDLE, ConsoleColor.DarkRed);
           
            kiir("Nyomj egy gombot a kezdéshez!\n", Orientation.MIDDLE, ConsoleColor.DarkRed);            
            Console.ReadKey();
            Console.Clear();

            players = inputPlayerNames();            

            playerWins = new int[2];
            for (int i = 0; i < playerWins.Length; i++)
            {
                playerWins[i] = 0;
            }          
        }

        private static void br()
        {
            Console.WriteLine();
        }

        private static void printStatistics()
        {
            bool allEqual = true;
            int k = 1;
            while (k < playerWins.Length && allEqual)
            {
                allEqual = playerWins[k] == playerWins[0];
                k++;
            }
            
            if (k >= playerWins.Length)
            {
                int max = playerWins[0];
                int maxID = 0;
                kiir("Az eredmény:\n",Orientation.LEFT,ConsoleColor.DarkRed);
                kiir("| ",Orientation.LEFT,ConsoleColor.Red);
                for (int i = 0; i < playerWins.Length; i++)
                {
                    kiir($"{players[i]}:{playerWins[i]} | ",Orientation.LEFT,ConsoleColor.Red);
                    if (max < playerWins[i])
                    {
                        max = playerWins[i];
                        maxID = i;
                    }                    
                }
                Console.Write("\n");               
                kiir("Az összesített győztes: ",Orientation.LEFT,ConsoleColor.DarkRed);
                
                kiir($"{players[maxID]}\n",Orientation.LEFT,ConsoleColor.Yellow);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                kiir("Az összesített eredmény: ",Orientation.LEFT,ConsoleColor.DarkRed);
                
                kiir("Döntetlen\n",Orientation.LEFT,ConsoleColor.Yellow);
            }            
            kiir("Köszönöm a játékot!",Orientation.MIDDLE,ConsoleColor.Red);
        }

        private static void setStatistics(int winnerID)
        {
            playerWins[winnerID]++;
        }

        private static bool morePlay()
        {
            ConsoleKeyInfo inputKey;
            do
            {
                kiir("Akartok még játszani? (I)gen/(N)em",Orientation.LEFT,ConsoleColor.DarkRed);
                inputKey = Console.ReadKey();

                switch (inputKey.KeyChar)
                {
                    case 'i':
                        return true;
                    case 'n':
                        return false;
                    default:                        
                        Console.Clear();
                        kiir("Csak i vag n karaktert adhatsz be!",Orientation.MIDDLE,ConsoleColor.Red);
                        playError();
                        break;
                }

            } while (true);
        }

        private static void playError()
        {
            Console.Beep(5000, 80);//C
            vonal('!',ConsoleColor.Red);
            System.Threading.Thread.Sleep(1000);
        }

        private static void playCow()
        {
            Console.Beep(1047, 200);//C
            Console.Beep(1319, 200);//E
            Console.Beep(1047, 200);//C
            Console.Beep(1319, 200);//E
            Console.Beep(1568, 400);//G
            Console.Beep(1568, 400);//G
        }

        private static int whichPlayerWon()
        {
            return actPlayer;
        }

        private static void printResult(int winnerID)
        {
            Console.Clear();
            kiir($"A győztes: ", Orientation.MIDDLE, ConsoleColor.DarkRed);
            kiir($"{players[winnerID]}\n", Orientation.MIDDLE, ConsoleColor.Yellow);
            
            playCow();
        }

        private static void playerActing()
        {
            stickCount -= playerGetSomeSticks();

        }

        private static int playerGetSomeSticks()
        {
            bool correctCount = false;
            ConsoleKeyInfo stickNumber = new ConsoleKeyInfo();
            do
            {
                kiir($"Vegyél el pár pálcikát, {players[actPlayer]}!\n", Orientation.MIDDLE, ConsoleColor.DarkRed);
                stickNumber = Console.ReadKey();

                if (stickNumber.KeyChar == '1' || stickNumber.KeyChar == '2')
                {
                    correctCount = true;
                }
                else
                {
                    Console.Clear();                    
                    kiir("Csak 1 vagy 2 pálcikát vehetsz el!\n",Orientation.MIDDLE,ConsoleColor.Red);
                    playError();
                    display();
                }
            } while (!correctCount);

            return Convert.ToInt32(stickNumber.KeyChar.ToString());
        }

        private static void nextPlayer()
        {
            if (actPlayer + 1 == players.Length)
            {
                actPlayer = 0;
            }
            else
            {
                actPlayer++;
            }
        }

        private static void display()
        {
            Console.Clear();
            string sticks= "";
            for (int i = 0; i < stickCount; i++)
            {
                sticks += "|";
            }
            kiir($"{sticks}\n" ,Orientation.MIDDLE, ConsoleColor.Red);            
        }

        private static bool hasSticks()
        {
            return stickCount > 0;
        }

        static void matchIni()
        {
            Console.Clear();            
            stickCount = new Random().Next(10, 13);
            actPlayer = new Random().Next(0, players.Length);
        }

        private static string[] inputPlayerNames()
        {
            string[] names = new string[2];

            for (int i = 0; i < names.Length; i++)
            {               
                kiir($"Kérlek {i + 1}. játékos add meg a neved: ",Orientation.LEFT,ConsoleColor.DarkRed);
                                
                names[i] = Console.ReadLine();
                Console.Clear();
            }

            return names;
        }
        static void kiir(string text, Orientation irany, ConsoleColor color)
        {
            if (text.Length > TEXTBOX)
            {                                
                kiir(text.Remove(TEXTBOX), irany, color);
                Console.Write("\n");
                kiir(text.Remove(0, TEXTBOX), irany, color);
            }
            else
            {

                Console.ForegroundColor = color;
                switch (irany)
                {
                    case Program.Orientation.RIGHT:
                        for (int i = 0; i < TEXTBOX - text.Length; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(text);
                        Console.ResetColor();
                        break;

                    case Program.Orientation.MIDDLE:
                        for (int i = 0; i < TEXTBOX / 2 - text.Length / 2; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(text);
                        Console.ResetColor();
                        break;

                    default:
                        Console.Write(text);
                        Console.ResetColor();
                        break;
                }
            }
        }
        static void vonal(char c, ConsoleColor color)
        {
            for (int i = 0; i < TEXTBOX; i++)
            {
                Console.ForegroundColor = color;
                Console.Write(c);
            }
            Console.WriteLine();
            Console.ResetColor();
        }

       
    }
}
