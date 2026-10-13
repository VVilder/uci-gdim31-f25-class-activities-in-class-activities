# in-class-activities
## Devlogs
### W1
When I moved the camera out from the cat in the hierarchy, the camera was no longer parented to the cat and refused to follow it. Parents and children are what keep the transform changes like position and rotation tethered together, so taking it out would "break the link" between the two.

[Itch page](https://rwilderm.itch.io/epic-cat-game-3-walk-stranding)

### W2
1. r, g, and b are floats because color values use decimals since the highest value is 1.0. An int can’t hold 0.5, and a bool or string doesnt work with that number either.
2. _bounce is an int because you can only bounce a whole number of times. Since you can’t bounce 2.5 times (or any decimal amount really), a float isn’t needed.
3. The error after Step 4 said “; expected”, which means that its missing a semicolon at the end.

### W3
Table #: Right by the west door? I forgot the number im sorry :(

**Activity 1**
1. The GetResponse takes an int for friendship level and a bool for knowing the secret and returns a string for the response.
2. The SetLightDimness takes a float for sanity level and returns void because of the change in light.
3. DidPlayerHitBeat takes a float for when the key was pressed and returns a bool depending on if they hit the beat.

**Activity 2**
I think our table compared it to a taco bell. The class is the taco bell, the components are the taco shells/wraps, and the member variables are the ingredients. For the methods, it's what the restaurant does like cooking and putting the tacos together.

**Activity 3**
Every fast bounce multiplies the ball's color by 1.5, so it keeps stacking until the color is way brighter than normal.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 