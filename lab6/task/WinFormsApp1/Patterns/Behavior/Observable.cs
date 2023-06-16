namespace L2_1.Patterns.Behavior
{
    public readonly struct Sector
    {
        public enum Colors { Zero, Red, Black }
        private const int COLORS = 3;
        private const int VALUES = 37;
        public readonly Colors? color;
        public readonly int value;

        public Sector(Random random)
        {
            color = (Colors)(random.Next() % COLORS);
            value = random.Next() % VALUES;
        }

        public Sector(Colors? color, int value)
        {
            this.color = color; 
            this.value = value;
        }
    }

    public readonly struct Stake
    {
        public readonly Sector sector;
        public readonly int bet;
        public readonly bool? odd;
        public readonly bool colorBet;
        public Stake(Sector sector, int bet, bool? odd, bool colorBet)
        {
            this.sector = sector;
            this.bet = bet;
            this.odd = odd;
            this.colorBet = colorBet;
        }
    }

    internal class Observable : IObservable<Stake>
    {
        private class Unsubscriber : IDisposable
        {
            private readonly List<IObserver<Stake>> _observers;
            private readonly IObserver<Stake> _observer;

            public Unsubscriber(List<IObserver<Stake>> observers, IObserver<Stake> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null)
                {
                    _observers.Remove(_observer);
                }
            }
        }

        private readonly List<IObserver<Stake>> observers;

        public Observable()
        {
            observers = new List<IObserver<Stake>>();
        }

        public IDisposable Subscribe(IObserver<Stake> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }

            return new Unsubscriber(observers, observer);
        }

        public void Unsubscribe(IObserver<Stake> observer)
        {
            (new Unsubscriber(observers, observer)).Dispose();
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
            {
                foreach(var observer in observers)
                {
                    observer.OnNext(result);
                }
            }

        }
    }
}
