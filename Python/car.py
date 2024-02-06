class car:
    def carcommand(self):
        command=0
        enter=input("Do you want to enter in the car ")
        while enter=="yes":
            com=input(" ENTER: START/STOP ")
            if com=="start":
                 if command==1:
                     print("Car already Started")
                 else:
                     print("Car  Started")
                     command=1
            elif com=="stop":
                    if command==0:
                        print("Car already stopped")
                    else:
                        command=0
                        print("car stopped")
            elif com=="exit":
                break
        
            else:
                 print("Invalid command")
        else:
             print("Invalid command")
obj=car()
obj.carcommand()
