# StressTestPhysics
 This project is meant to stress test the physics engines inside of Unity and Godot, compare them with eachother and see which ones performs the best.
 
 
# How to go about, testing...

## What are you going to test?
 I am curious about how the inner workings of the physics systems work inside of Unity and Godot. And i want to stress test them all in custom physics simulations. I want to especially test this now due to Godot 4 introducing built in physics. This is a perfect oppurtunity to see where i should make a physics based game in.
 
 
## How will you determine there is a difference between the simulations?
This will be simply done by tracking the delta time between frames and recording them into a txt document. These findings will be put into a multitude of graphs.

# The process
So what i first started doing was work out the plan to actually start recording these performance tests. How it is set up, is like this:
- Have a box in the middle.
- In this box, squares and spheres spawned.
- Create an animator that counts in physics.
- Create 2 different animation clips, 1 just moving the box, and 1 moving and rotating the box.
- Write code to easily tweak changes into the simulation.
- Write code to record the results in a txt file.
- Make graphs.
- Make the report.

This was my plan from the start, and so, i started with setting my testing enviroment in Unity, the engine i knew at the time. I decided to start with Unity due to the fact it is the engine i know the best. In the oncoming weeks, i would be working with Godot during my Personal Portfolio, from there on i would know enough about Godot to easily set up a testing enviroment like in Unity as well... Or so i thought, but we will get back to that.

I set up the setup in Unity quite easily, you can see this in the repository itself. And creating the same testing scenario was not that difficult either inside of Godot. The process was moving along quickly. On top of this, to reproduce the same enviroment, i removed the skybox inside of unity (Godot as a standard doesnt have one.)

# The testing, iteration 1.
<picture>
 <source media="(prefers-color-scheme: dark)" srcset="/Images/GodotSetup.png">
 <source media="(prefers-color-scheme: dark)" srcset="Unity testing scenario">
</picture>
