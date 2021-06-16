using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace FlashCards.Store.DecksUseCase
{
    public record DecksState(IImmutableList<Deck> Decks, bool AddingDeck, Guid SelectedDeckId);
    public record Deck(Guid Id, string Title);
}