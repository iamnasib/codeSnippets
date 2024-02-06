'''students=["Nasib","Athar","Bakhtiyar","Burhan"]
marks=[464,380,464,379]

for student,mark in zip(students,marks):
    print(student,"\t",mark)

with open ("D:/Projects/python/CSVFILES/student_list.txt") as file1,open ("D:/Projects/python/CSVFILES/marks_list.txt") as file2:
    for student,mark in zip(file1,file2):
    print(student,"\t",mark)


#map() process which links two things

def add(n1,n2):
    return n1+n2

numbers1=[2,3,4,5]
numbers2=[6,7,8,9]

for total in map(add,numbers1,numbers2):
    print(total)'''

#List  comprehension
numbers=[]

numbers=[n**2 for n in range(1,10)]
for i in numbers:
    if i%2==0:
        print(i)
     

'''
#dictionary  comprehension
products={"item1":10,"item2":15,"item3":20,"item4":25}

price={k:v*2 for k,v in products.items()}
print(price)

import json
#JSON OBJECT
std='{"name":"nasib","rollno":"10","age":"19","address":"hmt"}'
python_obj=json.loads(std)
print(type(python_obj))
print(python_obj["name"])

std_dict={"name":"nasib","rollno":"10","age":"19","address":"hmt"}
std_JSON=json.dumps(std_dict)
print(type(std_JSON))



python object which get converted into JSON
dict    >>list>> tuple >>string >>int >>float >>true>>false>>none
JSON equilent
object  >>array>>array>>string>>number>>number>>true>>false>>null
'''






















