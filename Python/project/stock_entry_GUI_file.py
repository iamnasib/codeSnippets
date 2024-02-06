from tkinter import *
class Design_Stock_Entry:
    def enter_stock(self):
        frame=Tk()
        frame.title("Stock Enter form")
        frame.geometry("400x400")

        headerlbl=Label(frame,text="----ENTRY FORM----")
        
        Itemname_lbl=Label(frame,text="Enter Item name",fg="orange")
        self.Itemname_box=Entry(frame,fg="orange",bg="#efefef",width = 18)
        
        Itemprice_lbl=Label(frame,text="Enter Item price",fg="orange")
        self.Itemprice_box=Entry(frame,fg="orange",bg="#efefef",width = 18)
        
        enter_btn=Button(frame,text="Enter",padx="5",pady="5",bg="#333",fg="#fafafa",command=self.item_entry)

        headerlbl.grid(row="0",column="0")
        Itemname_lbl.grid(row="1",column="0")
        self.Itemname_box.grid(row="1",column="1")
        Itemprice_lbl.grid(row="2",column="0")
        self.Itemprice_box.grid(row="2",column="1")
        enter_btn.grid(row="3",column="1")
    def item_entry(self):
        itemname=self.Itemname_box.get()
        itemprice=self.Itemprice_box.get()
        self.save_data(itemname,itemprice)

    def save_data(self,itemname,itemprice):
        ptr=open("inventoryfile.txt","a")
        ptr.write(itemname)
        ptr.write(",")
        ptr.write(itemprice)
        ptr.write("\n")
        

