using Fluxor;
using System;

namespace FlashCards.Store.DecksUseCase
{
    public class Feature : Feature<DecksState>
    {
        public override string GetName() => "Decks";

        protected override DecksState GetInitialState() => new DecksState(Array.Empty<Deck>(), false);
    }
}