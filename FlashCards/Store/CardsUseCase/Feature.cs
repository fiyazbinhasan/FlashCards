using Fluxor;
using System;
using System.Collections.Immutable;

namespace FlashCards.Store.CardsUseCase
{
    public class Feature : Feature<CardsState>
    {
        public override string GetName() => "Cards";

        protected override CardsState GetInitialState() => new CardsState(ImmutableArray<Card>.Empty, string.Empty, false);
    }
}