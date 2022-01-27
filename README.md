# bot
import telebot
import config

bot = telebot.TeleBot(config.TOCEN)

@bot.message_handler(content_types=['text'])
def lalala (message):
    bot.send_message(message.chat.id, message.text)

#Run
bot.polling(none_stop=True)
