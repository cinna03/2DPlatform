2D Platformer – Unity Project

This project is a basic 2D side-scrolling platformer developed in Unity.
The focus of the project is on structured C# scripting for player control, enemy behavior, game state management, and scene flow.

Project Summary

Built using Unity 2D

Written in C#

Physics handled with Unity Physics2D

Organized into modular scripts

Two main scenes: Menu and Gameplay

The gameplay is intentionally simple and centers around movement, survival, and enemy interaction.

Core Systems (Script-Focused)
Player System

PlayerMovement.cs

Handles horizontal movement input

Applies jump force using Rigidbody2D

Detects ground using raycast or collision checks

Restricts air-jumping

Flips sprite based on movement direction

PlayerDamage.cs

Tracks remaining lives (default: 3)

Detects collisions with enemies and hazards

Triggers respawn logic

Applies temporary invulnerability after respawn

Notifies GameManager on player death

Enemy System

Each enemy type has its own behavior script.

Snail Script

Ground-based movement

Patrol logic between two points

Reverses direction on collision or edge detection

Bird Script

Moves horizontally in air

Optional vertical variation

Damages player on contact

Spider Script

Moves along a fixed path or vertical axis

Uses transform-based movement

Simple collision damage

Frog Script

Periodic jump behavior

Uses Rigidbody2D for jump force

Ground check before next jump

Common enemy behavior:

Collision-based damage to player

Basic AI without state machines

No health system (destroyed only if implemented externally)

Game Management

GameManager.cs

Controls overall game flow

Manages countdown timer (default: 60 seconds)

Detects game over condition

Reloads scene when time reaches zero

Handles scene transitions

ScoreManager.cs (if used)

Tracks collectible count

Updates UI text element

Resets score on restart

Camera System

CameraFollow.cs

Tracks player position

Smooth follow using interpolation

Maintains fixed offset

Limits movement if boundaries are defined

Menu and UI Control

MainMenuController.cs

Loads gameplay scene

Handles application quit

Connects UI buttons to scene management

GameMenuController.cs

Restarts current level

Returns to main menu

Listens for ESC key input

Gameplay Mechanics
Movement

A/D or Arrow keys for horizontal input

Spacebar for jump

Rigidbody2D for physics interaction

Life System

Player starts with 3 lives

Life lost on enemy or hazard collision

Respawn at last recorded safe position

Game Over when lives reach zero

Timer

Countdown begins at level start

Displayed in seconds

Scene reload on expiration

Respawn Logic

Safe ground position tracked continuously

Player repositioned after death

Short invulnerability window after respawn

Folder Structure
Assets/
├── Animations/
├── Prefabs/
├── Scenes/
│   ├── Menu.unity
│   └── GameScene-ALU.unity
├── Scripts/
│   ├── Player/
│   ├── Enemies/
│   ├── Managers/
│   ├── UI/
│   └── Camera/
├── Sprites/
└── Sounds/

Running the Project
Requirements

Unity Hub

Unity 2020.3 or newer

Setup

Open Unity Hub

Add the project folder

Open the project

Navigate to Assets/Scenes

Open Menu.unity

Press Play

Build

File → Build Settings

Add:

Menu.unity

GameScene-ALU.unity

Select target platform

Click Build

Design Approach

Script responsibilities are separated by system

Each gameplay mechanic is modular

Core logic handled in manager classes

Enemy behaviors are independent

Scene transitions controlled centrally
