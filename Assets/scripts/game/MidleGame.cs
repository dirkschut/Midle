using System.Collections;
using System.Collections.Generic;

namespace game
{
    public class MidleGame
    {

        private static MidleGame game;
        public static MidleGame Game
        {
            get
            {
                if(game == null)
                {
                    game = new MidleGame();
                }
                return game;
            }
        }

        public MidleGame()
        {
            World = new World();
        }

        public World World;
    }
}