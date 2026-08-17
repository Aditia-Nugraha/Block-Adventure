# Block Adventure

**Block Adventure** is a 2D mobile block puzzle game developed with Unity. The game challenges players to place different block shapes onto a grid, complete rows, columns, and squares, and achieve the highest possible score before no valid moves remain.

This project was developed as a learning project based on the **Block Adventure | Puzzle Block Mobile Game Unity Tutorial** series by **CodePlanStudio**, with additional modifications, improvements, and features implemented independently.

## 🎮 Game Features

* Drag and drop block shapes onto the game grid.
* Randomly generated block shapes.
* Clear completed rows, columns, and 3×3 squares.
* Score and Best Score system.
* Dynamic block colors based on the player's score.
* Bonus scoring system.
* Game Over detection.
* Try Again and Exit options.
* Background music.
* Sound effects for gameplay events.
* Music ON/OFF setting.
* SFX ON/OFF setting.
* Persistent Best Score data.

## 🕹️ Gameplay

The objective of Block Adventure is to place the available block shapes onto the grid strategically.

Players can drag a shape from the available shapes area and place it onto the grid. A shape can only be placed if all of its blocks fit into valid and unoccupied grid cells.

Completed lines and 3×3 squares are cleared and reward the player with points. The game continues until none of the available shapes can be placed on the grid.

The player can then choose to start a new game using **Try Again** or return to the **Main Menu**.

## 🏆 Scoring System

The game includes a score and Best Score system.

* Players receive points when completing lines or squares.
* Additional bonus points can be awarded under certain conditions.
* The Best Score is saved locally and can be retained between game sessions.
* Block colors change progressively as the player's score increases.

## 🔊 Audio System

Block Adventure includes a basic audio system consisting of:

### Background Music

* BGM starts from the Main Menu.
* The same BGM continues when entering the game.
* BGM stops when Game Over occurs.
* BGM resumes when starting another game or returning to the Main Menu.

### Sound Effects

SFX are played for several gameplay events, including:

* Block placement.
* Score/line clearing.
* Bonus events.
* Game Over.

Players can independently enable or disable Music and SFX from the Main Menu.

## 🛠️ Built With

* **Unity** — Game Engine
* **C#** — Programming Language
* **Unity UI** — User Interface
* **Unity Event System** — Drag and Drop Interaction
* **PlayerPrefs / Local Data** — Settings persistence
* **Binary Data Storage** — Best Score persistence

## 📱 Platform

Currently developed and tested for:

* **Android**

The game was tested on an Android device, including **Samsung Galaxy A13**.

## 📂 Project Structure

The project contains the main systems required to operate the game, including:

```text
Assets/
├── Animations/
│   ├── SettingsAnimation/
├── Graphics/
│   ├── Bonuses/
│   ├── MainMenu/
│   ├── RequestNewShapesButton/
│   ├── ScoreBar/
│   ├── SoundButton/
│   ├── Squares/
│   ├── WinLosePopup/
│   ├── Writings/
├── Prefabs/
├── Resources/
│   ├── Shapes/
├── Scenes/
├── Scripts/
│   ├── Editor/
│   ├── Game/
│   ├── ScriptableObject/
│        ├── Bonus/
│        ├── Grid/
│   ├── Shape/
│   ├── Utility/
├── Settings/
└── Sounds/
```

The project is organized into separate components for gameplay, shapes, grid management, scoring, audio, menus, and game state management.

## 📦 Download

The latest playable Android version is available through the project's GitHub Releases.

**[Download the Latest Release](../../releases/latest)**

Download the `.apk` file from the latest release and install it on an Android device.

> Android may require permission to install applications from unknown sources when installing the APK manually.

## 📸 Screenshots

![image](https://github.com/Aditia-Nugraha/Block-Adventure/blob/f53431490caba8d5b87ee3e9bf6c16e3bf547f96/WhatsApp%20Image%202026-08-17%20at%2019.59.56.jpeg)
![image](https://github.com/Aditia-Nugraha/Block-Adventure/blob/f53431490caba8d5b87ee3e9bf6c16e3bf547f96/WhatsApp%20Image%202026-08-17%20at%2019.59.56(1).jpeg)

## 🎓 Project Purpose

This project was created as a learning exercise to understand the development of a 2D mobile puzzle game using Unity and C#.

The project began by following the CodePlanStudio tutorial series and was subsequently modified and extended with additional functionality, debugging, UI adjustments, audio features, settings, and gameplay improvements.

## 🙏 Credits & Acknowledgements

Special thanks to **CodePlanStudio** for the original tutorial series that served as the primary learning reference for this project.

### Original Tutorial

**Block Adventure | Puzzle Block Mobile Game Unity Tutorial**

Created by **CodePlanStudio**.

YouTube:
https://www.youtube.com/@CodePlanStudio

The tutorial series provided the foundation for learning and implementing the core mechanics of the block puzzle game, including grid management, shape generation, shape placement, line checking, scoring, and game-over logic.

All additional modifications and features in this repository were implemented as part of my own learning and development process.

## 📄 Disclaimer

This repository is a learning project based on the CodePlanStudio tutorial series. The project should not be considered an original recreation of the commercial Block Adventure game published by CodePlanStudio.

Please refer to the original creator's resources and licensing terms for any assets or materials originating from the tutorial.

---

**Developed as a Unity learning project.**
