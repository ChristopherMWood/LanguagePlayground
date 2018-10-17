import sys
import random

def validateArguments():
    if len(sys.argv) != 2:
        print("Error: Must provide number of sides of dice.")
        sys.exit()

    try:
        return int(sys.argv[1])
    except ValueError:
        print("Error: Must provide an int for number of sides of dice.")

def rollDice(sidesOfDice):
    return random.randint(1, sidesOfDice)
    
sidesOfDice = validateArguments()
diceValue = rollDice(sidesOfDice)

print("The " + str(sidesOfDice) + " sided dice rolled " + str(diceValue) + ".")