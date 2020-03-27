# Analog-Digital-Clock

Showcase of a simplistic clock that has both analog and digital elements
Digital clock is in 24h format, the analog clock works as the standard that you expect in any analog clock.

# HOW TO RUN 

To run the project you only need to open the project in Unity, and press play. 
The game will automatically sync the clock's time to the current time on the local machine.

If you run into errors, you most likely need to assign the analog clock hands from the inspector. 
They are found in Clock/Pivot-second & minute & hour. Same goes for the digital display, 
and that is found in Canvas/Panel/DigitalClock/Digits

# HOW THE CODE WORKS

Digital clock:
The project uses the local time system, with System.DateTime in code.
That feature is implemented to get the numerical values from the local machine, and then the program uses those values to
update hours, minutes and seconds to their right places visually.

Analog clock:
Same as above, but here there is no text, only the three hands of the clock.
With public gameobject references to each hand, all hands are referenced from the inspector.
The project uses Quaternion.euler to set the current time to move the hands to their right places, by adjusting the Z value accordingly.

To make the hour and minute hands move more realisticly, I've made it so that the hour hand also uses the minute hand to move itself forward between two hours, so it doesn't just jump instantly to the next. Same goes with the minute hand, but using the second hand of course.

