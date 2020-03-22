Anyway,  I can do that then maybe make something that like, has two gas inputs and generates power based on the temp difference of the input gas, and outputs tepid gas, maybe destroying some heat on the way.
asquared31415Today at 4:20 PM
That would be neat
Create power from a temperature difference between two piped elements, or maybe between a coolant and the environment?
icefoxToday at 4:22 PM
What would be most like a real sterling engine would be like, having two particular blocks and generating energy based on the temp difference between them
but there's not really anything like that in the game already, iirc, so that might be hard.  Difference between coolant and environment might work better.
asquared31415Today at 4:23 PM
Pipes also work more with the theme of the game
icefoxToday at 4:23 PM
anyway, first let's finish this tutorial and do anything at all successfully
asquared31415Today at 4:23 PM
Though with heat there’s a lot more to do with tiles than mechanics
icefoxToday at 4:32 PM
like in a perfect world I'd have something like this

2 wide, 4 tall
asquared31415Today at 4:33 PM
spinny bit lmao
icefoxToday at 4:33 PM
probably a lot easier to do a coolant input though
(I don't actually know how a sterling engine works mechanically, just in terms of physics.)
@Peter Han word on the street is you're working on a sterling engine mod?
If I had the above and were real pro the animation would run in reverse if the hot and cold side were swapped...

HexicubeToday at 4:38 PM
youd just have two anims
asquared31415Today at 4:38 PM
Yea
You can play whatever anim you like in a state machine
Have an On and an OnReverse state
icefoxToday at 4:40 PM
oh snap, I didn't know that
anyway, that's firmly wishlist territory
asquared31415Today at 4:40 PM
State machines handle almost all the animations in the game
icefoxToday at 4:41 PM
didn't realize you could have multiple animations for a building, is all.
HexicubeToday at 4:41 PM
to be fair you can just not have a reverse since a sterling engine doesnt care I think
asquared31415Today at 4:41 PM
All the buildings do
They have an off animation, a build animation, a UI animation, an on animation
HexicubeToday at 4:42 PM
off/on is statemachine
asquared31415Today at 4:42 PM
Many have a loop and loop start/end
Depends on how the state machine is set up
icefoxToday at 4:43 PM
thought the "off" animation was just one frame.  So you could make a flying toaster screensaver for the supercomputer that played when it wasn't in use?
HexicubeToday at 4:43 PM
*oh is statemachines rather
icefoxToday at 4:43 PM
What's the UI animation?
asquared31415Today at 4:44 PM
It technically doesn’t have to be 1 frame I think
It’s the picture shown in the UI and it’s handled weirdly
HexicubeToday at 4:44 PM
off is played when a building is built
asquared31415Today at 4:44 PM
But it’s part of the Kanim for everything