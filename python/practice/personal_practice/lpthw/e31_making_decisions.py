# Learn Python the hard way
# Exercise 31: Making Decisions

print "LPTHW Practice"
print "E31: Making Decisions"
print "Done by Lucas Costa"
print "Date: 02/09/2016"
print "else if statements are written: elif x == y:"
print ""

print "You enter a dark room with two doors. Do you go through door #1 or #2?"

door = raw_input("> ")

if door == "1":
    print "There's a giant bear eating a cheese cake. What do you do?"
    print "1. Take the cake"
    print "2. Scream at the bear"

    bear = raw_input("> ")

    if bear == "1":
        print "The bear eats your face off. Good job!"
    elif bear == "2":
        print "The bear eats your legs off. Good job!"
    else:
        print "Well, doing %s is probably better. Bear runs away" % bear

elif door == "2":
    print "You stare into the endless abyss at Cthulhu's retina"
    print "1. Blueberries"
    print "2. Yellow jacket clothespins."
    print "3. Understaning revolvers yelling melodies"

    insanity = raw_input("> ")

    if insanity == "1" or insanity == "2":
        print "Your body survives powered by a mind of jello. Good job"
    else:
        print "The insanity rots your eyes into a pool of much. Good job"

else:
    print "You stumble around and fall on a knife and die. Good job..."
