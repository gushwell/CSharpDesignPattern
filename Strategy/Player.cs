using System;

namespace Gushwell.Design.Patterns {

    public class Player {
        private string name;
        private IStrategy strategy;
        private int wincount;
        private int losecount;
        private int gamecount;

        // –¼‘O‚Æí—ª‚ğö‚¯‚ç‚ê‚é
        public Player(string name, IStrategy strategy) {
            this.name = name;
            this.strategy = strategy;
        }

        // í—ª‚É‚¨‚¤‚©‚ª‚¢‚ğ—§‚Ä‚é
        public Hand NextHand() {
            return strategy.NextHand();
        }

        // Ÿ‚Á‚½
        public void Win() {
            strategy.Study(true);
            wincount++;
            gamecount++;
        }

        // •‰‚¯‚½
        public void Lose() {
            strategy.Study(false);
            losecount++;
            gamecount++;
        }

        // ˆø‚«•ª‚¯
        public void Even() {
            gamecount++;
        }

        public override string ToString() {
            return "[" + name + ":" + gamecount + " games, " + 
                        wincount + " win, " + 
                        losecount + " lose" + "]";
        }
    }
}