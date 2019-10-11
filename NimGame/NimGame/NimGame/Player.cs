using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimGame
{
    class Player
    {
        public enum PlayerTypes
        {
            NOBODY, PLAYER_1, PLAYER_2, STUPID_AI, CLEVER_AI
        }

        string name;
        PlayerTypes playerType;
        int winnings;

        //propertik
        public string Name { get => name;}
        internal PlayerTypes PlayerType { get => playerType;}
        public int Winnings { get => winnings; }

        //konstruktor
        public Player(string name, PlayerTypes playerType)
        {
            this.name = name;
            this.playerType = playerType;
            this.winnings = 0;
        }

        //Növeli eggyel a nyerések számát
        public void Wins()
        {
            this.winnings++;
        }

        //ToString metódus
        override public string ToString()
        {
            return $"{this.name} [{this.PlayerType}] W{this.winnings}";
        }

    }
}
