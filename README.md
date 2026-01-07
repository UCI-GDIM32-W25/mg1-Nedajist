[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1

### Activity 1
Start working on an assignment on the day that it is assigned. This reduces the likelihood of procrastination. 

### Activity 2
1. 10
2. 2
3. These lines of code call the PrintMessage function, which prints "hello world" to Unity's console. This happens every frame.
4. MonoBehavior
5. These lines of code prints "x = 10" to Unity's console when the object with this script first appears in a scene
6. The 10 is the argument given to PrintMessage(), and the argument is passed to x. x is the parameter passed to Debug.log. 
7. Transform is not an object, but a class in Unity. While Translate is a method of the transform class, it can only be called on an instance of the class, not on the class itself. 
8. Replace Transform with _playerTransform

### Activity 3
[MG1 breakdown Google doc](https://docs.google.com/document/d/1UQTlTMUv7OoSRXdfaYn3iWpCgYABL-kNvOKmFYxCaUk/edit?tab=t.0)

## Devlog
1. Kai Meng, he/him
2. My Minigame breakdown document states that one of the player class's methods will instantiate a seed object. I also believed that the player class has a method which updates the UI text object.
These plans turned out to be true, as the Player class has a method called PlantSeed() which does both. 
I thought both the player and seed objects would have a sprite component, and the Player and seed objects do indeed have a sprite renderer component. 

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
