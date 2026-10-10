**Slime Climb** is a high-tension, physics-based 2D precision platformer. Players take control of a sentient, dark green biowaste anomaly attempting to escape from the depths of a monolithic, sci-fi industrial disposal shaft. The environment features a high-contrast pixel art aesthetic, visually transitioning from dark waste vats at the bottom to glowing neon exhaust vents near the summit.

Gravity is the primary antagonist in this Foddian-style climbing experience. Stripping away traditional platforming safety nets, traversal relies entirely on a single "charged jump" input. Miscalculated leaps result in punishing falls backward through the level, heavily testing the player's mechanical mastery and emotional resilience.

## 🎮 Gameplay Mechanics

* Players hold down an input to compress the slime, building up vertical and horizontal momentum.
* Releasing the input launches the slime, and zero directional control is permitted while mid-air.
* Players can strategically rebound off walls mid-air to reverse their momentum for advanced tactical maneuvering.
* Severe falls result in "Longfalls," which penalize the player with a distinct breaking and rebuilding animation.
* A dynamic HUD tracks elapsed time, total jumps, and Longfalls to encourage flawless speedruns.

## 🛠 Engineering & Architecture Highlights

* **Engine & Scope:** Developed in the Godot engine. The level design is structured so a flawless "golden path" run takes exactly 30 to 60 seconds.
* **State Machine:** The player character utilizes a decoupled, isolated state machine to strictly manage the transitions between Idle, Compressing, Airborne, Splat/Landing, and Rebuilding states.
* **Physics Tuning:** The default CharacterBody2D physics were explicitly overridden to eliminate floaty or elastic collisions, ensuring that jumps feel perfectly rigid and predictable.
* **Environment Logic:** Moving platforms are constructed using AnimatableBody2D objects driven by mathematical sine waves to create smooth, pendular movement.
* **Global Systems:** A persistent Autoload script manages rapid scene-reloading for quick restarts and tracks player settings across the game.
* **Audio Engineering:** The game implements a dedicated audio bus system, allowing players to mute custom music without losing frame-synced sound effects like pitch-scaled wall bounces and movement squishes.
