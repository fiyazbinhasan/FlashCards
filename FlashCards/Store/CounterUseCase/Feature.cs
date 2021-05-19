using Fluxor;

namespace FlashCards.Store.CounterUseCase
{
    public class Feature : Feature<CounterState>
    {
        public override string GetName() => "Counter";

        protected override CounterState GetInitialState() => new CounterState(0);
    }
}