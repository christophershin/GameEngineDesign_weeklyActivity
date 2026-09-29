Christopher Shin 100974007

Portal revised:

In a nutshell, you have to reach the yellow cube to win, and falling off or making contact with the red projectiles makes you lose. 
You use left-click to create a portal that travels and stops when hitting an obstacle and can teleport any object that is not a obstacle.
There are also a few enemies that get in your way. 


<img width="494" height="343" alt="image" src="https://github.com/user-attachments/assets/dd6e2a35-8665-48b8-8f7f-53a3e9aade3a" />

The elements of my game that utilize this pattern are enemy spawning and projectile spawning. This is good for me, as I would like to spawn many different kinds of enemies and projectiles, and factories allow me to do that. I am probably scratching the surface of what I can do with factories, but for me, I think it's neat that I can call a spawn method anywhere I want if I have the spawner prefab. Another reason is that if I have a phase in a boss battle where it spawns different projectiles, factories can help with that without using a switch statement. 
