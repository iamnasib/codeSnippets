import tkinter as tt
import time
class BouncingBall:
    def __init__(self):
        frame=tt.Tk()
        frame.title("Bouncing ball")
        DP=tt.Canvas(frame,width="500",height="400",highlightbackground="Red", bg="Black")
        MB=DP.create_oval(10,10,30,30,fill="red")
        MB2=DP.create_oval(100,100,50,50,fill="green")
        bar = DP.create_rectangle(300,400,210,390,fill="yellow")
        DP.pack()
        x_speed=2
        y_speed=3
        x_speedbar=2
        y_speedbar=0
        
        while True:
            DP.move(MB,x_speed,y_speed)
            DP.move(MB2,x_speed,y_speed)
            DP.move(bar,x_speedbar,y_speedbar)
            mycoords=DP.coords(MB)
            barcoords=DP.coords(bar)
            if mycoords[2]>500 or mycoords[0]<0:
                x_speed=-x_speed
            if barcoords[2]>500 or barcoords[0]<0:
                x_speedbar=-x_speedbar
            if mycoords[3]>400 or mycoords[1]<0:
                y_speed=-y_speed
            DP.update()
            time.sleep(0.02)


obj=BouncingBall()
        
