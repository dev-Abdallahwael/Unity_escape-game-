Survival score Game Documentation
1. Game Overview
•	Game Idea:
The game is a Survival score Game where the player controls a character That is imported from Unity assets store and must avoid getting hit by 4 enemies. The enemies are done by using Ai Behavior. The goal is to survive and collect 8 pickups to win while the score increases by collecting each pickup and the obstacles in the playground are ready made models.
•	Win State:
To survive and collect 8 pickups to win while the score increases by collecting each pickup.
•	Lose State:
The game ends when the enemies hits the user. Upon each hit the user’s health decrease by 20 till he dies, a Game Over Screen is displayed.
________________________________________
2. Screens in the Game
1.	Main Gameplay Screen:
o	Displays the player character in a 2D environment.
o	Shows a score counter at the top.
o	Includes visible obstacles randomly generated as the player progresses.

2.	Game Over Screen:
o	Displays a message: “Game Over!”
o	Includes a button to restart the game.
________________________________________
3. Score and Health Indicators
•	Score Counter:
o	A numeric value increments while the player is alive.
o	Reset to zero when the player restarts the game.
________________________________________
4. Win/Lose Screens
•	Win Screen:
o	Since this game has no definitive win state, there’s no win screen. The gameplay focuses on achieving high scores.
•	Lose Screen:
o	A UI panel that appears when the player loses. It includes:
	“Game Over”.
	Button: “Restart”.
________________________________________


5. Sound
o	Sound when collecting pickups.
o	Sound when the enemies damage the user.
