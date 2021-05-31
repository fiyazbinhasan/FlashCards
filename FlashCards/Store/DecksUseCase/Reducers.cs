using Fluxor;
using System.Linq;

namespace FlashCards.Store.DecksUseCase
{
    public class Reducers
    {
        [ReducerMethod]
        public static DecksState ReduceAddDeckAction(DecksState state, AddDeckAction action) => state with { Decks = state.Decks.Concat(new Deck[] { action.deck }) };
    }
}