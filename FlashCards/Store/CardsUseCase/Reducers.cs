using Fluxor;
using System.Linq;

namespace FlashCards.Store.CardsUseCase
{
    public class Reducers
    {
        [ReducerMethod]
        public static CardsState ReduceAddCardAction(CardsState state, AddCardAction action) => state with { Cards = state.Cards.Concat(new Card[] { action.Card }) };
    }
}
