# TriPeaks Card Game

This repository contains the implementation of a **TriPeaks Card Game** developed as a university project for the course "Data Structures and Algorithm Design." The project demonstrates the application of advanced data structures and algorithms using C#.

---

## 📋 Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Project Structure](#project-structure)
- [Installation](#installation)
- [Usage](#usage)
- [Game Mechanics](#game-mechanics)
- [Contributors](#contributors)

---

## 🎮 Introduction

The **TriPeaks Card Game** is a solitaire card game implemented with:

- A pyramid of 28 cards divided into three peaks.
- Cards that can be removed only if they are one rank higher or lower than the top card of the waste pile.
- The goal to clear all cards from the board.

This project emphasizes the use of **graph data structures** to manage the relationships between cards and their interactions during gameplay.

---

## ✨ Features

- 🌐 **Graph-based Card Relationship Management:**
  - Nodes represent cards.
  - Directed edges define valid moves.
- 🎨 **Custom Controls for Gameplay:**
  - Interactive card piles.
  - Rounded panels for enhanced visuals.
- ⚡ **Efficient Algorithms:**
  - Graph traversal for card interactions.
  - Optimized shuffling and scoring.
- ⏪ **Undo and Hint Mechanisms:**
  - Undo last move using a stack.
  - Hints suggest possible moves.
- 🏆 **Persistent Scoring System:**
  - High scores stored and sorted.

---

## 🛠️ Technologies Used

- **Programming Language:** C#
- **Development Environment:** Microsoft Visual Studio
- **Data Structures:**
  - Arrays, Lists, Graphs, Stacks
- **Custom Graphics Extensions:** For rounded UI elements.

---

## 🗂️ Project Structure

- **Core Logic:**
  - `Graph.cs`: Manages card relationships.
  - `Shuffler.cs`: Handles card creation and shuffling.
- **UI Components:**
  - `PlayingCard`: Represents a single card.
  - `CardsPile`: Manages piles of cards.
- **Utilities:**
  - `GraphicsExtension.cs`: Custom drawing methods.
  - `HintMechanism.cs`: Suggests possible moves.
- **Game Scenes:**
  - Main menu
  - Game board
  - High scores

---

## ⚙️ Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/your_username/tripeaks-card-game.git
   ```
2. Open the solution file in **Microsoft Visual Studio**.
3. Build and run the project.

---

## 🚀 Usage

1. Launch the game.
2. Select `New Game` to start.
3. Use the following controls:
   - Click on a card to move it to the waste pile if valid.
   - Use the `Hint` button for suggestions.
   - Undo moves with the `Undo` button.
4. Aim to clear the board and set a new high score!

---

## 🃏 Game Mechanics

### Card Relationships

- Cards are represented as nodes in a graph.
- Directed edges connect cards that can be moved based on game rules.
- Graph relationships update dynamically as cards are removed.

### Winning and Losing Conditions

- **Win:** Clear all cards from the board.
- **Lose:** No valid moves left, and the stock pile is empty.

### Advanced Features

- **Undo:** Tracks the last moves using a stack.
- **Hint:** Highlights possible moves.
- **Persistent Scoring:** High scores stored locally using `StringCollection`.

---

## 👥 Contributors

- **Jafar Mirzaei**
- **Mohammad Arabi**
