using Fluxor;

namespace FlashCards.Store.DecksUseCase
{
    public class Reducers
    {
        [ReducerMethod]
        public static DecksState ReduceAddDeckAction(DecksState state, AddDeckAction action) =>
            state with { Decks = state.Decks.Add(action.Deck) };

        [ReducerMethod]
        public static DecksState ReduceGetDecksAction(DecksState state, GetDecksAction action) =>
            state with { Decks = action.Decks };

        [ReducerMethod]
        public static DecksState ReduceShowAddDeckAction(DecksState state, ShowAddDeckAction action) =>
            state with { AddingDeck = true };

        [ReducerMethod]
        public static DecksState ReduceHideAddDeckAction(DecksState state, HideAddDeckAction action) =>
            state with { AddingDeck = false };

        [ReducerMethod]
        public static DecksState ReduceSelectDeckAction(DecksState state, SelectDeckAction action) =>
            state with { SelectedDeckId = action.DeckId };
    }
}