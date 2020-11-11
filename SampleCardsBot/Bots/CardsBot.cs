using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using Microsoft.Extensions.Logging;

using SampleCardsBot.Dialogs;

namespace SampleCardsBot
{
    public class CardsBot : BaseDialogBot<MainDialog>
    {
        public CardsBot(ConversationState convState, UserState userState, MainDialog dialog, ILogger<BaseDialogBot<MainDialog>> logger)
            : base(convState, userState, dialog, logger)
        {
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    var reply = MessageFactory.Text("Welcome to CardsBot."
                        + " This bot will show you different Cards!"
                        + " Please type anything to get started.");

                    await turnContext.SendActivityAsync(reply, cancellationToken);
                }
            }
        }
    }
}
