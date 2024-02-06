
num=int(input("Enter the number "))
print("***__________________________________***")
if num<0 and num%2==0:
    print("NUMBER IS NEGATIVE EVEN")
elif num>0 and num%2==0:
    print("NUMBER IS POSITIVE EVEN")
elif num>0 and num%2!=0:
    print("NUMBER IS POSITIVE ODD")
elif num<0 and num%2!=0:
    print("NUMBER IS NEGATIVE ODD")
else:
    print("INVALID")
if num<0:
    if num%2==0:
        print("NUMBER IS NEGATIVE EVEN")
    else:
        print("NUMBER IS NEGATIVE ODD")
else:
    if num%2==0:
        print("NUMBER IS POSITIVE EVEN")
    else:
        print("NUMBER IS POSITIVE ODD")
while num<=100:
    print("\t",num,end="")
    num=num++
while num<=100:
    if num%2==0:
        print(num)
    num=num++
        
        
