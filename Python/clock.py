import time
class practice:
    def time(self):
        hour=int(input("ENTER HOUR"))
        minute=int(input("ENTER MINUTE"))
        second=int(input("ENTER SECOND"))
        clock="yes"

        while clock=="yes":
            while hour<=12:
                while minute<60:
                    while second<60:
                        second+=1
                        time.sleep(1)
                        print(str(hour) + ":" + str(minute) + ":" + str(second))
                    second=0
                    minute+=1
                minute=0
                hour+=1
            hour=1
    def patterns(self):
        for i in range(11):
            for j in range(20):
                if i==0 or i==10 :
                    print("*",end="")
                else:
                    print(" ")
            print()
    
 
obj=practice()
obj.patterns()
