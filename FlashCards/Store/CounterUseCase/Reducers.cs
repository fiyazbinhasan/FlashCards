using Fluxor;

namespace FlashCards.Store.CounterUseCase
{
    public class Reducers
    {
        [ReducerMethod]
        public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action) => new CounterState(clickCount: state.ClickCount + 1);
    }
}