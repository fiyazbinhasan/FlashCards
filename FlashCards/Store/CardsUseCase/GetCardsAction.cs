using System.Collections.Immutable;

namespace FlashCards.Store.CardsUseCase
{
    public record GetCardsAction(IImmutableList<Card> Cards);
}