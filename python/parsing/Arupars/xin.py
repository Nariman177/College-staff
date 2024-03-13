from flask import Flask, render_template
import requests
from bs4 import BeautifulSoup as BS

app = Flask(__name__)

@app.route('/')
def index():
    url = "https://ticketon.kz/"
    r = requests.get(url)
    html = BS(r.content, 'html.parser')

    event_info_list = []

    titles = html.select(".listPopular")
    locations = html.select(".list-item__place")
    dates = html.select("time")

    for title, location, date in zip(titles, locations, dates):
        event_info = {
            "Название": title.text.strip() if title else "",
            "Местоположение": location.text.strip() if location else "",
            "Дата": date.text.strip() if date else ""
        }
        event_info_list.append(event_info)
    return render_template('index.html', event_info=event_info)

if __name__ == '__main__':
    app.run(debug=True)
