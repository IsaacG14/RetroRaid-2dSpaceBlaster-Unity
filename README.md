Slime Climb is a high-tension, physics-based 2D precision platformer. Take control of a sentient, dark green biowaste anomaly attempting to escape from the depths of a monolithic, sci-fi industrial disposal shaft.

Gravity is the primary antagonist in this Foddian-style climbing experience. Visually transitioning from dark waste vats at the bottom to glowing neon exhaust vents near the summit, traditional platforming safety nets are stripped away. Traversal relies entirely on a single "charged jump" input. Miscalculated leaps result in punishing falls backward through the level, heavily testing both your mechanical mastery and emotional resilience.

🎮 Gameplay Mechanics
Physics-Driven Momentum: Hold down input to compress the slime, building up vertical and horizontal kinetic energy.

Zero-G Commitment: Releasing the input launches the slime. Zero directional control is permitted mid-air—commit to your trajectory.

Tactical Wall Rebounds: Strategically bounce off walls mid-air to reverse momentum for advanced maneuvering.

The "Longfall" Penalty: Severe falls trigger a distinct breaking and rebuilding animation, taxing both your time and your patience.

Speedrun Ready: A dynamic HUD permanently tracks elapsed time, total jumps, and Longfalls to encourage and record flawless runs.

🛠 Under the Hood: Architecture & Engineering
Developed in Godot, Slime Climb is built with a focus on strict physics manipulation and decoupled code architecture to ensure a tightly controlled player experience.

Decoupled State Machine: The player character utilizes an isolated state machine to strictly manage the transitions between Idle, Compressing, Airborne, Splat/Landing, and Rebuilding states.

Custom Physics Tuning: The default CharacterBody2D physics were explicitly overridden to eliminate floaty or elastic collisions, ensuring jumps feel perfectly rigid, predictable, and fair.

Kinematic Environment Logic: Moving platforms are constructed using AnimatableBody2D objects driven by mathematical sine waves to create perfectly smooth, pendular movement.

Global Systems Management: A persistent Autoload script manages rapid scene-reloading for instant quick-restarts and cross-session state tracking.

Advanced Audio Bus: A dedicated audio bus system allows players to mute custom music without losing frame-synced sound effects, like pitch-scaled wall bounces and movement squishes.

Engineered for the "Golden Path": The level architecture is explicitly structured so a flawless run takes exactly 30 to 60 seconds of uninterrupted flow.
