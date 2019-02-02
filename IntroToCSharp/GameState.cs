using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    class GameState
    {
        public enum gameState { Warmup, InProgress, PostMatch };

        private gameState state;
        private bool playing;

        public gameState State
        {
            get
            {
                return state;
            }
            set
            {
                OnStateChanged(state);
                state = value;
            }
        }

        public bool OnStateChanged(gameState oldState)
        {
            if (oldState != state)
            {
                playing = true;
                return true;
            }
            return false;
        }
    }
}
