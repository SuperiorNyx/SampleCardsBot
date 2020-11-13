using Microsoft.Bot.Builder.AI.QnA;

namespace SampleCardsBot
{
    public interface IBotServices
    {
        QnAMaker QnAMakerS { get; }
    }
}
