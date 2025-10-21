# Numeric-Leapfrog
A skill check program for C# Fundamentals.
A simple Console-based C# game that tests your guessing skills.
The player tries to get within 3 of a randomly generated number without going over.

## Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Logic Breakdown / Tasks](#logic-breakdown--tasks)
- [Code Structure](#code-structure)
- [Technologies](#technologies)

## Overview
This project demonstrates fundamental C# concepts including:
- Loops and conditionals
- Random number generation
- User input handling
- Methods, static classes, and tuple returns
- Basic console application design

## Features
- Generates a random target number between 1-50.
- Accepts and validates user input.
- Tracks player total and number of guesses.
- Win/loss logic and output.
- Replayable game loop.

## Logic Breakdown / Tasks 
- [x] Determine and store the **target number**.
- [x] Sum user guesses until a win/loss condition is met.
- [x] Loop guessing logic until win/loss condition is met.

## Code Structure
- `Program.cs` - Entry point and replay loop.
- `Helper.cs` - Static class containing:
    - `GetRandomNumber()` - generates a random target number.
	- `PlayGame()` - runs a single game session.
	- `GetPlayerGuesses()` - handles user input and running total.
	- `DisplayResults()` - prints win/loss messages.