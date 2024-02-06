'''class maths:
    def prime(self):
        num=int(input("ENTER THE NUMBER "))
        divisor=2
        flag=0
        while divisor<num:
            if num%divisor==0:
                flag=1
                break
            else:
                divisor=divisor+1
        if flag==0:
            print("PRIME NUMBER")
        else:
            print("NOT PRIME")


obj=maths()
obj.prime()'''


class maths:
    def prime(self):
        num=int(input("ENTER THE NUMBER "))
        divisor=2
        
        while divisor<num:
            if num%divisor==0:
                print("NOT PRIME")
                break
            else:
                divisor=divisor+1
        else:
            print("PRIME NUMBER")
        


obj=maths()
obj.prime()



        
        
