using Fluxor;
using System;
using System.Linq;

namespace FlashCards.Store.DecksUseCase
{
    public class Reducers
    {
        [ReducerMethod]
        public static DecksState ReduceAddDeckAction(DecksState state, AddDeckAction action) => state with { Decks = state.Decks.Concat(new Deck[] { action.Deck }) };

        [ReducerMethod]
        public static DecksState ReduceGetDecksAction(DecksState state, GetDecksAction action) => state with { Decks = action.Decks ?? Array.Empty<Deck>() };
    }
}