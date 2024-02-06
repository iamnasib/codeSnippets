from items_file import items
from bill_file import bill
class shopping:
    def __init__(self,store):
        design=UI_design(store)
        
        
class UI_design:
    store=[]
    def __init__(self,store):
        self.store=store
        idz=0
        print("\t\tWELCOME TO 24 x 7")
        print("ID\t\tITEM\t\tPRICE")
        for item in self.store:
            idz+=1
            print(idz,"\t\t",item.getName(),"\t\t",item.getPrice())
        cart=[]
        con="c"
        while con=="c":
            choice=input("ENTER THE ID NO. OF ITEM ")
            if choice=="1":   
                     cart.append(self.store[0])
                     print(self.store[0].quantity-1)
                     
                  
            elif choice=="2":
                    cart.append(self.store[1])
                    
                
            elif choice=="3":
                    cart.append(self.store[2])
                
            elif choice=="4":
                
                    cart.append(self.store[3])
            elif choice=="5":
                
                    cart.append(self.store[4])
                
            else:
                print("invalid ID no.")
            
            con=input("PRESS c TO CONTINUE SHOPPING or e TO EXIT ")
            
        newbill=bill()
        newbill.generateBill(cart)
              
