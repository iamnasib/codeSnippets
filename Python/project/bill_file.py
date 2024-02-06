class bill:
    def generateBill(self,cart):
        amt=0
        for item in cart:
            amt+=item.getPrice()
        print(amt)
