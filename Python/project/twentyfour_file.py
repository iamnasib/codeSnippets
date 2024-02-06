from customer_file import customer
from shopping_file import shopping
from user_file import user
from credentials_file import credential
from stock_file import stock
from GUI_twenty_file import Design_LoginForm

class twentyfour:
    def __init__(self):
        
        m1=manager()
        
class manager:
    def __init__(self):
        stk=stock()
        choice=input("Press \n 1 for customer \n 2 for employee \n")
        if choice=="1":
            name=input("ENTER YOUR  NAME ")
            idd=1
            cust=customer(name,idd)
            store=stk.gettStock()
            shp=shopping(store)
        else:
            login=Design_LoginForm()
            login.getLogin()

obj=twentyfour()

