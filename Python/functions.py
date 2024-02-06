'''def add(a,b):
    res=a+b
    print("_______________ADDITION_______________")
    print(res)
def sub(a,b):
    res=a-b
    print("_______________SUBTRACTION_______________")
    print(res)
def div():
    res=a//b
    print("_______________DIVISION_______________")
    print(res)
def mul():
    res=a*b
    print("_______________MULTIPLICATION_______________")
    print(res)
n1=int(input("enter frst nmbr"))
n2=int(input("enter scnd nmbr"))
add(n1,n2)
sub(n1,n2)'''

'''class abc:
    v=10
    def swap(self,a,b):
        temp=a
        a=b
        b=temp
        print("ist =",a,"2nd =", b)
        print(self.v)
        self.r=v



n1=int(input("1st nmbr "))
n2=int(input("2nd nmbr "))
obj=abc()

abc.swap(n1,n2)'''

class maths:
    def getValues(self):
        self.num1=int(input("ENTER FIRST NUMBER "))
        self.num2=int(input("ENTER SECOND NUMBER "))
    def add(self):
        self.addd=self.num1+self.num2
    def sub(self):
        self.subb=self.num1-self.num2
    def div(self):
        self.divv=self.num1/self.num2
    def display(self):
        print(self.num1," + ",self.num2," = ", self.addd)
        print(self.num1," - ",self.num2," = ", self.subb)
        print(self.num1," / ",self.num2," = ", self.divv)
obj=maths()
obj.getValues()
obj.add()
obj.sub()
obj.div()
obj.display()









        
