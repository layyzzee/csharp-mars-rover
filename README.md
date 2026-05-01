# Project: Red Horizon (Mars Rover) 🚀
**An interactive C# exploration simulator.**

## Mission Briefing 👨‍🚀
Congratulations, Commander! You have successfully touched down on the dusty plains of Mars. Your solo mission has officially begun.

While the scenery is breathtaking, your task is critical: **The Space Pirates have landed.** Somewhere on this desolate plateau, they are hiding. You must take command of your Rover, navigate the treacherous grid-based terrain, and track them down before they disappear.

This project was built to master the fundamentals of **C#** and **Visual Studio 2022**, focusing on logic, string parsing, and coordinate-based movement.

## Pilot Controls 🕹️
The Martian surface is a localized grid. Your starting coordinates and the size of the plateau are defined within `Program.cs`. 

To move, you must transmit a **Command String** to the Rover's onboard computer. 


| Command | Action |
| :---: | :--- |
| **L** | **Rotate Left:** Turns the rover 90° CCW without changing position. |
| **R** | **Rotate Right:** Turns the rover 90° CW without changing position. |
| **M** | **Move:** Advances the rover one grid unit in its current heading. |

> [!TIP]
> The Rover’s computer is forgiving! Inputs are **case-insensitive**, and any rogue characters (like spaces or punctuation) will be automatically filtered out. Example: `LMRMMLM`

## Tech Stack 🛠️
This mission was engineered using the following tools and frameworks:

*   **Language:** C# 10+
*   **Framework:** .NET 6.0 / 8.0 (Console Application)
*   **Environment:** Visual Studio 2022 or VS Code
*   **Paradigm:** Object-Oriented Programming (OOP)


## Technical Highlights 💻
To solve the challenges of Martian navigation, this project implements:

*   **State Management:** Tracking the Rover's heading (N, E, S, W) and updating coordinates based on directional logic.
*   **Input Sanitization:** A robust parsing system that filters out rogue characters and handles case-insensitive strings.
*   **Grid Constraint Logic:** (Optional: add if you have this) Preventing the Rover from moving outside the defined plateau boundaries.
