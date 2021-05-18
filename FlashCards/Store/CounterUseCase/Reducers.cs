using Fluxor;

namespace FlashCards.Store.CounterUseCase
{
    public class Reducers
    {
        [ReducerMethod]
        public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action) => state with { ClickCount = state.ClickCount + 1 };
    }
}