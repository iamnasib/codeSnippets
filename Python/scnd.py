old=0
new=1
latest=0
while latest<=500:
    latest=old+new
    if latest<=500:
        print(latest)
        old=new
        new=latest
        
    else:
        break
