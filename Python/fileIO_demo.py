class file_demoz: 
    def writing_data_onfile (self):
        #ptr=open ("d: \\projects\\myfile.txt",encoding="utf-8)"
        with open("D:\\Projects\\python\\myfile.txt","w")as ptr: 
            ptr.write("welcome to python DE") 
            print("Data saved to the file") 
    def reading_data_fromfile(self):
        #ptr=open ("d:\\projects\\myfile.txt","r")
        with open ("D:\\Projects\\python\\myfile.txt","r")as ptr: 
            print(ptr.tell()) 
            print(ptr.read(4)) 
            print(ptr.tell()) 
            print(ptr.read(4))
            ptr.seek(0) 
            print(ptr.tell()) 
            print(ptr.read(4)) 
            for data in ptr: 
                print(data) 
     
obj=file_demoz() 
obj.reading_data_fromfile()
