from urllib.request import urlopen
import urllib.request
from bs4 import BeautifulSoup
url="http://iamnasib.github.io"
#ptr=urlopen(url)
#print(ptr.read())

req_obj=urllib.request.Request(url,data=None,headers={'User-Agent':'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.110 Safari/537.36'})
ptr=urllib.request.urlopen(req_obj)
data=BeautifulSoup(ptr,features="html.parser")
for sc in data(["script,style"]):
    sc.extract()
    
filtered_data=data.get_text()
print(filtered_data)
