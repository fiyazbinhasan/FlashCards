using System;

namespace FlashCards.Store.CardsUseCase
{
    public record DeleteCardAction(Guid CardId);
}