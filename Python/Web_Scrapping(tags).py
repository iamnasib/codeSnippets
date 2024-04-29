import urllib.request
from bs4 import BeautifulSoup

class Scraper:
    def __init__(self,site):
        self.site=site

    def scrape(self):
        url = urllib.request.urlopen(self.site)
        html=url.read()
        parser="html.parser"
        scraped=BeautifulSoup(html,parser)
        for tag in scraped.find_all("a"):
            link = tag.get("href")
            if link is None:
                continue
            if "articles" in link:
                print("\n" + link)

news = "https://news.google.com/"
Scraper(news).scrape()