# Wordle – Console Edition (C#)

A console-based implementation of the popular word-guessing game [Wordle](https://www.nytimes.com/games/wordle/index.html), built in C#. Guess the hidden 5-letter word before you run out of attempts — with positional feedback on every guess.

---

## Overview

This project recreates the core Wordle experience as a console application. A random 5-letter word is selected from a word list, and the player has a limited number of guesses based on their chosen difficulty. After each guess, the game provides per-letter feedback to help narrow down the answer.

---

## Features

- Three difficulty levels with varying guess limits
- Random word selection from a curated word list
- Per-letter positional feedback on every guess
- Case-insensitive input
- Play again prompt with the option to switch difficulty between rounds

---

## Gameplay

After selecting a difficulty, enter a 5-letter word each round. The game responds with feedback for each letter position:

| Symbol | Meaning |
|---|---|
| Letter | Correct letter, correct position |
| `*` | Letter is in the word, wrong position |
| `- ` | Letter is not in the word |

**Example** — target word is `HOARD`:

```
Enter guess 1: CLEAR
- - - * *

Enter guess 2: ADORE
* * * R -

Enter guess 3: ROADS
* O A * -

Enter guess 4: HOARD
HOARD  →  You win!
```

---

## Difficulty Levels

| Level | Guesses |
|---|---|
| Beginner | 6 |
| Proficient | 4 |
| Expert | 3 |

---

## File Structure

```
Wordle/
├── Words.cs        # Loads word list, stores words, returns a random word
├── Wordle.cs       # Main application; handles game loop and user interaction
├── words.txt       # Source word list — unique, uppercase 5-letter words
└── README.md
```

---

## How to Compile & Run

**Compile:**
```bash
csc *.cs
```

**Run:**
```bash
.\Wordle
```

> Requires the [.NET SDK](https://dotnet.microsoft.com/en-us/download) or `csc` available via Mono / Visual Studio.

---

## Architecture

**`Words`** — Model  
Reads `words.txt`, stores all 5-letter words in an array or `ArrayList`, and exposes a method to return a randomly selected word.

**`Wordle`** — Controller  
Drives the game loop: prompts for difficulty, manages guess attempts, evaluates each guess against the target word, and displays results.

---

## Notes

- All input is converted to uppercase internally — the game is case-insensitive.
- The word list (`words.txt`) contains only unique, uppercase 5-letter words.
- Letters can appear more than once in the target word.