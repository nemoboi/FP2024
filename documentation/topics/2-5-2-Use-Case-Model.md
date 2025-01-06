# 2.5.2 Use Case Model

# Class Diagrams


## Blobb Switching on Teleports
```Mermaid
stateDiagram-v2
[*] --> P1
P1: Player on "Input Selection 1"
P2: Player on "Input Selection 2"
PN2: Player not on "Input Selection 2"
P21P12: Player 2 on "Teleport Output Section 1" and Player 1 on "Teleport Section 2"
P1 --> P2
P1 --> PN2
P2 --> P21P12
P21P12 --> [*]
PN2 --> [*]
```

## Blob Switch Function

### Button

```Mermaid
graph LR
PI[Portal Inactive]
PA[Portal Active]
OP[Object is located on Portal Input]
OPU[Object Position is updated to portal output]
PI -- Blob sits on Button --> PA
PA -- Blob leaves Button --> PI
PA -- Blobb moves Object --> OP
OP -- Blobb activates portal with key input--> OPU
```

### Switch Object

```Mermaid
graph LR
SL[Switch left/Portal inactive]
SR[Switch right/Portal active]
OP[Object is located on Portal Input]
OPU[Object Position is updated to Portal Output]
SL <-- Blob/Blobb executes Switch --> SR
SR -- Blobb moves Object --> OP
OP -- Blobb executes Portal --> OPU
```

### Switch Blobb

```Mermaid
graph LR
SO[Switch Off/Portal Inactive]
SON[Switch On/Portal Active]
BB[Blob and Blobb are located on Portal Input]
BPBP[Blob Position is updated to Portal Input Blobb and Blobb Position is updated to Portal Output]
SO <-- Blob/Blobb executes Switch --> SON
SON -- Blob and Blobb move to portal location --> BB
BB -- Blob/Blobb executes portal --> BPBP
```

## Teleportation Modes

```Mermaid
stateDiagram-v2
T: Teleporter
BAT: Button-Activated Teleporter
SAT: Switch-Activated Teleporter
AAT: Already-Activated Teleporter
BP: Button Pressed
OT: Object Teleporter
BST: Blobb Switch Teleporter
T1: Move Object from "Teleporter Section 1" to "Teleporter Section 2"
T2: Move Blob from "Input Teleporter Section 1" to "Teleporter Section 2". Move Blobb from "Teleporter Section 2" to "Output Teleporter Section 1"
[*] --> T
T --> BAT
T --> SAT
T --> AAT
BP -->OT
BAT --> BP
BP --> [*]
OT --> T1
T1 --> [*]
SAT --> [*]
SAT --> BST
SAT --> OT

    BST --> T2
    T2 --> [*]
    AAT --> OT
    AAT --> BST
```