# Agile development plan
## Sprint 1: Creating project and setting up scenes
- Goal: Project is created and has basic (scene) infrastrusture
- Task 1: Create project
- Task 2: Create Scenes for Bone, Background, Floor, Game, Barrel and Player
- DoD: The project and scenes are succesfully created

## Sprint 2: Setting the endless runner player
- Goal: Player model is set and has animations for running and jumping
- Task 1: Create animated sprite node
- Task 2: Set animation for running and jumping
- DoD: Player has set animations

## Sprint 3: Endless scrolling floor and shaders
- Goal: Floor is set to endless scrolling and shader is set to achieve this
- Task 1: Create Texture for Foreground and background
- Task 2: Create shader for texture
- Task 3: Adjust fg and bg scroll speed
- DoD: The backgroung and foreground are displayed correctly

## Sprint 4: Creating item pickups and obstacles
- Goal: Creating item pickups and obstacles by using Area2D and Collisions
- Task 1: Create Area and collision for bone
- Task 2: Create Area and collision for barrel
- DoD: Bone and Barrel has created Collision blocks

## Sprint 5: Expanding the player scene to a working prototype
- Goal: Implement scripts to actually build working scene
- Task 1: Implement player script
- Task 2: Implement bone script
- Task 3: Implement barrel script
- DoD: A game scene can be run with player running and jumping animations

## Sprint 6: Generic Spawner for endless runner
- Goal: Implement generic spawner for spawning bones and barrels
- Task 1: Create scene for Spawner
- Task 2: Implement Spawner script and logic
- Task 3: Get spawned items moving
- DoD: The game is running with moving items

## Sprint 7: Player detection
- Goal: Implement logic for detecting collisions
- Task 1: Adjust scripts for bone detection
- Task 2: Adjust scripts for barrel detection
- DoD: The game is aware when player touch obstacles

## Sprint 8: Implementing events based on collisions
- Goal: Implement game over and reward event based on collisions
- Task 1: Implement reward functionality
- Task 2: Implement gave over
- DoD: The score is increased by 1 whenever player touches bone and game is over when a player touches barrel

## Sprint 9: Creating game UI
- Goal: Create main menu, game over menu and score label in game scene
- Task 1: Add score label
- Task 2: Add game over menu
- Task 3: Add main menu
- DoD: The game starts in main menu and ends in game over menu. The game also has score label

## Sprint 10: Adding sound
- Goal: Add sound effects and background music
- Task 1: Add background music
- Task 2: Add sound effects
- DoD: The game now has sound 
