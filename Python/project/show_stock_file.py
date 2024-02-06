class stock:
    def showstock(self):
        store={}
        with open ("inventoryfile.txt","r")as ptr:
            stock=ptr.readlines()
            print(type(stock))
            print(stock)
            for items in stock:
                item=items.split(",")
                itemName=item[0]
                itemPrice=item[1]
                store[itemName]={"ItemName":itemName, "itemPrice":itemPrice}
            print(store)
            
            

obj=stock()
obj.showstock()
