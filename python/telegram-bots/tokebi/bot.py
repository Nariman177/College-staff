import telebot
from telebot import types     
TOKEN='5731122093:AAGY5OEvMUujoW8cB-hC5JqYIfRFRs7wmck'
bot = telebot.TeleBot(TOKEN)


@bot.message_handler(commands=['start'])
def welcome(message):
    # keyboard
    markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
    item1 = types.KeyboardButton("Магазин электротехники")
    item2 = types.KeyboardButton("Игры")
    item3=types.KeyboardButton('Информацияℹ')
    item4=types.KeyboardButton('Новости')
    
 
    markup.add(item1, item2,item3,item4)
 
    bot.send_message(message.chat.id, "Добро пожаловать, {0.first_name}!\nЯ - <b>{1.first_name}</b>, бот созданный чтобы вам помочь выбрать технику.\nЕсли нашли баги,Ошибки либо хотели что-то добавить пишите мне в \n<b>👉Вк:</b>https://vk.com/botbrat7 \n 👉<b>Instagram:</b>https://www.instagram.com/chetky_patcan/".format(message.from_user, bot.get_me()),
        parse_mode='html', reply_markup=markup)

@bot.message_handler(content_types=['text'])
def lalala(message):        
        if message.text == 'Магазин электротехники':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            item1=types.KeyboardButton('Смартфоны📱')
            item2=types.KeyboardButton('Ноутбуки💻')
            item3=types.KeyboardButton('Смарт-часы⌚')
            back=types.KeyboardButton('Главная меню')

            markup.add(item1, item2, item3,back)

            bot.send_message(message.chat.id,'Выберите тип:',reply_markup=markup) 

        elif message.text == 'Игры':

            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            item1=types.KeyboardButton('Хитрые загадки на логику')
            back=types.KeyboardButton('Главная меню')

            markup.add(item1,back)

            bot.send_message(message.chat.id,'Выберите:',reply_markup=markup)


        elif message.text=='Новости':######################################################3
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            item1=types.KeyboardButton('Toп 1 2021 Мобильные игра')
            item2=types.KeyboardButton('Toп 1 2021 Компьютерная игра')
            back=types.KeyboardButton('Главная меню')

            markup.add(item1,item2,           back)

            bot.send_message(message.chat.id,'Выберите тип:',reply_markup=markup)

        elif message.text=='Toп 1 2021 Компьютерная игра':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            back=types.KeyboardButton('Главная меню')

            markup.add(back)

            PH = open('PH/forza4.png', 'rb')
            bot.send_photo(message.chat.id,PH)

            bot.send_message(message.chat.id,'Четвертая часть популярной серии аркадных гонок, где игру предоставляется возможность взять под свое управление самые мощные и современные спорткары, чтобы победить на них в непростых битвах на автотрассах.',reply_markup=markup)

            bot.send_message(message.chat.id,'<b>Жанр:</b>  arcade, simulator\n<b>Платформы:</b>PC, Xbox One\n<b>Год выпуска:</b>2018\n<b>Разработчик:</b>Playground Games\n<b>Издатель:</b>Microsoft Studios\n<b>Страна:</b> Великобритания\n',parse_mode='html',reply_markup=markup)

        elif message.text == 'Toп 1 2021 Мобильные игра':

            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)                                     
            back=types.KeyboardButton('Главная меню')

            markup.add(back)
            
            PH = open('PH/GEN.png', 'rb')
            bot.send_photo(message.chat.id,PH)

            bot.send_message(message.chat.id,'<b>Игра года </b>Мобильная игра Genshin Impact единогласно названа “Игрой года”, согласно AppStore и Google Play. События Genshin Impact происходят в открытом мире Тейват, где сочетаются аниме, магия, фэнтези и другие культуры.\n\n<b>Сказочный мир Тейват</b> – мир, в котором возможно все. Хотите, сражайтесь с врагами, разгадывайте головоломки, ищите секреты в подземельях и готовьте еду, а хотите просто исследуйте мир Тейват. Захотели забраться вон на ту гору? Вперед! Захотели спуститься вниз по воздуху? Да легко! Только расправьте крылья! Многим такие возможности напомнили японскую игру The Legend of Zelda: Breath of the Wild. Но разработчики даже не отрицают влияния японских коллег, и это никак не делает китайскую игру хуже.',parse_mode='html',reply_markup=markup)      
            bot.send_message(message.chat.id,'IOS:https://apps.apple.com/kz/app/genshin-impact/id1517783697',reply_markup=markup)
            bot.send_message(message.chat.id,'Android:https://play.google.com/store/apps/details?id=com.miHoYo.GenshinImpact',reply_markup=markup)

        elif message.text=='Главная меню':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            item1 = types.KeyboardButton("Магазин электротехники")
            item2 = types.KeyboardButton("Игры")
            item3=types.KeyboardButton('Информацияℹ')
            item4=types.KeyboardButton('Новости')

            markup.add(item1, item2,item3,item4)
            bot.send_message(message.chat.id,'Выберите:',reply_markup=markup)

        elif message.text=='Смарт-часы⌚':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            item1=types.KeyboardButton('XIAOMI⌚')
            item2=types.KeyboardButton('HUAWEI WATCH⌚')
            item3=types.KeyboardButton('SAMSUNG⌚') 
            back=types.KeyboardButton('Mеню')

            markup.add(item1, item2, item3,back)

            bot.send_message(message.chat.id,'Выберите:',reply_markup=markup)  

        elif message.text=='XIAOMI⌚':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/XIAOMI.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'XIAOMI⌚-и другие товары :https://goo.su/teI',reply_markup=markup)
            bot.send_message(message.chat.id,'Смарт часы XIAOMI Amazfit Bip U Pink🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://goo.su/9WUC',reply_markup=markup)

        elif message.text=='HUAWEI WATCH⌚':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/HUAWEI WATCH.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'HUAWEI WATCH⌚-и другие товары :https://goo.su/teI',reply_markup=markup)
            bot.send_message(message.chat.id,'Смарт часы HUAWEI WATCH Fit синий (TIA-B09)🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://goo.su/9vek',reply_markup=markup)

        elif message.text=='SAMSUNG⌚':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/SAMSUNG.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'SAMSUNG⌚-и другие товары :https://goo.su/teI',reply_markup=markup)
            bot.send_message(message.chat.id,'Смарт часы SAMSUNG Galaxy Watch4 40mm Rose Gold (SM-R860NZDACIS)🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://goo.su/9O5C',reply_markup=markup)          
          

        elif message.text=='Ноутбуки💻':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            item1=types.KeyboardButton('Asus💻')
            item2=types.KeyboardButton('Lenovo💻')
            item3=types.KeyboardButton('HP💻') 
            back=types.KeyboardButton('Mеню')

            markup.add(item1, item2, item3,back)

            bot.send_message(message.chat.id,'Выберите:',reply_markup=markup)

        elif message.text=='HP💻':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            item1=types.KeyboardButton('HP Pavilion 15💻')
            item2=types.KeyboardButton('HP Pavilion 14💻')
            item3=types.KeyboardButton('HP ENVY 13💻') 
            back=types.KeyboardButton('Mеню')

            markup.add(item1, item2, item3,back)

            bot.send_message(message.chat.id,'Выберите:',reply_markup=markup)

        elif message.text=='HP Pavilion 15💻':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/15.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'HP Pavilion 15💻-и другие товары HP💻:https://goo.su/Nd1',reply_markup=markup)
            bot.send_message(message.chat.id,'Ноутбук HP Pavilion 15-eh1014ur/15.6 FHD/AMD Ryzen 5 5500U 2.1 Ghz/8/SSD512/Win10🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://goo.su/9y4d',reply_markup=markup)

        elif message.text=='HP Pavilion 14💻':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/14.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'HP Pavilion 14💻-и другие товары HP💻:https://goo.su/Nd1',reply_markup=markup)
            bot.send_message(message.chat.id,'Ноутбук HP Pavilion 14-ec0000ur/14 FHD/AMD Ryzen 5 5500U 2.1 Ghz/8/SSD512/Win10🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить:https://goo.su/9N3b',reply_markup=markup)

        elif message.text=='HP ENVY 13💻':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/13.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'HP ENVY 13💻-и другие товары HP💻:https://goo.su/Nd1',reply_markup=markup)
            bot.send_message(message.chat.id,'Ноутбук HP ENVY 13-ba1038ur/13.3 FHD/Core i5 1135G7 2.4 Ghz/16/SSD512/Win10🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить:https://goo.su/fHx',reply_markup=markup)                

        elif message.text=='Lenovo💻':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            item1=types.KeyboardButton('Legion 5💻')
            item2=types.KeyboardButton('LENOVO V15💻')
            item3=types.KeyboardButton('IdeaPad 3💻') 
            back=types.KeyboardButton('Mеню')

            markup.add(item1, item2, item3,back)

            bot.send_message(message.chat.id,'Выберите:',reply_markup=markup) 

        elif message.text=='Legion 5💻':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/L5.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'Legion 5💻-и другие товары Lenovo💻: https://goo.su/aJWT',reply_markup=markup)
            bot.send_message(message.chat.id,'Ноутбук LENOVO Legion 5 15IMH05 (82AU00C2RK) 15.6 FHD/Core i5 10300H 2.5 Ghz/8/SSD512/GTX1650Ti/4/Dos🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://goo.su/uGz',reply_markup=markup) 

        elif message.text=='LENOVO V15💻':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/V15.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'LENOVO V15💻-и другие товары Lenovo💻: https://goo.su/aJWT',reply_markup=markup)
            bot.send_message(message.chat.id,'Ноутбук LENOVO V15 (82C7007VRU) 15.6 HD/AMD Ryzen 3 3250U 2.6 Ghz/4/1TB/Do🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://goo.su/9LY5',reply_markup=markup)    

        elif message.text=='IdeaPad 3💻':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/I3.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'IdeaPad 3💻-и другие товары Lenovo💻: https://goo.su/aJWT',reply_markup=markup)
            bot.send_message(message.chat.id,'Ноутбук LENOVO IdeaPad 3 15ADA05 (81W100RARK) 15.6 HD/AMD Athlon 3050U 2.3 Ghz/4/1TB/Dos🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://goo.su/9gem',reply_markup=markup)          
          

        elif message.text=='Asus💻':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            item1=types.KeyboardButton('ROG Strix G15💻')
            item2=types.KeyboardButton('ROG Strix G17💻')
            item3=types.KeyboardButton('ROG Strix F15💻') 
            back=types.KeyboardButton('Mеню')

            markup.add(item1, item2, item3,back)

            bot.send_message(message.chat.id,'Выберите:',reply_markup=markup) 



        elif message.text=='ROG Strix G15💻':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/G15.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'ROG Strix G15💻-и другие товары Asus: https://goo.su/aJWT',reply_markup=markup)
            bot.send_message(message.chat.id,'Игровой ноутбук Asus ROG Strix G15 Ryzen 7 4800H / 8ГБ / 512SSD / GTX1650 4ГБ / 15.6 / DOS / (G513IH-HN004)🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://goo.su/NXa',reply_markup=markup)  

        elif message.text=='ROG Strix G17💻':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/G17.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'ROG Strix G17💻-и другие товары Asus: https://goo.su/aJWT',reply_markup=markup)
            bot.send_message(message.chat.id,'Игровой ноутбук Asus ROG Strix G17 Ryzen 7 4800H / 16ГБ / 512SSD / RTX3050 4ГБ / 17.3 / DOS / (G713IC-HX010)🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://goo.su/a4Zi',reply_markup=markup)

        elif message.text=='ROG Strix F15💻':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/F15.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'ROG Strix F15💻-и другие товары Asus: https://goo.su/aJWT',reply_markup=markup)
            bot.send_message(message.chat.id,'Игровой ноутбук Asus ROG Strix F15 i5 11400H / 16ГБ / 512SSD / RTX3050 Ti 4ГБ / 15.6 / DOS / (FX506HEB-HN187)🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://goo.su/afJ0',reply_markup=markup)       
     

        elif message.text=='Смартфоны📱':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            item1=types.KeyboardButton('Apple🍏')
            item2=types.KeyboardButton('Samsung📱')
            item3=types.KeyboardButton('Xiaomi📱') 
            back=types.KeyboardButton('Mеню')

            markup.add(item1, item2, item3,back)

            bot.send_message(message.chat.id,'Выберите:',reply_markup=markup)

        elif message.text=='Xiaomi📱':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            item1=types.KeyboardButton('Mi 11 Lite 📱')
            item2=types.KeyboardButton('Redmi 10📱')
            item3=types.KeyboardButton('Poco X3 Pro📱')
            back=types.KeyboardButton('Mеню')

            markup.add(item1, item2, item3,back)

            bot.send_message(message.chat.id,'Выберите:',reply_markup=markup) 

        elif message.text=='Mi 11 Lite 📱':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/mi11.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'Mi 11 Lite 📱-и другие товары Xiaomi: https://goo.su/Ows',reply_markup=markup)
            bot.send_message(message.chat.id,'Antutu из Xiaomi Mi 11 Lite 5G Global · 6GB · 128GB является-567.671🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://goo.su/Xno',reply_markup=markup)

        elif message.text=='Redmi 10📱':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/redmi10.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'Redmi 10📱-и другие товары Xiaomi: https://goo.su/Ows',reply_markup=markup)
            bot.send_message(message.chat.id,'Antutu из Xiaomi Mi 11 Lite 5G Global · 6GB · 128GB является-567.671🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://goo.su/S85',reply_markup=markup) 

        elif message.text=='Poco X3 Pro📱':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/pocox3.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'Poco X3 Pro📱-и другие товары Xiaomi: https://goo.su/Ows',reply_markup=markup)
            bot.send_message(message.chat.id,'Antutu из Poco X3 Pro Global · 6GB · 128GB является-561.303🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://goo.su/9iix',reply_markup=markup)               

        elif message.text=='Samsung📱':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            item1=types.KeyboardButton('Galaxy S21📱')
            item2=types.KeyboardButton('Galaxy S20 FE📱')
            item3=types.KeyboardButton('Galaxy Z Fold📱')
            back=types.KeyboardButton('Mеню')

            markup.add(item1, item2, item3,back)

            bot.send_message(message.chat.id,'Выберите:',reply_markup=markup)

        elif message.text=='Galaxy S21📱':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/s21.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'Galaxy S21📱-и другие товары Samsung: https://goo.su/9YCK',reply_markup=markup)
            bot.send_message(message.chat.id,'Antutu из Samsung Galaxy S21 5G Global · 8GB · 128GB · SM-G991B является-755.000 🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://goo.su/9lDN',reply_markup=markup)

        elif message.text=='Galaxy S20 FE📱':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/s20.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'Galaxy S20 FE📱 -и другие товары Samsung: https://goo.su/9YCK',reply_markup=markup)
            bot.send_message(message.chat.id,'Antutu из Samsung Galaxy S20 Fan Edition Global · 6GB · 128GB · 4G является-623.000 🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://goo.su/o0g',reply_markup=markup)

        elif message.text=='Galaxy Z Fold📱':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/z.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'Galaxy Z Fold📱-и другие товары Samsung: https://goo.su/9YCK',reply_markup=markup)
            bot.send_message(message.chat.id,'Antutu из Samsung Galaxy Z Fold Global · 12GB · 256GB является-705.000 🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://goo.su/t0z',reply_markup=markup)          

        elif message.text=='Apple🍏':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            item1=types.KeyboardButton('iPhone11🍏')
            item2=types.KeyboardButton('iPhone12🍏')
            item3=types.KeyboardButton('iPhone13🍏')
            item4=types.KeyboardButton('iPhone12 pro🍏')
            item5=types.KeyboardButton('iPhone12 pro MAX🍏')
            item6=types.KeyboardButton('iPhone13 pro🍏')
            item7=types.KeyboardButton('iPhone13 pro MAX🍏')

            back=types.KeyboardButton('Mеню')

            markup.add(item1, item2, item3,item4,item5,item6,item7,back)

            bot.send_message(message.chat.id,'Выберите:',reply_markup=markup)


        elif message.text=='iPhone11🍏':##############################################################################3
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/iphoneX.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'iPhone11-и другие товары Aplle: https://goo.su/9g3S',reply_markup=markup)
            bot.send_message(message.chat.id,'Antutu из Apple iPhone 11 Global · 4GB · 64GB является - 521.227 🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://goo.su/9M1Q',reply_markup=markup)
        elif message.text=='iPhone12 pro🍏':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/iphone12pro.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'iPhone12 pro-и другие товары Aplle: https://goo.su/9g3S',reply_markup=markup)
            bot.send_message(message.chat.id,'Antutu из Apple iPhone 12 pro Global  256 GB является - 574.155🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://clck.ru/ZV8gQ',reply_markup=markup)

        elif message.text=='iPhone12 pro MAX🍏':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/promax.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'iPhone12 pro MAX-и другие товары Aplle: https://goo.su/9g3S',reply_markup=markup)
            bot.send_message(message.chat.id,'Antutu из Apple iPhone 12 Pro Max Global · 6GB · 128GB -577.532 • Antutu v8🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://clck.ru/ZV9xf',reply_markup=markup)        

        elif message.text=='iPhone12🍏':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/iphone12.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'iPhone12-и другие товары Aplle: https://goo.su/9g3S',reply_markup=markup)
            bot.send_message(message.chat.id,'Antutu из Apple iPhone 12 Global · 4GB · 64GB является-573.719🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://goo.su/9mRK',reply_markup=markup)

        elif message.text=='iPhone13🍏':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/iphone13.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'iPhone13-и другие товары Aplle: https://goo.su/9g3S',reply_markup=markup)
            bot.send_message(message.chat.id,'Antutu из Apple iPhone 13 Global · 4GB · 128GB является-818.321🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://goo.su/9gns',reply_markup=markup)
           
        elif message.text=='iPhone13 pro🍏':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/iphone13pro.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'iPhone13 pro-и другие товары Aplle: https://goo.su/9g3S',reply_markup=markup)
            bot.send_message(message.chat.id,'Antutu из Apple iPhone 13 pro Global · 4GB · 128GB является-839.321🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://clck.ru/ZVCGe',reply_markup=markup)
        elif message.text=='iPhone13 pro MAX🍏':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/13зкщьфч.png', 'rb')
            bot.send_photo(message.chat.id,PH)
            bot.send_message(message.chat.id,'iPhone13 pro MAX-и другие товары Aplle: https://goo.su/9g3S',reply_markup=markup)
            bot.send_message(message.chat.id,'Antutu из Apple iPhone 13 Pro Max Global · 6GB · 128GB -854.218 🔥 ',reply_markup=markup)
           
            bot.send_message(message.chat.id,'Купить: https://clck.ru/ZVE55',reply_markup=markup)


        elif message.text=='Mеню':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            item1=types.KeyboardButton('Смартфоны📱')
            item2=types.KeyboardButton('Ноутбуки💻')
            item3=types.KeyboardButton('Смарт-часы⌚')
            back=types.KeyboardButton('Главная меню')

            markup.add(item1, item2, item3,back)

            bot.send_message(message.chat.id,'Выберите тип:',reply_markup=markup)

        
        elif message.text == 'Хитрые загадки на логику':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            item1=types.KeyboardButton('ЗАГАДКA #1')
            item2=types.KeyboardButton('ЗАГАДКA #2')
            item3=types.KeyboardButton('ЗАГАДКA #3')
            item4=types.KeyboardButton('ЗАГАДКA #4')
            item5=types.KeyboardButton('ЗАГАДКA #5')
            item6=types.KeyboardButton('ЗАГАДКA #6')
            item7=types.KeyboardButton('ЗАГАДКA #7')
            item8=types.KeyboardButton('ЗАГАДКA #8')
            item9=types.KeyboardButton('ЗАГАДКA #9')
            item10=types.KeyboardButton('ЗАГАДКA #10')
            back=types.KeyboardButton('Главная меню')
            markup.add(item1,item2,item3,item4,item5,item6,item7,item8,item9,item10,back)

            bot.send_message(message.chat.id,'Выберите:',reply_markup=markup)    

        
        elif message.text == 'ЗАГАДКA #1':    
            markup = types.InlineKeyboardMarkup(row_width=1)
            item1 = types.InlineKeyboardButton("Показать ответ", callback_data='1')
            markup.add(item1)

            bot.send_message(message.chat.id,'Как человеку не спать 8 дней?',reply_markup=markup)
        elif message.text == 'ЗАГАДКA #2':    
            markup = types.InlineKeyboardMarkup(row_width=1)
            item1 = types.InlineKeyboardButton("Показать ответ", callback_data='2')
            markup.add(item1)

            bot.send_message(message.chat.id,'Вы заходите в тёмную кухню. В ней есть свеча, керосиновая лампа и газовая плита. Что вы зажжёте в первую очередь?',reply_markup=markup)
        elif message.text == 'ЗАГАДКA #3':    
            markup = types.InlineKeyboardMarkup(row_width=1)
            item1 = types.InlineKeyboardButton("Показать ответ", callback_data='3')
            markup.add(item1)

            bot.send_message(message.chat.id,'К реке подходят два человека. У берега лодка, которая может выдержать только одного. Оба человека переправились на противоположный берег. Как?',reply_markup=markup)
        elif message.text == 'ЗАГАДКA #4':    
            markup = types.InlineKeyboardMarkup(row_width=1)
            item1 = types.InlineKeyboardButton("Показать ответ", callback_data='4')
            markup.add(item1)

            bot.send_message(message.chat.id,'Два отца, два сына нашли три апельсина и разделили их. Каждому досталось по целому апельсину. Как такое может быть?',reply_markup=markup)
        elif message.text == 'ЗАГАДКA #5':    
            markup = types.InlineKeyboardMarkup(row_width=1)
            item1 = types.InlineKeyboardButton("Показать ответ", callback_data='5')
            markup.add(item1)

            bot.send_message(message.chat.id,'Если в 12 часов ночи идёт дождь, то можно ли ожидать, что через 72 часа будет солнечная погода?',reply_markup=markup)
        elif message.text == 'ЗАГАДКA #6':    
            markup = types.InlineKeyboardMarkup(row_width=1)
            item1 = types.InlineKeyboardButton("Показать ответ", callback_data='6')
            markup.add(item1)

            bot.send_message(message.chat.id,'На дереве сидело 10 птиц. Пришел охотник и подстрелил одну птицу. Сколько птиц осталось на дереве?',reply_markup=markup)
        elif message.text == 'ЗАГАДКA #7':    
            markup = types.InlineKeyboardMarkup(row_width=1)
            item1 = types.InlineKeyboardButton("Показать ответ", callback_data='7')
            markup.add(item1)

            bot.send_message(message.chat.id,'У отца Мэри 5 дочерей: Чача, Чече, Чичи, Чочо. Как зовут пятую дочь?',reply_markup=markup)
        elif message.text == 'ЗАГАДКA #8':    
            markup = types.InlineKeyboardMarkup(row_width=1)
            item1 = types.InlineKeyboardButton("Показать ответ", callback_data='8')
            markup.add(item1)

            bot.send_message(message.chat.id,'Мужчина заходит в магазин, покупает колбасу и просит её нарезать, но не поперек, а вдоль. Продавщица спрашивает: «Вы пожарник?» — «Да». Как она догадалась?',reply_markup=markup)
        elif message.text == 'ЗАГАДКA #9':    
            markup = types.InlineKeyboardMarkup(row_width=1)
            item1 = types.InlineKeyboardButton("Показать ответ", callback_data='9')
            markup.add(item1)

            bot.send_message(message.chat.id,'Как спрыгнуть с десятиметровой лестницы и не ушибиться?',reply_markup=markup)
        elif message.text == 'ЗАГАДКA #10':    
            markup = types.InlineKeyboardMarkup(row_width=1)
            item1 = types.InlineKeyboardButton("Показать ответ", callback_data='10')
            markup.add(item1)

            bot.send_message(message.chat.id,'Что можно видеть с закрытыми глазами?',reply_markup=markup)                                        
    
        elif message.text=='GIF бота':
            logo = open('PH/logo1.gif', 'rb')
            bot.send_video(message.chat.id,logo) 

        elif message.text == 'Информацияℹ':
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            item1=types.KeyboardButton('GIF бота')
            back=types.KeyboardButton('Главная меню')
            markup.add(item1,back)  

            bot.send_message(message.chat.id,'<b>👉Это курсавая работа на языке Python.\n👉Полтехнического колледжа П-19-46гб студент 3-курса  Бақытбек Самғар.\n👉Если нашли баги,Ошибки либо хотели что-то добавить пишите мне в:</b> ',parse_mode='html',reply_markup=markup)
            bot.send_message(message.chat.id,'<b>👉Instagram:</b>https://www.instagram.com/chetky_patcan/',parse_mode='html',reply_markup=markup)
            bot.send_message(message.chat.id,'<b>👉Vk:</b>https://vk.com/botbrat7',parse_mode='html',reply_markup=markup)
        else:
            markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
            PH = open('PH/WT.tgs', 'rb')
            bot.send_sticker(message.chat.id,PH)
            bot.send_message(message.chat.id,'Я вас не понял, используйте только кнопки ',reply_markup=markup)
