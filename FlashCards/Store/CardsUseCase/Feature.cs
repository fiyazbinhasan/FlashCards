using Fluxor;
using System.Collections.Immutable;

namespace FlashCards.Store.CardsUseCase
{
    public class Feature : Feature<CardsState>
    {
        public override string GetName() => "Cards";

        protected override CardsState GetInitialState() => new(ImmutableArray<Card>.Empty, string.Empty, false);
    }
}