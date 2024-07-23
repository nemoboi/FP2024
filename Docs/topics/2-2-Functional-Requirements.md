# 2.2 Functional Requirements

|           1            |                                    Blob Movement                                    |
|:----------------------:|:-----------------------------------------------------------------------------------:|
|      Description       |                         Blobs can move left, right and jump                         |
|  Acceptance Criterion  |  When defined buttons are pressed the according Blob executes the defined behavior  |
|         Notes          |                                                                                     |

|          1a          |                                             Blob Push                                              |
|:--------------------:|:--------------------------------------------------------------------------------------------------:|
|     Description      |                                       Blobs can push objects                                       |
| Acceptance Criterion | When Blob collides with Object that object moves with the same speed in the same direction as Blob |
|        Notes         |                                                                                                    |

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