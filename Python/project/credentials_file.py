from employee_file import Employee
from dbconnection_file import DBConnection
from stock_entry_GUI_file import Design_Stock_Entry
class credential:
    def isEmpty(self,usr):
        if usr.getUsername()=="":
            return True
        else:
            return False
    def isAuthentic(self,usr):
        dbcon=DBConnection()
        user=dbcon.get_Data(usr)
        if user==True:
            return True
        else:
            return False
    def check_user(self,username,password):
        usr=Employee(username,password)
        if self.isEmpty(usr):
            print("EMPTY")
        else:
            if self.isAuthentic(usr):
                obj=Design_Stock_Entry()
                obj.enter_stock()
            else:
                print("INCORRECT USERNAME OR PASSWORD")
        
