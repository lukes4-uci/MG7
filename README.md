# MG7
## Devlog
Write your Devlog here. :3

the TreeOfBirds script is initiated with an of GameObjects called sparrows, which contains all the sparrows in the scene. on Update (i.e. every frame), it loops through each item within the sparrows array, using Vector3.Distance to measure the distance between that sparrow instance and the player GameObject. if the resulting distance is less than inteactDistance, the sparrow instance is enabled. 

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
