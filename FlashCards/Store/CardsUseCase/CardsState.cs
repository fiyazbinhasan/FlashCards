using System;
using System.Collections.Immutable;

namespace FlashCards.Store.CardsUseCase
{
    public record CardsState(IImmutableList<Card> Cards, string Filter, bool ShowBack);

    public record Card(Guid Id, string Front, string Back, int Score, DateTime? LastStudiedOn, Guid DeckId);
}