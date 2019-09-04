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
        const ConsoleColor mainCl = ConsoleColor.DarkGreen;
        const ConsoleColor empCl = ConsoleColor.Magenta;
        const ConsoleColor errorCl = ConsoleColor.Red;
        const ConsoleColor headerCl = ConsoleColor.Cyan;
        const ConsoleColor mstImportantCl = ConsoleColor.Yellow;
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

            
            clearTextBox();
            printStatistics();

           Console.ReadKey();
        }

        private static void clearTextBox()
        {
            Console.Clear();
            print("NORADSTICK2019\n",Orientation.MIDDLE,mstImportantCl);
            printStripe('#',headerCl);
            Console.WriteLine();
        }

        private static void gameIni()
       {

            clearTextBox();
            print("Üdvözöllek a NoradStick2019 játékban!\n",Orientation.MIDDLE, mainCl);
            br();
            print("A cél, hogy megadott pálcikák közül az ellenfeled húzza az utolsót!!!\n", Orientation.LEFT, mainCl);
            br();
            print("SZABÁLYOK:\n", Orientation.MIDDLE, empCl);
            print("- Kötelező húzni!\n", Orientation.MIDDLE, mainCl);
            print("- Maximum két pálcát lehet húzni!\n", Orientation.MIDDLE, mainCl);
           
            print("Nyomj egy gombot a kezdéshez!\n", Orientation.MIDDLE, mainCl);            
            Console.ReadKey();
            clearTextBox();

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
            
            int k = 1;
            while (k < playerWins.Length && (playerWins[k] != playerWins[0]))
            {                 
                k++;
            }
            
            if (k >= playerWins.Length)
            {
                int max = playerWins[0];
                int maxID = 0;
                
                for (int i = 0; i < playerWins.Length; i++)
                {
                    if (max < playerWins[i])
                    {
                        max = playerWins[i];
                        maxID = i;
                    }                    
                }

                printFinalResult();
                print("És az istencsászár nem más mint, ",Orientation.LEFT, mainCl);
                
                print($"{players[maxID]}",Orientation.LEFT,mstImportantCl);
                print($"!!!\n\n", Orientation.LEFT, mainCl);
            }
            else
            {
                printFinalResult();
                print("Az összesített eredmény: \n",Orientation.MIDDLE,mainCl);                
                print("DÖNTETLEN\n\n",Orientation.MIDDLE,mstImportantCl);
            }            
            print("Köszönöm a játékot!\n",Orientation.MIDDLE,mainCl);
            print("Üss le egy gombot a bezáráshoz.\n\n", Orientation.MIDDLE, mainCl);
        }

        private static void printFinalResult()
        {
            print("Az eredmény:\n", Orientation.MIDDLE, mainCl);

            string eredmenyTxt = "|";
            for (int i = 0; i < playerWins.Length; i++)
            {
                eredmenyTxt += $" {players[i]}:{playerWins[i]} |";
            }
            print($"{eredmenyTxt}\n\n", Orientation.MIDDLE, empCl);
     
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
                print("Akartok még játszani? (I)gen/(N)em",Orientation.MIDDLE,mainCl);
                inputKey = Console.ReadKey();

                switch (inputKey.KeyChar)
                {
                    case 'i':
                        return true;
                    case 'n':
                        return false;
                    default:
                        clearTextBox();
                        print("Csak 'i' vagy 'n' karaktert üthetsz le!\n",Orientation.MIDDLE,errorCl);
                        playError();
                        clearTextBox();
                        break;
                }
            } while (true);
        }

        private static void playError()
        {
            Console.Beep(5000, 80);//C
            printStripe('!',mstImportantCl);
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
            clearTextBox();
            print($"A győztes: \n", Orientation.MIDDLE, mainCl);
            print($"{players[winnerID]}\n\n", Orientation.MIDDLE, mstImportantCl);
            
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
                print($"Vegyél el pár pálcikát, {players[actPlayer]}!\n", Orientation.MIDDLE, mstImportantCl);
                stickNumber = Console.ReadKey();

                if (stickNumber.KeyChar == '1' || stickNumber.KeyChar == '2')
                {
                    correctCount = true;
                }
                else
                {
                    clearTextBox();
                    print("Csak 1 vagy 2 pálcikát vehetsz el!\n",Orientation.MIDDLE,empCl);
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
            clearTextBox();
            string sticks= "";
            for (int i = 0; i < stickCount; i++)
            {
                sticks += "|";
            }
            print($"{sticks}\n\n" ,Orientation.MIDDLE, empCl);            
        }

        private static bool hasSticks()
        {
            return stickCount > 0;
        }

        static void matchIni()
        {
            clearTextBox();
            stickCount = new Random().Next(10, 13);
            actPlayer = new Random().Next(0, players.Length);
        }

        static string[] inputPlayerNames()
        {
            string[] names = new string[2];

            for (int i = 0; i < names.Length; i++)
            {               
                print($"Kérlek {i + 1}. játékos add meg a neved: ",Orientation.LEFT,mainCl);

                Console.ForegroundColor = mstImportantCl;
                names[i] = Console.ReadLine();                
                clearTextBox();
            }

            return names;
        }
        static void print(string text, Orientation irany, ConsoleColor color)
        {
            if (text.Length > TEXTBOX)
            {                                
                print(text.Remove(TEXTBOX), irany, color);
                Console.Write("\n");
                print(text.Remove(0, TEXTBOX), irany, color);
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
        static void printStripe(char c, ConsoleColor color)
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
