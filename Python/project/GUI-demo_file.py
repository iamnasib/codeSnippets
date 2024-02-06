from tkinter import *
frame=Tk()
frame.title("Login form")
frame.geometry("400x400")

username_lbl=Label(frame,text="Enter username",fg="orange")
username_lbl.pack()
username_box=Entry(frame,fg="orange",bg="#efefef",width = 18)
username_box.pack()

password_lbl=Label(frame,text="Enter password",fg="orange")
password_lbl.pack()
password_box=Entry(frame,fg="orange",bg="#efefef",width = 18)
password_box.pack()

login_btn=Button(frame,text="Login",bg="#333",fg="#fafafa",width = 15)
login_btn.pack()
