using Microsoft.Toolkit.Uwp.Notifications;

namespace ezSharp
{
    internal class toastWindow
    {
        public static void Create(string topMessage, string bottomMessage)
        {
            new ToastContentBuilder()
            .AddArgument("action", "viewConversation")
            .AddArgument("conversationId", 9813)
            .AddText(topMessage)
            .AddText(bottomMessage)
            .Show();
        }
    }
}
