using FlashCards.Store.CardsUseCase;
using Fluxor;
using Microsoft.AspNetCore.Components;
using System;

namespace FlashCards.Pages
{
    public partial class Cards
    {
        [Inject]
        private IState<CardsState> CardsState { get; set; }

        [Inject]
        private IDispatcher Dispatcher { get; set; }

        private void AddCard()
        {
            Dispatcher.Dispatch(new AddCardAction(new Card(Guid.NewGuid(), "Front", "Back", 1)));
        }
    }
}