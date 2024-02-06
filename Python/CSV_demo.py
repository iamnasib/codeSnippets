ptr=open("D:/Projects/python/CSVFILES/Book1.csv","r")
records=ptr.readlines()

mydata={}
for record in records:
    group=record.split(",")
    reg=group[0]
    name=group[1]
    address=group[2]
    age=group[3]

    mydata[reg]={"Name":name, "address":address,"age":age}

R=input("enter registration no.")

if R in mydata:
    print(R,"\n",mydata[R]["Name"],"\n",mydata[R]["address"],"\n",mydata[R]["age"])
else:
    print("No record found")
