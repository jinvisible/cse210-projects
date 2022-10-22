using System;

namespace Unit02.Game {
    public class Card {
        public Card() {

        }
        public int draw(){
            Random random = new Random();
            int _value = random.Next(1, 13);
            return _value;
        }
    }
}