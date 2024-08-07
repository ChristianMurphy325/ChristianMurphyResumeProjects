[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/GRpQg6I9)
# IT 2030 - Lab 09 - Building the PIG Game App

## Student Information

**Name:** Christian Murphy

**Email:** s01281650@acad.tri-c.edu

Place your name and email address above. Students who do not enter their name and email address above will receive NO CREDIT for the lab.

## Introduction

For this project, you will build a one-page web app that uses session state to persist data between requests.

![image](https://github.com/tric2030/it2030_v1_lab09/assets/24532026/e8eee38c-0830-43a1-bdf7-9f37a2131b26)

## Instructions

To receive credit for this lab, you must:

* Accept the GitHub Classroom assignment for this lab
* Write code that meets the specifications (below)
* Commit all code by the due date to your GitHub Classroom repository by the due date

## Specifications

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

## Rubric

* See the assignment in Blackboard for the grading rubric

## References

This lab sourced from Murach’s ASP.NET Core MVC (2nd Edition), 2022, by Mary Delamater and Joel Murach