@bot.callback_query_handler(func=lambda call: True)
def callback_inline(call):
    try:
        if call.message:
            if call.data == '1':
                bot.send_message(call.message.chat.id, 'Спать по ночам🤣')
            elif call.data == '2':
                bot.send_message(call.message.chat.id, 'Спичку🤣')
            elif call.data == '3':
                bot.send_message(call.message.chat.id, 'Они были на разных берегах🤣')
            elif call.data == '4':
                bot.send_message(call.message.chat.id, 'Это были дед, отец и сын🤣')
            elif call.data == '5':
                bot.send_message(call.message.chat.id, 'Нет, так как через 72 часа будет ночь🤣')
            elif call.data == '6':
                bot.send_message(call.message.chat.id, 'Ни одной – остальные птицы улетели🤣')
            elif call.data == '7':
                bot.send_message(call.message.chat.id, 'Мэри🤣')
            elif call.data == '8':
                bot.send_message(call.message.chat.id, 'Мужчина был в форме🤣')
            elif call.data == '9':
                bot.send_message(call.message.chat.id, 'Нужно прыгать с нижней ступени🤣')
            elif call.data == '10':
                bot.send_message(call.message.chat.id, 'Сны🤣')                                
 
            # remove inline buttons
            bot.edit_message_text(chat_id=call.message.chat.id,text="😊 Как дела?",reply_markup=None)
 
    except Exception as e:
        print(repr(e))

bot.polling(none_stop=True,interval=0)