# Monopoly Like Game.

# Introduction
I have developed this game using only assets found on the internet and the Unity Asset Store for the visuals. All the code, however, is entirely my creation. If you have any problems or questions, feel free to reach out to me.

# 2. Dice Animation Creation System
Navigate to the Scene:
Go to Assets/Scenes/DiceAnimationCreation.
Rolling the Dice:
Click "Roll".
As soon as the dice finish rolling, two .csv files will be generated. These files contain the positions and rotations of the dice movements created physically.
Using the Dice Animator Editor:
Open the Dice Animator Editor via Tools > DiceAnimationEditor.
Attach each .csv file to the corresponding Text Asset field.
Rename the animation and create the dice animation.
Attach the generated animation to the animated dice to review the created animations.
Customizing Dice Rolling Physics:
To create unique dice rolling physics, you can edit the Roll method inside the Physical Dice script.
Adjust the spawn point and target point in the DicePhysicsController.
Using Created Animations in the Game:
To use the created animations in the game, copy and arrange the DiceFace component offsets on the dice in the scene.
It may be a bit complicated, but this method ensures a unique solution for creating deterministic animations.
Feel free to reach out for assistance.

