# Zynga - The Grep Tribe
# google drive link - https://drive.google.com/file/d/1F3Rnj6yquWGGJ77iG1-V-EFvcaz5b1vz/view?usp=sharing
Zynga gaming hackathon
How they have designed the game?
---------------------------------------------------------------------------------------------------------------------------------------------------------------------ans----
Create a new Unity project: Open Unity, click on "New" to create a new project, and choose 2D from the options.

Set up the scene: Create a new scene by clicking on "File" > "New Scene." Then, add a camera by right-clicking in the hierarchy window and selecting "Camera." Set the camera's position to (0,0,-10) to view the scene from a distance.

Add a player: Add a player object to the scene by right-clicking in the hierarchy window and selecting "Create Empty." Rename the object to "Player" and add a sprite renderer component to it.

Add movement controls: Create a new script for the player object by right-clicking in the project window and selecting "Create" > "C# Script." Name the script "PlayerController" and open it in your code editor. Write code to allow the player to move left, right, up, and down. You can use the Input.GetAxis function to get the horizontal and vertical axis values and move the player object accordingly.

Add shooting controls: Create a new script for the player object called "PlayerShooting" and write code to allow the player to shoot. You can use the Input.GetKeyDown function to detect when the player presses the space bar and instantiate a bullet object at the player's position.

Add enemies: Create a new enemy object and add a sprite renderer component to it. Then, create a new script called "EnemyController" and write code to allow the enemy to move left and right. You can use the Mathf.Sin function to create a smooth back-and-forth movement pattern.

Add collision detection: Create a new script called "CollisionDetection" and write code to detect collisions between the player, enemy, and bullet objects. When a collision is detected, you can destroy the objects and increase the player's score.

Add UI elements: Create a new canvas object and add a Text component to display the player's score. You can update the score each time an enemy is destroyed.

Test and refine: Test your game and make adjustments to the player movement, enemy behavior, and game mechanics as needed

 What Architecture they have used. How they created the art, from where did they source the art assets. Who created the art?
---------------------------------------------------------------------------------------------------------------------------------------------------------------------
 ans---
There are different architectural patterns that can be used to develop a 2D space shooter game in Unity, and the choice of architecture will depend on the specific requirements and goals of the project. Here are a few possible options:

Object-Oriented Programming (OOP): This is a commonly used approach in game development, where game objects are represented as classes, with properties and behaviors defined in the code. This architecture can work well for smaller projects with a straightforward game structure and relatively simple gameplay mechanics.

Model-View-Controller (MVC): This architecture is commonly used in software development, and can be applied to game development as well. In a 2D space shooter game, the model can represent the game state, the view can represent the graphical representation of the game, and the controller can handle the user input and game mechanics.

Scriptable Objects: This architecture can be used to create reusable data-driven components that can be easily configured and updated. Scriptable Objects can be used to define enemy behavior, weapon properties, and other game parameters.
since our team didn't have any artist so we decided to take the assets from unity store and various online resourses.

What is the future scope of the game? Can you see it becoming a multiplayer game? If yes, how
---------------------------------------------------------------------------------------------------------------------------------------------------------------------
ans---
The future scope of a 2D space shooter game depends on various factors such as advancements in technology, changing trends in the gaming industry, and evolving player preferences. However, 2D space shooter games are still popular among players, and there are many opportunities to innovate and expand on the genre.

Regarding the question of whether a 2D space shooter game can become a multiplayer game, the answer is yes. Multiplayer features such as cooperative play, player versus player (PvP) battles, and leaderboards can be integrated into a 2D space shooter game to add a new layer of excitement and social interaction.
To implement multiplayer features in a 2D space shooter game, you would need to consider the following:

Network architecture: You will need to design and implement the network architecture to support multiplayer features. This includes setting up a server to handle communication between players, establishing a protocol for data transmission, and managing player connections and disconnections.

Gameplay mechanics: You will need to modify or add new gameplay mechanics to support multiplayer features. For example, you might need to adjust enemy AI behavior to account for multiple players or add new weapons and power-ups to balance the gameplay.

User interface: You will need to design a user interface that enables players to join multiplayer sessions, view other players' stats, and communicate with other players.

Overall, adding multiplayer features to a 2D space shooter game can increase engagement, expand the audience, and provide new opportunities for monetization. However, it requires careful planning, development, and testing to ensure a seamless and enjoyable experience for players.
