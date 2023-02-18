# GardenGame
---
- Classes
    - Player
    - Garden
    - Plant
- Interface
    - 1 for methods shared

## Player class

### Player Attributes
- name
- health = default 100
- list of gardens
- list of plants

### Player methods
- print player
- plant
- water
- harvest
- increase garden size
- health change


## Garden class

### Garden Attributes
- name
- type
- size = default start 10 plant plot spots
- list of plants

### Garden methods
- 

## Plant class

### Plant Attributes
- plant name
- plot spots used = default 1
- needswater = default false
- health = default 50

### Plant child classes
- Edible
- Decorative
- Ground Cover

#### Edible Class Attributes
- harvestable = default false 

#### Decorative Class Attributes
- plot spots used = 4

#### Ground Cover Attributes
- plot spots used = 2

### Plant Methods
- grow
- die
- flower

