# 2.2 Functional Requirements

|           1            |                                  Blob Movement  Left                                  |
|:----------------------:|:-------------------------------------------------------------------------------------:|
|      Description       |                             Blobs can move left and right                             |
|  Acceptance Criterion  | When (A/Left Arrow) is pressed the according Blob moves 1.5 grids/second to the left. |
|         Notes          |                The referenced (~/~) controls correlate to (Blob/Blobb)                |

|           1            |                                  Blob Movement  Right                                   |
|:----------------------:|:---------------------------------------------------------------------------------------:|
|      Description       |                              Blobs can move left and right                              |
|  Acceptance Criterion  | When (D/Right Arrow) is pressed the according Blob moves 1.5 grids/second to the right. |
|         Notes          |                 The referenced (~/~) controls correlate to (Blob/Blobb)                 |

|          1           |                                                                                           Blob Jump                                                                                            |
|:--------------------:|:----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------:|
|     Description      |                                                                                         Blobs can jump                                                                                         |
| Acceptance Criterion | When (W/Up Arrow) is pressed the according Blob moves 1.2 grids in 1 second up and jump is disabled. If Blob is simultaneously moving horizontally, it can move up to 4 grids during the jump. |
|        Notes         |                                                                    The referenced (~/~) controls correlate to (Blob/Blobb)                                                                     |

|           1            |                                                                      Blob Interact                                                                       |
|:----------------------:|:--------------------------------------------------------------------------------------------------------------------------------------------------------:|
|      Description       |                                                       Blobs can interact with switches and buttons                                                       |
|  Acceptance Criterion  | If the distance between Blob and a switch or button is less than 0.5 grids and the player presses (A/Left Arrow) the button or switch change their state |
|         Notes          |                                                 The referenced (~/~) controls correlate to (Blob/Blobb)                                                  |

|          1a          |                                                              Blob Push                                                              |
|:--------------------:|:-----------------------------------------------------------------------------------------------------------------------------------:|
|     Description      |                                                       Blobs can push objects                                                        |
| Acceptance Criterion | When Blob collides with Object and Blob continues to move in the same direction that object and the Blob move at 0.7 regular speed. |
|        Notes         |                                                                                                                                     |

|          2           |                       Players                       |
|:--------------------:|:---------------------------------------------------:|
|     Description      |   There exist two Blobs with each having a player   |
| Acceptance Criterion | Every game has 2 players who each controls one Blob |
|        Notes         |                                                     |

|          3           |                          Game Sessions                           |
|:--------------------:|:----------------------------------------------------------------:|
|     Description      |   We manage saved versions and players can choose between them   |
| Acceptance Criterion | There are three save slots that can be selected to play the game |
|        Notes         |                                                                  |

|          3a          |                                                Game Sessions Save                                                |
|:--------------------:|:----------------------------------------------------------------------------------------------------------------:|
|     Description      |                                   Players can quit and their progress is saved                                   |
| Acceptance Criterion | When players want to quit they can save at what level they are at in their selected slot and then close the game |
|        Notes         |                                                                                                                  |

|          3b          |                                  Game Sessions Start                                   |
|:--------------------:|:--------------------------------------------------------------------------------------:|
|     Description      |                        Players can start from their saved slot                         |
| Acceptance Criterion | When players select a slot the game is loaded in that level with all relevant progress |
|        Notes         |                                                                                        |

|          4           |                                                 Start                                                 |
|:--------------------:|:-----------------------------------------------------------------------------------------------------:|
|     Description      | The game has a defined start and end point where the Blobs are seperated and then find together again |
| Acceptance Criterion |  At the defined start and end the players are presented with a cut scene and at the end a win screen  |
|        Notes         |                                                                                                       |

|          5           |                                                                 Portals                                                                  |
|:--------------------:|:----------------------------------------------------------------------------------------------------------------------------------------:|
|     Description      |                                  Portals can be used to teleport whatever they are designed to teleport                                  |
| Acceptance Criterion | When something that that portal can move touches an active input portal the object disappears and reappears at the output of that portal |
|        Notes         |                                                                                                                                          |

|          6           |                                   Settings                                   |
|:--------------------:|:----------------------------------------------------------------------------:|
|     Description      | Players can change the settings and save them by exiting the settings screen |
| Acceptance Criterion |           Selecting the back-button saves all settings if accepted           |
|        Notes         |                                                                              |

|          6a          |                                                                        Settings - Controls                                                                        |
|:--------------------:|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------:|
|     Description      |                                                                  Players can change all controls                                                                  |
| Acceptance Criterion | Selecting a control (Run Left, Run Right, Jump, Interact) and Blob(b) in the settings and changing it changes it in game, every button can only be assigned once. |
|        Notes         |                                                                                                                                                                   |

|          6b          |                                                                Settings - Audio                                                                |
|:--------------------:|:----------------------------------------------------------------------------------------------------------------------------------------------:|
|     Description      |                                                    Players can change the audio via sliders                                                    |
| Acceptance Criterion | There are three volume sliders: Main, SFX and Music that control the volume specified. They affect the volume by adjusting it from 0% to 100%. |
|        Notes         |                                                                                                                                                |

|          6c          |                                                              Settings - Resolution                                                               |
|:--------------------:|:------------------------------------------------------------------------------------------------------------------------------------------------:|
|     Description      |                                                        Players can change the resolution                                                         |
| Acceptance Criterion | Via the arrows on the settings screen the players can change the resolution to their preferred resolution and apply it using the "apply" button. |
|        Notes         |                                                                                                                                                  |

|          6d          |                                      Settings - Screentype                                       |
|:--------------------:|:------------------------------------------------------------------------------------------------:|
|     Description      |                         Players can change the way the game is displayed                         |
| Acceptance Criterion | Via arrows the player can switch display options between [Fullscreen, Window, Window Borderless] |
|        Notes         |                                                                                                  |