
DESCRIPTION
Ghost Rush is a top-down 2D action game. It is made using the Unity framework and written in C#. The game's objective is to survive for 2 minutes while avoiding and fighting ghosts trying to kill the player. The player collects XP from fallen enemies to level up and upgrade his health and attack strength. Fallen enemies also drop temporary power-ups that can restore health, freeze nearby enemies and make the player invincible for a short while. Killing enemies and leveling up is incentivized, as enemies get progressively stronger and do not despawn.

IMPORTANT CLASSES
-PlayerController
 -Acts as an interface between health, attack, movement and other player scripts.
-EnemyController
 -Acts as interface between health and attack classes and also implements pathfinding, using A* Pathfinding.
-DropManager
 -Manages the probability of ability drops from enemies.
-PickupManager
 -Defines the coroutines that control the effects due to abilities.
-LevelManager
 -Defines the levelling system and how much XP is required for leveling up. Acts as transition to Upgrade Screen.
-UpgradeManager
 -Defines the upgrades received on leveling up by the player. Transitions into UpgradeUI Script.
-Various UI Classes
 -Define logic for UI elements such as the Pause Menu, Death Screen, Win Screen, and Settings Menu.

To play the game simply install the .exe file and run it.

