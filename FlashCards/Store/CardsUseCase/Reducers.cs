using Fluxor;
using System.Linq;

namespace FlashCards.Store.CardsUseCase
{
    public class Reducers
    {
        [ReducerMethod]
        public static CardsState ReduceAddCardAction(CardsState state, AddCardAction action) => state with { Cards = state.Cards.Concat(new Card[] { action.Card }) };

        [ReducerMethod]
        public static CardsState ReduceEditCardAction(CardsState state, EditCardAction action)
        {
            var cards = state.Cards.Select(card =>
            {
                if (card.Id == action.Card.Id)
                    return card with { Front = action.Card.Front, Back = action.Card.Back };

                return card;
            });

            return state with { Cards = cards };
        }

        [ReducerMethod]
        public static CardsState ReduceGetCardsAction(CardsState state, GetCardsAction action) => state with { Cards = action.Cards };

        [ReducerMethod]
        public static CardsState ReduceDeleteCardAction(CardsState state, DeleteCardAction action) =>
            state with { Cards = state.Cards.Where(c => c.Id != action.CardId) };
    }
}