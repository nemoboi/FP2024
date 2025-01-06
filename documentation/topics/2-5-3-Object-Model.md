# 2.5.3 Object Model


```Mermaid
classDiagram
    class W0_Setup {
        +startNewGame()
        +quit()
    }
    class W0_1_StartingScreen {
        +startNewGame()
        +quit()
    }
    class W0_2_SavedGames {
        +savedGames: List<gameSave>
        +removeSavedGame()
    }
    class W2_Gameplay {
        +positionBlob: Vector2D<int>
        +positionBlobb: Vector2D<int>
        +objects: List<gameObject>
        +restartLevel()
        +nextLevel()
    }
    class W1_Settings {
        +volumeMusic: int
        +volumeFX: int
        +volumeTotal: int
        +resolution: Vector2D<int>
        +windowType: Type
        +colourBlob: Color
        +colourBlobb: Color
    }
    class W1_1_Standard {
        +volumeMusic: int
        +volumeFX: int
        +volumeTotal: int
        +resolution: Vector2D<int>
        +windowType: Type
        +colourBlob: Color
        +colourBlobb: Color
    }
    class W1_2_Controls {
        +controlsBlob: Array<KeyStrokes>
        +controlsBlobb: Array<KeyStrokes>
        +setControlsBlob()
        +setControlsBlobb()
    }

    %% Relationships
    W0_Setup --> W0_1_StartingScreen : "toStartingScreen()"
    W0_1_StartingScreen --> W0_2_SavedGames : "toSavedGames()"
    W0_Setup --> W2_Gameplay : "startNewGame()"
    W0_2_SavedGames --> W2_Gameplay : "resumeSavedGame()"
    W0_1_StartingScreen --> W0_Setup : "back()"

    W0_Setup --> W1_Settings : "toSettings()"
    W1_Settings --> W0_1_StartingScreen : "back()"
    W1_Settings --> W1_1_Standard : "toSettings()"
    W1_Settings --> W1_2_Controls : "toControls()"
    W1_1_Standard --> W1_Settings : "back()"
    W1_2_Controls --> W1_Settings : "back()"
```

