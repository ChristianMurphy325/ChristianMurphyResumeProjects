[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/GRpQg6I9)
# IT 2030 - Lab 09 - Building the PIG Game App

## Student Information

**Name:** Christian Murphy


* When the app starts, or when the user clicks New Game, the scores for both players, the value for the die, and the total for the turn should all be zero, and the Roll and Hold buttons should be enabled.
* When it’s their turn, a player can click Roll to roll the die or Hold to end their turn and add the point total for that turn to their score.
* When a player clicks Roll, the app should generate and display a random number between 1 and 6 (see below). If the number is 1, the point total for the turn should be set to zero, and that player’s turn should end. Otherwise, the number rolled should be added to the point total for the turn, and the player’s turn should continue.
* When a player clicks Hold, the app should add their points for that turn to their score and then end the turn. If the score is greater than the number of points needed to win, the app should end the game, disable the Roll and Hold buttons, and display the name of the winner.
* Clicking the browser’s Refresh button should only redisplay the page, not post the previous button click again.
* Use the Random class in the System namespace to generate a random number like this:

```
Random rand = new Random();
int roll = rand.Next(1, 7);
```

* Use session state to store game data between requests.
