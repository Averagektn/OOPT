namespace L2_1.Patterns.Behavior
{
    public class Observer : IObserver<Stake>
    {
        private IDisposable? unsubscriber;
        public int Bet { get; private set; }

        public virtual void Subscribe(IObservable<Stake> provider)
        {
            unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber?.Dispose();
        }

        public virtual void OnCompleted()
        {
            Unsubscribe();
        }

        public virtual void OnError(Exception error)
        {
            Unsubscribe();
        }

        public virtual void OnNext(Stake result)
        {
            if (result.bet == 0)
            {
                MessageBox.Show("LOSER! Result: " + result.sector.value + " " + result.sector.color.ToString());
            }
            else
            {
                MessageBox.Show("You won " + result.bet + ". Result: " + result.sector.value + " " + result.sector.color.ToString());
            }
            Bet = result.bet;
        }
    }
}
