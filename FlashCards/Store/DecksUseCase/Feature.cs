using Fluxor;
using System;
using System.Collections.Immutable;

namespace FlashCards.Store.DecksUseCase
{
    public class Feature : Feature<DecksState>
    {
        public override string GetName() => "Decks";

        protected override DecksState GetInitialState() => new DecksState(ImmutableArray<Deck>.Empty, false, Guid.Empty);
    }
}