using System.Collections.Immutable;
using Fluxor;
using System.Linq;

namespace FlashCards.Store.CardsUseCase
{
    public class Reducers
    {
        [ReducerMethod]
        public static CardsState ReduceAddCardAction(CardsState state, AddCardAction action) =>
            state with { Cards = state.Cards.Add(action.Card) };

        [ReducerMethod]
        public static CardsState ReduceGetCardsAction(CardsState state, GetCardsAction action) =>
            state with { Cards = action.Cards.ToImmutableList() };

        [ReducerMethod]
        public static CardsState ReduceDeleteCardAction(CardsState state, DeleteCardAction action) =>
            state with { Cards = state.Cards.Where(c => c.Id != action.CardId).ToImmutableList() };

        [ReducerMethod]
        public static CardsState ReduceEditCardAction(CardsState state, EditCardAction action)
        {
            var card = state.Cards.FirstOrDefault(c => c.Id.Equals(action.Card.Id));

            return card != null
                ? state with
                {
                    Cards = state.Cards.Replace(card,
                        card with {Front = action.Card.Front, Back = action.Card.Back})
                }
                : state;
        }

        [ReducerMethod]
        public static CardsState ReduceFilterCardAction(CardsState state, FilterCardAction action) =>
            state with { Filter = action.Query };

        [ReducerMethod]
        public static CardsState ReduceShowCardBackAction(CardsState state, ShowCardBackAction action) =>
            state with { ShowBack = action.ShowBack };
    }
}