using System;
using System.Collections.Generic;

namespace FlashCards.Store.DecksUseCase
{
    public record DecksState(IEnumerable<Deck> Decks);
    public record Deck(Guid Id, string Name);
}