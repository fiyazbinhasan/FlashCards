using System;
using System.Collections.Immutable;

namespace FlashCards.Store.DecksUseCase
{
    public record AddDeckAction(Deck Deck);
    public record GetDecksAction(IImmutableList<Deck> Decks);
    public record HideAddDeckAction();
    public record SelectDeckAction(Guid DeckId);
    public record ShowAddDeckAction();
}