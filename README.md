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

### W4
Table #: 8

1. We put Rigidbodies on the cat and the ball since they're the ones that move and need physics so the cat can kick the ball. The goal didn't need one since it doesn't move, but we checked Is Trigger on it so the ball goes through it but still counts as a goal. Also froze the cat's X and Z rotation so it wouldn't fall over.

2. The Debug message was going off when the ball hit the forcefield too, not just the goal. Fixed it with an if statement that checks for the "Goal" tag.

### W5
1. Needs a Transform for the target the deer walks to so you can pick it in the inspector, plus a NavMeshAgent variable.
2. Just Start() since the deer only needs to be told where to go once at the beginning. Didn’t need Update().
3. Start() grabs the NavMeshAgent with GetComponent and then does SetDestination to the target’s position so the deer walks over there.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 