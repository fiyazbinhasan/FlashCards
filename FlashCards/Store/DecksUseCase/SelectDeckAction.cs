using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashCards.Store.DecksUseCase
{
    public record SelectDeckAction(Guid DeckId);
}
