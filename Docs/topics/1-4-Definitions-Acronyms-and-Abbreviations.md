# 1.4 Definitions, Acronyms and Abbreviations

## Blob(b)

Our main characters in-game. They can only run, jump and push things.

## Object

Any moveable item in game (i.e. a box)

## Portal

Portals to move objects/blobs/... from one portal to another
Portals are always one-way
To get something through the portal the players have to hit (E || Right Shift)

### Modes

<tabs>
<tab title="Object Portal">
Teleport Object from input to output
</tab>
<tab title="Blob Portal">
There are three parts to this portal
<list type="decimal">
<li>
Section 1: 
Input Blob A
</li>
<li>
Section 2: 
Input Blob B &&
Output Blob A
</li>
<li>
Section 1: 
Output Blob B
</li>
</list>
</tab>
</tabs>

### Ways to activate

<tabs>
<tab title="Always Active">
Portal is always active
</tab>
<tab title="Switch Activated">
Portal is activated via a switch
</tab>
<tab title="Button Activated (Only Object Portals)">
Blob has to stand on button so the portal stays active
</tab>
</tabs>

## Entrance / Exit

The way to move between scenes

## Movement and distances

The following is normed to a grid under the assumption that 1 grid is the size of the 
movable object in the first tutorial level (see storyboarding/tutorials.pdf). 

<tabs>
<tab title="Regular Movement">
Blob moves 1.5 grids/second.
</tab>
<tab title="Jump">
When jumping, Blob moves 1.2 grids up. If Blob is simultaneously moving horizontally, 
it can move up to 4 grids during the jump.
</tab>
<tab title="Object">
A movable object can be pushed at .7 regular speed
</tab>
</tabs>

## Player

The two people controlling the Blobs

## Start

The beginning of the game where the Blobs are seperated during a cut scene

## End

The end of the game where the Blobs find together again (cut scene)

## Settings

### Audio

Sliders go from 0% to 100%

<tabs>
<tab title="Main">
Change all volume relative to their selective sliders
</tab>
<tab title="SFX">
Volume of effects
</tab>
<tab title="Music">
Volume of music
</tab>
</tabs>

### Colour

Both Blobs are displayed and can be individually switched through different colours.

### Controls

Each Blob can be moved using the keyboard, the following are the commands:

|  Action   | Blob |    Blobb    |
|:---------:|:----:|:-----------:|
| Run Left  |  A   | Left Arrow  |
| Run Right |  D   | Right Arrow |
|   Jump    |  W   |  Up Arrow   |
| Interact  |  E   | Right Shift |

The pushing of objects is done automatically when moving against an object.

The command keys can be changed in settings, in a separate sub-screen.