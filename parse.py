from string import ascii_lowercase
LETTERS = set(ascii_lowercase)


def check(word):
    if len(word) != 4:
        return False
    for i in word:
        if i not in LETTERS:
            return False
    return True

with open('wordlist.txt') as f:
    with open('4wordlist.txt', 'w') as o:
        for i in f:
            i = i.strip()
            if check(i):
                o.write(i + '\n')
