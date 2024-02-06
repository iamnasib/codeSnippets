from tkinter import *
from employee_file import Employee
from credentials_file import credential
from stock_file import stock
class Design_LoginForm:
    def getLogin(self):
        frame=Tk()
        frame.title("Login form")
        frame.geometry("400x400")

        headerlbl=Label(frame,text="----LOGIN FORM----")
        
        username_lbl=Label(frame,text="Enter username",fg="orange")
        self.username_box=Entry(frame,fg="orange",bg="#efefef",width = 18)
        
        password_lbl=Label(frame,text="Enter password",fg="orange")
        self.password_box=Entry(frame,fg="orange",bg="#efefef",width = 18)
        
        login_btn=Button(frame,text="Login",padx="5",pady="5",bg="#333",fg="#fafafa",command=self.getData)
        headerlbl.grid(row="0",column="0")
        username_lbl.grid(row="1",column="0")
        self.username_box.grid(row="1",column="1")
        password_lbl.grid(row="2",column="0")
        self.password_box.grid(row="2",column="1")
        login_btn.grid(row="3",column="1")
    def getData(self):
        username=self.username_box.get()
        password=self.password_box.get()
        cred=credential()
        user=cred.check_user(username,password)
        if user == True:
            stk.fillStock()
            
        
