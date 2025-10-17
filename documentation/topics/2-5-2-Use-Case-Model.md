# 2.5.2 Use Case Model

## Use-Case Description

In this game the players can start a new or load an already existing save into the levels of the game.
In each level the goal of the players is to reach the end by solving a parkour challenge with their characters, interacting with objects and utilizing teleporters.
At any time they can open the game options and change them.
When the players choose to they can end the game and save their current state so later on they can restart from where they last left off.

## Use-Case Diagram

![Use-Case Diagram](usecasediagram.png)

## Activity Diagrams

### Player

```Mermaid
stateDiagram-v2
state fork_state <<fork>>
state if_state <<choice>>
state if_state2 <<choice>>
[*] --> fork_state
fork_state --> if_state
fork_state --> J
fork_state --> I
if_state --> MR: [right]
if_state --> ML: [left]
MR: Player moves right
ML: Player moves left
J: Player jumps
I: Player interacts with Object
MR --> if_state2
ML --> if_state2
if_state2 --> OM: [object in front of player]
OM: Object moves in same direction as Player
if_state2 --> [*]: [else]
J --> [*]
I --> [*]
```

### Teleportation

#### Overview Teleport-Modes

```Mermaid
graph TD
    Teleporter --> BAT["Button-Activated Teleporter"]
    Teleporter --> SAT["Switch-Activated Teleporter"]
    Teleporter --> AAT["Already-Activated Teleporter"]
    BAT --> OT["Object Teleporter"]
    SAT --> OT
    AAT --> OT
    SAT --> BST["Blob Switch Teleporter"]
    AAT --> BST
```

#### Activating Portals

##### Button

```Mermaid
stateDiagram-v2
[*] --> Button_pressed
Button_pressed: Player activates Portal by pressing button
Button_pressed --> Button_left
Button_left: Player deactivates Portal by stopping button-pressing
Button_left --> [*]
```

##### Switch

```Mermaid
stateDiagram-v2
[*] --> Switch_on
Switch_on: Player activates Portal by toggling switch to "ON" position
Switch_on --> Switch_off
Switch_off: Player deactivates Portal by toggling switch to "OFF" position
Switch_off --> [*]
```

#### Blob Switch Teleporter

```Mermaid
stateDiagram-v2
state if_state <<choice>>
state if_state2 <<choice>>
state fork_state <<fork>>
[*] --> fork_state
fork_state --> P1
fork_state --> P2
P1: Player 1 moves onto Input Section
P2: Player 2 moves onto Input Section 2
P1 --> P0
P1 --> Press
P2 --> P0
P2 --> Press
P0: Player leaves Input Section
Press: Player interacts with Input Section
P0 --> [*]
Press --> if_state
if_state --> [*]: [else]
if_state --> if_state2: [2 players on inputs]
if_state2 --> [*]: [portal inactive]
if_state2 --> Teleport: [portal active]
Teleport: Teleport Player 1 onto Input Section 2 and Player 2 onto Output Section
Teleport --> [*]
```

#### Object Teleporter

```Mermaid
stateDiagram-v2
state if_state <<choice>>
[*] --> OI
OI: Object is moved onto Input Section
OI --> PI
PI: Player interacts with Input Section
PI --> if_state
if_state --> TEL: [portal active]
if_state --> [*]: [portal inactive]
TEL: Object is teleported onto Output Section
TEL --> [*]
```

### Scene Transition

```Mermaid
stateDiagram-v2
state if_state <<choice>>
state fork_state <<fork>>
[*] --> fork_state
fork_state --> P1
fork_state --> P2
P1: Player 1 leaves scene
P2: Player 2 leaves scene
P1 --> P0
P1 --> if_state
P2 --> P0
P2 --> if_state
P0: Player enters scene
P0 --> [*]
if_state --> [*]: [else]
if_state --> NEXT: [2 players left scene]
NEXT: Next scene is loaded
NEXT --> [*]
```