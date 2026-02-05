Game Title: Flappy Plane

Engine: Unity 6.3 LTS (6000.3.5f1)
Platform: Windows (PC)

--------------------------------
Description
--------------------------------
Flappy Plane is a simple 2D arcade game inspired by Flappy Bird.
The player controls a plane and must avoid obstacles by pressing the Space key to stay in the air.

--------------------------------
Controls
--------------------------------
- Space: Fly / Jump

--------------------------------
Game Flow
--------------------------------
- The game starts in an Idle state.
- The game begins when the player presses Space for the first time.
- The plane moves correctly based on Space input.
- The game ends when the plane collides with an obstacle.
- A Game Over state is triggered on collision.

--------------------------------
Scenes
--------------------------------
- Main Scene: Scenes/Game

--------------------------------
Architecture
--------------------------------
- The project uses a clean and readable architecture.
- Player movement, collision handling, and game states are managed by separate scripts.
- The code is structured for clarity and simplicity.

--------------------------------
Build Information
--------------------------------
- This folder contains a playable Windows build of the game.
- Run the game using the .exe file.
- Keep the _Data folder in the same directory as the .exe file.