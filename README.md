Christopher Shin 100974007

Portal revised:

In a nutshell, you have to reach the yellow cube to win, and falling off or making contact with the red projectiles makes you lose. 
You use left-click to create a portal that travels and stops when hitting an obstacle and can teleport any object that is not a obstacle.
There are also a few enemies that get in your way. 


## Before:

<img width="619" height="161" alt="image" src="https://github.com/user-attachments/assets/7d72726f-5cc3-40bf-ae98-13334027d1d4" />

## After:

<img width="619" height="165" alt="image" src="https://github.com/user-attachments/assets/6b4c8f0a-e0a2-4e8a-91e4-7f651ef846bd" />


## What did you notice was impacting the performance of your project?

I noticed that spawning projectiles per frame was hurting my performance.


## Which pattern(s) did you implement, and what behavior did they replace?

A pattern I implemented was a singleton as an object pool for projectiles. I also tried doing a dirty flag in my projectiles. This replaced the basic instantiation every frame and the bullets constantly being active. 

## Do your patterns / technique implementations improve performance? Why or why not?

I think that the pattern did improve my performance, as before the profiler was much more spikey and wavy than the one after. In the image after implementation, the profiler was flatter.

## Can you demonstrate what the profiling process revealed?

When I looked at the profiler, I noticed that most of the CPU usage was in Other. This is probably due to the garbage collection that is happening there. That is where the differences became apparent to me. Before implementation, on average, it was hitting above 2 ms, whereas after implementation it was usually below 2ms. 
