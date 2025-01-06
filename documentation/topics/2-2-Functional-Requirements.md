# 2.2 Functional Requirements

## Blob Movement
|           1            |                                             Blob Movement - X-Axis                                             |
|:----------------------:|:--------------------------------------------------------------------------------------------------------------:|
|      Description       |                                         Blobs can move left and right                                          |
|  Acceptance Criterion  | When the corresponding button is pressed the according Blob moves 1.5 grids/second into the correct direction. |
|         Notes          |                            The referenced (~/~) controls correlate to (Blob/Blobb)                             |


|          1a          |                       Blob Movement          -    X-Axis - Left                       |
|:--------------------:|:-------------------------------------------------------------------------------------:|
|     Description      |                              Blobs can move to the left                               |
| Acceptance Criterion | When (A/Left Arrow) is pressed the according Blob moves 1.5 grids/second to the left. |
|        Notes         |                The referenced (~/~) controls correlate to (Blob/Blobb)                |




|          1b          |                             Blob Movement  - X-Axis - Right                             |
|:--------------------:|:---------------------------------------------------------------------------------------:|
|     Description      |                               Blobs can move to the right                               |
| Acceptance Criterion | When (D/Right Arrow) is pressed the according Blob moves 1.5 grids/second to the right. |
|        Notes         |                 The referenced (~/~) controls correlate to (Blob/Blobb)                 |

## Blob Jump

|          2           |                                                                                           Blob Jump                                                                                            |
|:--------------------:|:----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------:|
|     Description      |                                                                                         Blobs can jump                                                                                         |
| Acceptance Criterion | When (W/Up Arrow) is pressed the according Blob moves 1.2 grids in 1 second up and jump is disabled. If Blob is simultaneously moving horizontally, it can move up to 4 grids during the jump. |
|        Notes         |                                                                    The referenced (~/~) controls correlate to (Blob/Blobb)                                                                     |

## Blob Interaction

|          3           |                                                                        Blob Interact                                                                        |
|:--------------------:|:-----------------------------------------------------------------------------------------------------------------------------------------------------------:|
|     Description      |                                                        Blobs can interact with switches and buttons                                                         |
| Acceptance Criterion | If the distance between Blob and a switch or button is less than 0.5 grids and the player presses (E/Right Control) the button or switch change their state |
|        Notes         |                                                   The referenced (~/~) controls correlate to (Blob/Blobb)                                                   |

## Blob Push

|          4           |                                                              Blob Push                                                              |
|:--------------------:|:-----------------------------------------------------------------------------------------------------------------------------------:|
|     Description      |                                                       Blobs can push objects                                                        |
| Acceptance Criterion | When Blob collides with Object and Blob continues to move in the same direction that object and the Blob move at 0.7 regular speed. |
|        Notes         |                                                                                                                                     |

## Players

|          5           |                               Players                                |
|:--------------------:|:--------------------------------------------------------------------:|
|     Description      | Two Players are required to play the game, each controlling one Blob |
| Acceptance Criterion |         Every game session includes two players, with each player assigned control of one Blob.         |
|        Notes         |                  Single-player mode is not supported; cooperation is essential for gameplay.                                                    |

## Game Sessions

|          3           |                                                Game Sessions                                                |
|:--------------------:|:-----------------------------------------------------------------------------------------------------------:|
|     Description      | Game Sessions are defined as up to 3 seperate Games, that save the level of progress they are currently at. |
| Acceptance Criterion |                      There are three save slots that can be selected to play the game                       |
|        Notes         |                            Game Sessions can be written, overwritten and deleted                            |

|          3a          |                                 Game Sessions - Save  Slots                                  |
|:--------------------:|:--------------------------------------------------------------------------------------------:|
|     Description      |              Players can save and select game sessions using predefined slots.               |
| Acceptance Criterion | Players can save their progress in one of three slots and resume from a selected slot later. |
|        Notes         |                       Progress includes level completion and settings.                       |

|          3b          |                                 Game Sessions - Save Progress                                 |
|:--------------------:|:---------------------------------------------------------------------------------------------:|
|     Description      |                       Players can save their progress during the game.                        |
| Acceptance Criterion | Players can save their current level and settings in the selected slot upon exiting the game. |
|        Notes         |                         Saves can overwrite already written progress.                         |


|          3b          |                                        Game Sessions - Load Progress                                        |
|:--------------------:|:-----------------------------------------------------------------------------------------------------------:|
|     Description      |                                    Players can load saved game sessions.                                    |
| Acceptance Criterion | Upon selecting a saved slot, the game starts from the saved level with corresponding progress and settings. |
|        Notes         |                                                       |


|          4           |                                          Game Start and End                                           |
|:--------------------:|:-----------------------------------------------------------------------------------------------------:|
|     Description      | The game has a defined start and end point where the Blobs are separated and then find each other again. |
| Acceptance Criterion |  At the defined start and end, players are presented with a cutscene. At the end, a win screen is displayed.  |
|        Notes         |                           The cutscenes provide narrative context for the gameplay.                                                                            |

|          5           |                                                                 Portals                                                                  |
|:--------------------:|:----------------------------------------------------------------------------------------------------------------------------------------:|
|     Description      |                                  Portals can be used to teleport objects or entities designated for teleportation.                                 |
| Acceptance Criterion | When an eligible object touches the input portal, it disappears and reappears at the output portal.|
|        Notes         |                                                         Portals are paired and only function when active.                                                                                 |

|          6           |                                   Settings                                   |
|:--------------------:|:----------------------------------------------------------------------------:|
|     Description      | Players can change the settings and save them by exiting the settings screen |
| Acceptance Criterion |           Selecting the back-button saves all settings if accepted           |
|        Notes         |                                                                              |

|          6a          |                                                                        Settings - Controls                                                                        |
|:--------------------:|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------:|
|     Description      |                                                                  Players can customize key bindings.                                                               |
| Acceptance Criterion | Players can select actions (e.g., Run Left, Jump) and assign keys or buttons. Each key or button can only be assigned to one action at a time. |
|        Notes         |                                                                       Customization is saved upon exiting the settings menu.                                                                                             |

|          6b          |                                            Settings - Audio                                             |
|:--------------------:|:-------------------------------------------------------------------------------------------------------:|
|     Description      |                             Players can adjust audio levels using sliders.                              |
| Acceptance Criterion | Players can adjust sliders for Main, SFX, and Music volumes (0%-100%). Changes take effect immediately. |
|        Notes         |                           Default audio settings are 100% on initial launch.                            |

|          6c          |                                             Settings - Resolution                                             |
|:--------------------:|:-------------------------------------------------------------------------------------------------------------:|
|     Description      |                                    Players can change the game resolution.                                    |
| Acceptance Criterion |  Players can use arrows to switch between available resolutions and apply changes using the "Apply" button.   |
|        Notes         | Resolution changes do not require restarting the game. Default Resolution is 1920 x 1080 upon initial launch. |

|          6d          |                                      Settings - Screentype                                      |
|:--------------------:|:-----------------------------------------------------------------------------------------------:|
|     Description      |                             Players can adjust screen display mode.                             |
| Acceptance Criterion |                                                Players can toggle between [Fullscreen, Windowed, and Windowed Borderless] display modes using the arrow keys.                                                 |
|        Notes         |               Default is Fullscreen on initial launch.                                                                                  |