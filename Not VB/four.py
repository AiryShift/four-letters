from random import randrange, shuffle
from time import time, sleep
from threading import Thread

COMBO_ALLOWED_TIME = 2
MAX_TIME = 20
EXTRA_TIME_PER_WORD = 5
timeLeft = MAX_TIME
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
    print("""Form an anagram from:
 {}
{} {}
 {}
You have {:f} seconds left.""".format(
         word[0], word[1], word[2], word[3], timeLeft))


def game():
    global score
    global timeLeft
    global currentWord
    scoreMultiplier = 0
    while timeLeft >= 0:
        currentWord = selectWord()
        timeOfLastMatch = time()
        while timeLeft >= 0:
            printWord(currentWord)
            guessedWord = input("Word: ")
            if timeLeft >= 0:
                if guessedWord in WORD_SET:
                    if time() - timeOfLastMatch < COMBO_ALLOWED_TIME:
                        scoreMultiplier += 1
                    else:
                        scoreMultiplier = 0
                    score += 1 + scoreMultiplier
                    timeLeft += EXTRA_TIME_PER_WORD
                    if timeLeft > MAX_TIME:
                        timeLeft = MAX_TIME
                    break
                else:
                    print("Incorrect, try again")


def timer():
    global score
    global timeLeft
    global currentWord
    while timeLeft >= 0:
        sleep(0.1)
        timeLeft -= 0.1
    print("""\nYour score is: {}, thank you for playing. The word was {}
Press enter to exit.""".format(
        score, currentWord))

if __name__ == "__main__":
    thread1 = Thread(target=game)
    thread2 = Thread(target=timer)
    thread1.start()
    thread2.start()
