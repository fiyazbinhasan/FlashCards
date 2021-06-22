using System;
using System.Collections.Immutable;

namespace FlashCards.Store.CardsUseCase
{
    public record AddCardAction(Card Card);
    public record DeleteCardAction(Guid CardId);
    public record FilterCardAction(string Query);
    public record GetCardsAction(IImmutableList<Card> Cards);
    public record SetShowBackAction(bool ShowBack);
    public record UpdateCardAction(Card Card);
}