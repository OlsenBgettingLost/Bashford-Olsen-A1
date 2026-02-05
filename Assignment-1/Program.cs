// game starts

using System.ComponentModel.Design;

Console.WriteLine(@"(side notes: this game requires you to type
in a response when asked for. you must only type in a response if it is
given to you as such 

'this would be what you respond with'

if the response you give does not match perfectly within any of the given options given in
an apostrophe 'apostrophe', you will recieve an -INVALID RESPONSE-
and you will lose the game and have to start over.

also note that you may have to scroll up a bit after typing in a response due to amazingly
(and agnonizingly) long naratives. you will recieve a -the end-
when you have completed the game.

-STS)
");
Console.WriteLine(@"---------------------------------------------------SCROLL AND READ SIDE NOTE ABOVE BEFORE STARTING THE GAME BELOW------

VENTS [V1.1] (first demo)
BY sharktheshark



You awaken in a white room...
nothing but white. small as a bedroom. or an average office.
use your imagination.

There apears to be no way out, aside from these 2 doors.
they look identicle. they sit beside eachother but spaced out.
this could be a way out.

You have no memory of who you are or how you ended up in the room.
you are drawn by curiosity to choose a door. your unsure what hides behind,
and you have a sense that one door is better then the other. but which one?

what door do you choose?
The 'left' door? or the 'right' door?


");

string decisionOne = Console.ReadLine();

if (decisionOne == "left")
{

    Console.WriteLine(@"


You walk tawords the left door. you glance at the handle.
you think to yourself that you dont have anything to lose but your life, which you have no memory
of. you think to yourself ''just open it''.

you grab the handle, and you pull it down to open the left door.

its a pitch black void. you cant see anything that passes through.
well, other then the light from the white room shining in, which you cant seem
to figure out where its source is from.

you feel the sense to fear the dark. or is it the unkown that lies within that you fear.
you let go of the handle and step back. the door shuts on its own. you glance
at the right door and you open it.

void.

at this point, you feel no difference from what you can
see from both doors. you think to yourself, ''does it really matter what door i go through?''

you think about if you should switch doors or not.

do you switch to the 'right door'? or stick to the 'left door'?

");
    string Switch = Console.ReadLine();

    if (Switch == "right door")
    {

        Console.WriteLine(@"


You decide that both doors apear the same and you might as well go through the door
that you already have open. the right door.

you hesitate...

then you take a deep breath.... and walk into the void.
            
The door shuts behind you with a slam! 
and the void is replaced with another 
bright light with no apparent source.

you are met with a hallway. you turn. but where did the door go?
just another white wall fills its place. you are left with no choice but to wonder through the hall.
it was a fairly short walk. you find yourself in another room identical to the one you woke up in,
white and bright. with 2 doors.
but something is off.

the right door is higher then the left. it has 
stairs leading up to it. you are not sure which door you should choose. so you go with your gut.

what does your gut say?

the 'normal left door'? or the 'right door with stairs'?




");
        string decisionTwo = Console.ReadLine();

        if (decisionTwo == "normal left door")
        {
            Console.WriteLine(@"


You decide to switch it up and try the left door. something about that right door just seems realy off.
you grab the handle and pull the left door open. again, void.

you walk through and the door shuts behind you once more. lights come on and the door vanishes like before.
you are met with another hall. but this one apears longer.

you start walking.

this hall is definitely longer then the last.

you feel like you have walked the distance of a football field.
you turn you head around to see that the wall you started from, (where the door used to be) was directly behind you.
like you never left. you walk some more to realize the wall follows.

you are stuck in an infinite hallway with no escape. 

days go by and you starve to death. without knowing anything about who you are or where you came from.
you know that you had some kind of life. but you die knowing that you will never get to find that out..... . .   .


");
        }
        else if (decisionTwo == "right door with stairs")
        {
            Console.WriteLine(@"


There is something about the door with stairs that scream ''open me''.
you choose to trust them.

you walk up 5 steps to the right door.
you grab the handle and open it. same as before, void.

you walk in. The door shuts behind you with a slam and the void is replaced with another 
bright light with no aparent sorce.

Its a smaller white room... 

much smaller...

ahead of you, you see a red button..., on, the wall.


you look back a just like last time, the door is gone and is replaced with wall.
with no choice. you press, the button.



you feel light headed and collaps onto the floor. you lose conscience.



you wake up to find yourself in in a bed?
you think about the crazy dream you just had. and yet, it felt so real.

you resume your regular life.

the day has ended. you're tierd from a day in the office. you get home and head straight
for your room. you open the door and walk into your dark room.
the door shuts behind you. you turn around in panic. you door has vanished. replaced with wall.

your whole room is just walls and bright white space.....

YOU WAKE UP!!!

in a room. a white room. you just woke up from a dream about a life you dont reconize.
you cant remember your life or who you are or where you came from.
you glance around. and you see 2... 

doors.


(ENDING 3/3, FOREVER LOOP [GOOD ENDING])


-THE END-



");
        }
        else
        {
            Console.WriteLine("INVALID RESPONSE");
        }
    }
    else if (Switch == "left door")
    {
        Console.WriteLine(@"




you decide that you would stick with your first decision.
After you thought about if switching doors would make a difference, 

you let go of the right door and it shuts.
you walk over to the left door and you open it.

you hesitate...

then you take a deep breath.... and walk into the void.
            
The door shuts behind you with a slam and the void is replaced with another 
bright light with no aparent source.

Its a smaller white room. much smaller. ahead of you, you see a red button on the wall.
you think that you've hit a dead end.
you turn around to open the door to walk out of the room. but where did the door go?
just another white wall fills its place. you are left with no choice but to press the red 
button.
you press the button and for a moment... nothing.
you press it again... nothing... again.
you realize you have just traped yourself in this room with a pointless button and 
no way to escape.

            

an hour has past, yet it feels like its been over 2. you realize that the room 
apears a bit smaller then what you remembered it. you shrug it off and blame
your mind for playing tricks.

another hour...

you start to realize that the cieling deffently seems a bit.. closer.
are you getting taller?

no...?
            
            

the button is still at the same eye level as always.

half hour later. you no longer need to adjust your head up from the button to the 
cieling. you're looking at both now.
the roof is coming down!
and you now realize that within the next hour or so, 
you are going to be slowley crushed to death.
            
the cieling has passed the button. you cant see it anymore. you are sitting on the ground,
hunched over.
the cieling is pressing you down... slowley.......




 -splat-

(ENDING 1/3, THE RED BUTTON DEATH ENDING)

");
    }
    else
    {
        Console.WriteLine("INVALID RESPONSE");
    }
}
else if (decisionOne == "right")
{
    Console.WriteLine(@"


You walk tawords the right door. you glance at the handle.
you think to yourself that you dont have anything to lose but your life, which you have no memory
of. you think to yourself ''just open it''.

you grab the handle, and you pull it down to open the right door.

its a pitch black void. you cant see anything that passes through.
well, other then the light from the white room shining in, which you cant seem
to figure out where its source is from.

you feel the sense to fear the dark. or is it the unkown that lies within that you fear.
you let go of the handle and step back. the door shuts on its own. you glance
at the left door and you open it.

void.

at this point, you feel no difference from what you can
see from both doors. you think to yourself, ''does it really matter what door i go through?''

you think about if you should switch doors or not.

do you switch to the 'left door'? or stick to the 'right door'?


");

    string Switch2 = Console.ReadLine();

    if (Switch2 == "left door")
    {

        Console.WriteLine(@"


You decide that both doors apear the same and you might as well go through the door
that you already have open. the left door.

you hesitate...

then you take a deep breath.... and walk into the void.
            
The door shuts behind you with a slam and the void is replaced with another 
bright light with no aparent sorce.

Its a smaller white room. much smaller. ahead of you, you see a red button on the wall.
you think that you hit a dead end.
you turn around to open the door to walk out of the room. but where did the door go?
just another white wall fills its place. you are left with no choice but to press the red 
button.
you press the button and for a moment... nothing.
you press it again... nothing... again.
you realize you have just traped yourself in this room with a pointless button and 
no way to escape.

            

an hour has past, yet it feels like its been over 2. you realize that the room 
apears a bit smaller then what you remembered it. you shrug it off and blame
your mind for playing tricks.

another hour...

you start to realize that the cieling deffently seems a bit.. closer.
are you getting taller?

no...?
            
            

the button is still at the same eye level as always.

half hour later. you no longer need to adjust your head up from the button to the 
cieling. you're looking at both now.
the roof is coming down!.
and you now realize that within the next hour or so, 
you are going to be slowley crushed to death.
            
the cieling has passed the button. you cant see it anymore. you are sitting on the ground,
hunched over.
the cieling is pressing you down... slowley.......




 -splat-

(ENDING 1/3, RED BUTTON DEATH ENDING)


");




    }
    else if (Switch2 == "right door")
    {
        Console.WriteLine(@"


you decide that you would stick with your first decision.
After you thought about if switching doors would make a difference, 

you let go of the left door and it shuts.
you walk over to the right door and you open it.

you hesitate...

then you take a deep breath.... and walk into the void.

The door shuts behind you with a slam and the void is replaced with another 
bright light with no aparent source.

you are met with a hallway. you turn. but where did the door go?
just another white wall fills its place. you are left with no choice but to wonder through the hall.

it was a fairly short walk. you find yourself in another room identical to the one you woke up in,
white and bright. with 2 doors. but something is off. the right door is higher then the left. it has 
stairs leading up to it. you are not sure which door you should choose. so you go with your gut.

what does your gut say?

the 'normal left door'? or the 'right door with stairs'?


");
    }
    string decisionTwoAgain = Console.ReadLine();

    if (decisionTwoAgain == "normal left door")
    {
        Console.WriteLine(@"


You decide to switch it up and try the left door. something about that right door just seems realy off.
you grab the handle and pull the door open. again, void.

you walk through and the door shuts behind you once more. lights come on and the door vanishes like before.
you are met with another hall. but this one apears longer.

you start walking.

this hall is deffently longer then the last.

you feel like you have walked the distance of a football field.
you turn you head around to see that the wall you started from, (where the door used to be) was directly behind you.
like you never left. you walk some more to realize the wall follows.

you are stuck in an infinite hallway with no escape. 

days go by and you starve to death. without knowing anything about who you are or where you came from.
you know that you had some kind of life. but you die knowing that you will never get to find that out..... . .   .


( ENDING 2/3, LONGEST FOOTBALL GAME EVER ENDING)
");
    }
    else if (decisionTwoAgain == "right door with stairs")
    {
        Console.WriteLine(@"


There is something about the stairs that scream ''open me''.
you choose to trust them.

you walk up 5 steps to the right door.
you grab the handle and open it. same as before, void.

you walk in. The door shuts behind you with a slam and the void is replaced with another 
bright light with no aparent source.

Its a smaller white room... 

much smaller...

ahead of you, you see a red button..., on, the wall.


you look back a just like last time, the door is gone and is replaced with wall.
with no choice. you press, the button.



you feel light headed and collaps onto the floor. you lose conscience.



you wake up to find yourself in in a bed?
you think about the crazy dream you just had. and yet, it felt so real.

you resume your regular life.

the day has ended. you're tierd from a day in the office. you get home and head straight
for your room. you open the door and walk into your dark room.
the door shuts behind you. you turn around in panic. you door has vanished. replaced with wall.

your whole room is just walls and bright white space.....

YOU WAKE UP!!!

in a room. a white room. you just woke up from a dream about a life you dont reconize.
you cant remember your life or who you are or where you came from.
you glance around. and you see 2... 

doors.


( ENDING 3/3, FOREVER LOOP ENDING [GOOD ENDING])


-THE END-


");


    }
    else
    {
        Console.WriteLine("INVALID RESPONSE");
    }
}

Console.WriteLine("game over");
