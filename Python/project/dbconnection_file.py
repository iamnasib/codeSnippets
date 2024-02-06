import mysql.connector 
class DBConnection:
    def __init__(self):
        self.db=mysql.connector.connect(host="localhost",username="root",password="",database="camp1")
        self.permission=self.db.cursor()
        print("successfully")
    def create_Database(self):
        self.permission.execute("create database camp1")
        print("database created successfully")
    def show_Databases(self):
        self.permission.execute("show databases")
        for db in self.permission:
            print(db)
    def create_Table(self):
        self.permission.execute("create table login(username varchar(40),password varchar(50))")
        print("table created successfully")
    def get_Data(self,usr):
        #psw=('niit',)
        #qry="select * from login where password=%s"
        self.permission.execute("select * from login where username ='"+usr.getUsername()+"'")
        #mytable=self.permission.fetchall()
        mytable=self.permission.fetchone()
        if mytable!= None:
            return True
        else:
            return False
        #print(mytable)
        #for row in mytable:
            #print(row)
    def insert_Data(self):
        self.permission.execute("insert into login values('"+nasib+"','1234')")
        self.db.commit()
        print("data added successfully")
    def delete_Data(self):
        self.permission.execute("delete from login where username='nasib'")
        print("data deleted successfully")
#ob=DBConnection()
