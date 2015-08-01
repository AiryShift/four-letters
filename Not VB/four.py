from random import randrange, shuffle
from time import time, sleep
from threading import Thread

COMBO_ALLOWED_TIME = 0.8
timeLeft = 15
score = 0
currentWord = ""

with open('../4wordlist.txt') as f:
    WORD_LIST = []
    for i in f:
        WORD_LIST.append(i.strip())
    WORD_SET = set(WORD_LIST)


def selectWord():
    return WORD_LIST[randrange(0, len(WORD_LIST))]


def printWord(word):
    word = list(word)
    shuffle(word)
    print("Form an anagram from: {}. You have {} seconds left.".format(
        ''.join(word), timeLeft))


def game():
    global score
    global timeLeft
    global currentWord
    scoreMultiplier = 0
    while timeLeft >= 0:
        currentWord = selectWord()
        printWord(currentWord)
        timeOfLastMatch = time()
        while timeLeft >= 0:
            printWord(currentWord)
            guessedWord = input("Word: ")
            if guessedWord == currentWord:
                if time() - timeOfLastMatch < COMBO_ALLOWED_TIME:
                    scoreMultiplier += 1
                else:
                    scoreMultiplier = 0
                score += 1 + scoreMultiplier
                timeLeft += 3
                break


def timer():
    global score
    global timeLeft
    global currentWord
    while timeLeft >= 0:
        sleep(0.1)
        timeLeft -= 0.1
    print("\nYour score is: {}, thank you for playing. The word was {}.".format(
        score, currentWord))

if __name__ == "__main__":
    thread1 = Thread(target=game)
    thread2 = Thread(target=timer)
    thread1.start()
    thread2.start()
