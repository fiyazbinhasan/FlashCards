using Fluxor;
using System;

namespace FlashCards.Store.CardsUseCase
{
    public class Feature : Feature<CardsState>
    {
        public override string GetName() => "Cards";

        protected override CardsState GetInitialState() => new CardsState(Array.Empty<Card>());
    }
}
