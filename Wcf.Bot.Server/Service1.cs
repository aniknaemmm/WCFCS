namespace WcfBot
{
    public class Service1 : IService1
    {
        public void GetUpdate(Update update)
        {
            var Bot = new Telegram.Bot.Api("<token>");
            if (update.message.text == "Привет")
            {
                Bot.SendTextMessage(update.message.chat.id, "Привет," + update.message.from.first_name);
            }
        }
    }
}