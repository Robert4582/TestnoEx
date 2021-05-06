using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRogue
{
    public static class TurnManager
    {
        public static int Actors;
        static int currentActor;

        public static int CurrentActor { get => currentActor; }

        public static void NextTurn()
        {
            currentActor = (currentActor + 1) % Actors;
        }
        public static bool IsMyTurn(int queuePosition)
        {
            return queuePosition == currentActor;
        }
        public static void Clear()
        {
            currentActor = 0;
            Actors = 0;
        }

    }
}
