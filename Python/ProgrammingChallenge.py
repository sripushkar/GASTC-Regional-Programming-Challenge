import re
import time

#The main menu. It prompts users to pick a program to run.
def mainMenu():
    print("Welcome!")
    print("1) Even Numbers")
    print("2) Order Numbers")
    print("3) Telephone Converter")
    print("4) String Searching")
    print("Anything else: quit\n")

    inputProgram = input("Please enter the number of the program you want to run: ")

    #Selects program or quits based on input.
    if inputProgram == "1":
        evenNumbers()
    elif inputProgram == "2":
        orderNumbers()
    elif inputProgram == "3":
        telephoneConversation()
    elif inputProgram == "4":
        stringSearch()
    else:
        quit()

#This is a reusable function that validates input so that only positive numbers can be entered. Used in programs 1 and 2.
def inputNumber(message):
    while True:
      try:
         numberInput = int(input(message))
      except ValueError:
         print("Sorry, you did not enter a valid number.")
         continue
    #Change this line if you want to specify further what integers you want, or remove it if you want to allow all integers.
      if numberInput>=0:
          return numberInput
          break
      else:
         continue
#Program 1
def evenNumbers():
    topNumber = inputNumber("Please enter a number: ")
    #Loops and prints even numbers until the input number is reached.
    iterator = 0
    while iterator <= topNumber:
        print(iterator)
        iterator += 2

    print("\nProgram Completed! Returning to main menu.\n")
    time.sleep(2)
    mainMenu()

#Program 2
def orderNumbers():
    #Declares an empty list to store values.
    numberList = []

    #Asks for user input, and then places it into the list with append(), then sorts it with sort()
    while True:
        enteredNumber = inputNumber("Please enter a number(or 0 to quit): ")
        if enteredNumber != 0:
            numberList.append(enteredNumber)
            numberList.sort()
            for x in range(len(numberList)):
                print(numberList[x])
        #ends the loop if the user inputs 0
        else:
            break
    #Prints the ordered list
    print("Here is your list of numbers:")
    for x in range(len(numberList)):
        print(numberList[x])

    print("\nProgram Completed! Returning to main menu.\n")
    time.sleep(2)
    mainMenu()

#Program 3
def telephoneConversation():
    #Asks for a phone number with characters, and converts to all uppercase characters
    rawPhoneNumber = input("Please enter a phone number with characters included: ")
    formattedPhoneNumber = rawPhoneNumber.upper()

    #Converts the letters to their respective characters
    formattedPhoneNumber = formattedPhoneNumber.replace("A", "2")
    formattedPhoneNumber = formattedPhoneNumber.replace("B", "2")
    formattedPhoneNumber = formattedPhoneNumber.replace("C", "2")
    formattedPhoneNumber = formattedPhoneNumber.replace("D", "3")
    formattedPhoneNumber = formattedPhoneNumber.replace("E", "3")
    formattedPhoneNumber = formattedPhoneNumber.replace("F", "3")
    formattedPhoneNumber = formattedPhoneNumber.replace("G", "4")
    formattedPhoneNumber = formattedPhoneNumber.replace("H", "4")
    formattedPhoneNumber = formattedPhoneNumber.replace("I", "4")
    formattedPhoneNumber = formattedPhoneNumber.replace("J", "5")
    formattedPhoneNumber = formattedPhoneNumber.replace("K", "5")
    formattedPhoneNumber = formattedPhoneNumber.replace("L", "5")
    formattedPhoneNumber = formattedPhoneNumber.replace("M", "6")
    formattedPhoneNumber = formattedPhoneNumber.replace("N", "6")
    formattedPhoneNumber = formattedPhoneNumber.replace("O", "6")
    formattedPhoneNumber = formattedPhoneNumber.replace("P", "7")
    formattedPhoneNumber = formattedPhoneNumber.replace("Q", "7")
    formattedPhoneNumber = formattedPhoneNumber.replace("R", "7")
    formattedPhoneNumber = formattedPhoneNumber.replace("S", "7")
    formattedPhoneNumber = formattedPhoneNumber.replace("T", "8")
    formattedPhoneNumber = formattedPhoneNumber.replace("U", "8")
    formattedPhoneNumber = formattedPhoneNumber.replace("V", "8")
    formattedPhoneNumber = formattedPhoneNumber.replace("W", "9")
    formattedPhoneNumber = formattedPhoneNumber.replace("X", "9")
    formattedPhoneNumber = formattedPhoneNumber.replace("Y", "9")
    formattedPhoneNumber = formattedPhoneNumber.replace("Z", "9")

    #Prints the converted number.
    print("Your converted phone number is: " + formattedPhoneNumber)
    print("\nProgram Completed! Returning to main menu.\n")
    time.sleep(2)
    mainMenu()

#Program 4
def stringSearch():
    #Asks for a string, and the search string
    stringInput = input("Please enter a target string: ")
    stringSearchInput = input("Please enter a search string: ")

    #Uses the REGEX module to search the amount of times it shows up, and places it in a list.
    timesList = re.findall(stringSearchInput, stringInput)

    #Prints how many times it showed up.
    print("The search string has showed up " + str(len(timesList)) + " times.")
    print("\nProgram Completed! Returning to main menu.\n")
    time.sleep(2)
    mainMenu()

#Runs the program.
mainMenu()
