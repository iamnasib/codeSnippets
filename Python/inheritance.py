class Animal:
    def sound(self):
        pass
class Dog(Animal):
    def sound(self):
        return "bark"

class cat(Animal):
    def sound(self):
        return "Meow"

def show_sound(animal):
    print(f"This animal says: {animal.sound()}")
    
dog=Dog()
Cat=cat()

show_sound(dog)  # Output: This animal says: Woof!
show_sound(Cat)

