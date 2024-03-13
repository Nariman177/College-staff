import requests
from bs4 import BeautifulSoup as BS

r = requests.get("https://ticketon.kz/international_events")
html = BS(r.content, 'html.parser')
for el in html.select(".container > .ContentHeader_title__np_iQ"):
    title = el.select(".ContentHeader_title__np_iQ > h1")
    print("концерт: ", title[0].text)
