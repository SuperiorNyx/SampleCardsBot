using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Dialogs.Choices;
using Microsoft.Bot.Schema;
using Microsoft.Extensions.Logging;

namespace SampleCardsBot.Dialogs
{
    public class MainDialog : ComponentDialog
    {

        protected readonly ILogger _logger;
        public MainDialog(ILogger<MainDialog> logger)
            : base(nameof(MainDialog))
        {

            _logger = logger;

            // Define the main dialog and its related components.
            AddDialog(new ChoicePrompt(nameof(ChoicePrompt)));
            AddDialog(new WaterfallDialog(nameof(WaterfallDialog), new WaterfallStep[]
            {
                ChooseCardStepAsync,
                ShowCardStepAsync,
            }));

            InitialDialogId = nameof(WaterfallDialog);
        }
        private async Task<DialogTurnResult> ChooseCardStepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            _logger.LogInformation("MainDialog.ChoiceCardStepAsync");

            // Create the the prompt and re-prompt messages.
            var options = new PromptOptions()
            {
                Prompt = MessageFactory.Text("What card would you like to see? Click or type"),
                RetryPrompt = MessageFactory.Text("That was not a valid choice, please select a card or number from 1 to 9."),
                Choices = GetChoices(),
            };

            return await stepContext.PromptAsync(nameof(ChoicePrompt), options, cancellationToken);
        }

        private async Task<DialogTurnResult> ShowCardStepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            _logger.LogInformation("MainDialog.ShowCardStepAsync");

            // Cards are sent as Attachments in the Bot Framework.
            var attachments = new List<Attachment>();

            var reply = MessageFactory.Attachment(attachments);
            switch (((FoundChoice)stepContext.Result).Value)
            {
                case "Seattle":
                    // Display a HeroCard.
                    reply.Attachments.Add(Card.GetSeattleCard().ToAttachment());
                    break;
                case "Tokyo":
                    reply.Attachments.Add(Card.GetTokyoCard().ToAttachment());
                    break;
                case "New Delhi":
                    reply.Attachments.Add(Card.GetNewDelhiCard().ToAttachment());
                    break;
                case "Manila":
                    reply.Attachments.Add(Card.GetManilaCard().ToAttachment());
                    break;
                case "New York":
                    reply.Attachments.Add(Card.GetNewYorkCard().ToAttachment());
                    break;
                case "London":
                    reply.Attachments.Add(Card.GetLondonCard().ToAttachment());
                    break;
                case "Johannesburg":
                    reply.Attachments.Add(Card.GetJohannesburgCard().ToAttachment());
                    break;
                case "Beijing":
                    reply.Attachments.Add(Card.GetBeijingCard().ToAttachment());
                    break;
                case "Mexico City":
                    reply.Attachments.Add(Card.GetMexicoCityCard().ToAttachment());
                    break;
                default:
                    reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;
                    reply.Attachments.Add(Card.GetSeattleCard().ToAttachment());
                    reply.Attachments.Add(Card.GetTokyoCard().ToAttachment());
                    reply.Attachments.Add(Card.GetNewDelhiCard().ToAttachment());
                    reply.Attachments.Add(Card.GetManilaCard().ToAttachment());
                    reply.Attachments.Add(Card.GetNewYorkCard().ToAttachment());
                    reply.Attachments.Add(Card.GetLondonCard().ToAttachment());
                    reply.Attachments.Add(Card.GetJohannesburgCard().ToAttachment());
                    reply.Attachments.Add(Card.GetBeijingCard().ToAttachment());
                    reply.Attachments.Add(Card.GetMexicoCityCard().ToAttachment());
                    break;
            }

            await stepContext.Context.SendActivityAsync(reply, cancellationToken);

            await stepContext.Context.SendActivityAsync(MessageFactory.Text("Type anything to see another card."), cancellationToken);

            return await stepContext.EndDialogAsync();
        }

        private IList<Choice> GetChoices()
        {
            var cardOptions = new List<Choice>()
            {
                new Choice() { Value = "Seattle", Synonyms = new List<string>() { "seattle", "0" } },
                new Choice() { Value = "Tokyo", Synonyms = new List<string>() { "tokyo", "1" }},
                new Choice() { Value = "New Delhi", Synonyms = new List<string>() { "new delhi", "2" }},
                new Choice() { Value = "Manila", Synonyms = new List<string>() { "manila", "3" }},
                new Choice() { Value = "New York", Synonyms = new List<string>() { "new york", "4" }},
                new Choice() { Value = "London", Synonyms = new List<string>() { "london", "5" }},
                new Choice() { Value = "Johannesburg", Synonyms = new List<string>() { "new york", "6" }},
                new Choice() { Value = "Beijing", Synonyms = new List<string>() { "new york", "7" }},
                new Choice() { Value = "Mexico City", Synonyms = new List<string>() { "new york", "8" }},
            };

            return cardOptions;
        }
    }
}
