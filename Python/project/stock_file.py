from items_file import items
class stock:
    store=[]
    def __init__(self):
        
        self.store.append(items("Lays",20,10))
        self.store.append(items("biscuit",50,10))
        self.store.append(items("maggie",30,10))
        self.store.append(items("peanut",20,10))
        
    def gettStock(self):
        return self.store
    def fillStock(self):
        choice="1"
        while choice=="1":
            name=input("ENTER ITEM NAME ")
            price=int(input("ENTER ITEM PRICE "))
            quantity=int(input("ENTER ITEM QUANTITY "))
            self.store.append(items(name,price,quantity))
            choice=input("press 1 to enter more items")
            idz=0
        for item in self.store:
            idz+=1
            print(idz,item.getName(),item.getPrice())
        
        
