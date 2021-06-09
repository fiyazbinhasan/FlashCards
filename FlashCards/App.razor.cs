﻿using Blazored.LocalStorage;
using FlashCards.Store.CardsUseCase;
using FlashCards.Store.DecksUseCase;
using Fluxor;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace FlashCards
{
    public partial class App
    {
        [Inject]
        private ILocalStorageService LocalStorage { get; set; }

        [Inject]
        private IDispatcher Dispatcher { get; set; }

        [Inject]
        private IState<CardsState> CardsState { get; set; }

        [Inject]
        private IState<DecksState> DecksState { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            var decks = await LocalStorage.GetItemAsync<Deck[]>("decks");
            var cards = await LocalStorage.GetItemAsync<Card[]>("cards");

            if (decks != null)
                Dispatcher.Dispatch(new GetDecksAction(decks));

            DecksState.StateChanged += DecksState_StateChanged; ;
            CardsState.StateChanged += CardsState_StateChanged;
        }

        private async void DecksState_StateChanged(object sender, DecksState e)
        {
            await LocalStorage.SetItemAsync("decks", e.Decks);
        }

        private async void CardsState_StateChanged(object sender, CardsState e)
        {
            await LocalStorage.SetItemAsync("cards", e.Cards);
        }
    }
}