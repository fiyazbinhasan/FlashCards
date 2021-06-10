using FlashCards.Store.DecksUseCase;
using Fluxor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FlashCards.Shared
{
    public partial class DecksMenu
    {
        private string DeckTitle { get; set; } = string.Empty;
        private bool AutoFocus { get; set; } = false;

        [Inject]
        private IState<DecksState> DecksState { get; set; }

        [Inject]
        private IDispatcher Dispatcher { get; set; }

        private void AddDeck(KeyboardEventArgs e)
        {
            if (e.Code == "Enter" || e.Code == "NumpadEnter")
            {
                Dispatcher.Dispatch(new AddDeckAction(new Deck(Guid.NewGuid(), DeckTitle)));
                HideAddDeck();
                DeckTitle = string.Empty;
            }
        }

        private void HideAddDeck()
        {
            Dispatcher.Dispatch(new HideAddDeckAction());
        }

        protected override Task OnInitializedAsync()
        {
            if (!DecksState.Value.Decks.Any())
                AutoFocus = true;

            return base.OnInitializedAsync();
        }
    }
}