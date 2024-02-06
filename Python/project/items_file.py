class items:
    name=""
    price=0
    quantity=0
    
    def __init__(self,name,price):
        self.name=name
        self.price=price
        #self.quantity=quantity
    
    def getName(self):
        return self.name
    
    def getPrice(self):
        return self.price
    #def getQuantity(self):
        #return self.quantity
