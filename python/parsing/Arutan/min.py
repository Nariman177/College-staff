from flask import Flask, render_template
import requests
from bs4 import BeautifulSoup as BS

app = Flask(__name__)

@app.route('/')
def index():
    url = "https://ticketon.kz/event/toreali-toreali-atyrau-kalasynda?advbanner=list_popular&advname=event_toreali-toreali-atyrau-kalasynda&advpos=2"
    r = requests.get(url)
    html = BS(r.content, 'html.parser')

    event_info = {
        "Название": "",
        "Местоположение": "",
        "Цена": "",
        "Время": "",
        "Дата": ""
    }

    # Извлечение информации из элементов страницы
    title_element = html.select_one("h1")
    location_element = html.select_one(".AboutListItem_text__2aqVr")
    price_element = html.select_one(".TicketsList_minPrice__8kswx")
    time_element = html.select_one(".TicketButton_text__7g4pC")
    date_element = html.select_one(".MobileDate_dateWrapper__2mGQi")

    # Заполнение словаря данными
    event_info["Название"] = title_element.text.strip() if title_element else ""
    event_info["Местоположение"] = location_element.text.strip() if location_element else ""
    event_info["Цена"] = price_element.text.strip() if price_element else ""
    event_info["Время"] = time_element.text.strip() if time_element else ""
    event_info["Дата"] = date_element.text.strip() if date_element else ""

    return render_template('index.html', event_info=event_info)

if __name__ == '__main__':
    app.run(debug=True)

