# 2D-platformer

After some discussion, we have the basic mechanics down. 

**Movement / Camera**

- Camera only moves left to right, with right lead.
- Character can face and move in any direction
- _Jump Mechanics_
  - Jetpack will initially function as a static jump, with a single burst
  - Future iterations will add limited fuel with recharge over time as well as ability to continuously use the jetpack. 

**Game Rules**
- Long timer (999 seconds maybe?) to complete level
- Fixed enemy locations on each level
- Checkpoint only at start of level
  - More in the future (perhaps before boss?)
- Unlimited retries
- 1 hit life
  - Off stage instant death
  - Additional "shield" item that adds another hit per level. Does not stack, but persists between levels
- Unlimited tries
- Scoring based on number of attempts per level