using FlashCards.Store.CounterUseCase;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace FlashCards.Pages
{
    public partial class Counter
    {
        [Inject]
        private IState<CounterState> CounterState { get; set; }

        [Inject]
        private IDispatcher Dispatcher { get; set; }

        private void IncrementCount()
        {
            Dispatcher.Dispatch(new IncrementCounterAction());
        }
    }
}