using System.Collections.Immutable;

namespace FlashCards.Store.DecksUseCase
{
    public record GetDecksAction(IImmutableList<Deck> Decks);
}