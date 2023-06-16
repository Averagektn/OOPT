using System;

namespace L2_1.Patterns.Behavior
{
    public class Roulette
    {
        public delegate void BetEventDelegate(Stake stake);
        public event BetEventDelegate? BetEvent;

        public void Subscribe(BetEventDelegate newEvent)
        {
            BetEvent += newEvent;
        }

        public void Unsubscribe(BetEventDelegate newEvent)
        {
            BetEvent -= newEvent;
        }

        public void Bet(Stake stake)
        {
            int win = 0;
            Sector realSector = new(new Random());
            if (stake.odd != null && ((realSector.value % 2 == 1 && (bool)stake.odd) || (realSector.value % 2 == 0 && !(bool)stake.odd)))
            {
                win += stake.bet * 2;
            }
            if (stake.sector.value == realSector.value)
            {
                win += stake.bet * 5;
            }
            if (stake.colorBet && stake.sector.color == realSector.color)
            {
                win += stake.bet * 2;
                if (stake.sector.color == Sector.Colors.Zero)
                {
                    win += stake.bet * 10;
                }
            }

            Stake result = new(realSector, win, true, true);

            BetEvent?.Invoke(result);


        }
    }
}
