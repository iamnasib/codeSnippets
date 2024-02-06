from tkinter import *
from tkinter.filedialog import askdirectory
import os
import pygame
class myplayer:
    def __init__(self):
        frame=Tk()
        frame.geometry("500x500")
        frame.title("My player")
        self.vr=StringVar()
        song_tittle=Label(frame,textvariable=self.vr,font="aerial 14 bold",fg="red",bg="#111")
        self.play_btn   =Button(frame,text="Play",width=5,height=3,font="aerial 14 bold",fg="red",bg="#111",command=self.play_func)
        self.pause_btn  =Button(frame,state="disabled",text="Pause",width=5,height=3,font="aerial 14 bold",fg="red",bg="#111",command=self.pause_func)
        self.stop_btn   =Button(frame,state="disabled",text="Stop",width=5,height=3,font="aerial 14 bold",fg="red",bg="#111",command=self.stop_func)
        self.resume_btn =Button(frame,state="disabled",text="Resume",width=5,height=3,font="aerial 14 bold",fg="red",bg="#111",command=self.resume_func)
        self.song_listbox=Listbox(frame,font="aerial 14 bold",fg="red",bg="#111",selectmode=SINGLE)
        song_tittle.pack()
        self.play_btn.pack(fill="x")
        self.pause_btn.pack(fill="x")
        self.stop_btn.pack(fill="x")
        self.resume_btn.pack(fill="x")
        self.song_listbox.pack(fill="both",expand="yes")
        ad=askdirectory()
        os.chdir(ad)
        all_songs=os.listdir()
        pos=0
        for song in all_songs:
            self.song_listbox.insert(pos,song)
            pos+=1
        pygame.init()
        pygame.mixer.init()
    def play_func(self):
        print("playing")
        pygame.mixer.music.load(self.song_listbox.get(ACTIVE))
        self.vr.set(self.song_listbox.get(ACTIVE))
        pygame.mixer.music.play()
        self.pause_btn["state"] = "normal"
        self.stop_btn["state"] = "normal"
    def pause_func(self):
        pygame.mixer.music.pause()
        self.pause_btn["state"] = "disabled"
        self.resume_btn["state"] = "normal"
    def stop_func(self):
        pygame.mixer.music.stop()
    def resume_func(self):
        self.pause_btn["state"] = "normal"
        pygame.mixer.music.unpause()
        self.resume_btn["state"] = "disabled"


obj=myplayer()

    
