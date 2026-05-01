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

## System Requirements 🛠️
Before you can launch, ensure your local station is equipped with:
*   **Visual Studio 2022** (Recommended) or **VS Code**
*   **.NET SDK** (v6.0 or later)

## Development Goals 📚
*   **Logic Consolidation:** Mastering conditional statements and loops.
*   **Input Sanitization:** Learning how to handle and filter user-provided strings.
*   **Object-Oriented Design:** Modeling the rover and plateau as distinct entities.
