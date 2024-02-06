from collections import Counter

data="hi hello how are you"
list_data=["apple","mango","apple","apple","mango","kiwi"]
set_data={"apple","mango","apple","apple","mango","kiwi"}
tup_data=("apple","mango","apple","apple","mango","kiwi")
dict_data={"item1":"apple","item2":"mango","item3":"apple","item4":"apple","item5":"mango"}
print(Counter(data))
print(Counter(list_data))
print(Counter(set_data))
print(Counter(tup_data))


c=Counter(list_data)
print(c.pop("apple"))
print(Counter(dict_data))
print(Counter(list_data))
