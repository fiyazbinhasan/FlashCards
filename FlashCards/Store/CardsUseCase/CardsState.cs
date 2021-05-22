using System;
using System.Collections.Generic;

namespace FlashCards.Store.CardsUseCase
{
    public record CardsState(IEnumerable<Card> Cards);

    public record Card(Guid Id, string Front, string Back, int Score);
}