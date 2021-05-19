using System.Collections.Generic;

namespace FlashCards.Store.CardsUseCase
{
    public record CardsState(IEnumerable<Card> Cards);

    public record Card(string Front, string Back);
}
