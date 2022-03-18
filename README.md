# 457-Final-Project-3

## Setup

1) Clone the repo (`git clone git@github.com:khammerm/457-Final-Project-3.git`)
2) Use Unity Hub to open the folder as a unity project (use version `2020.3.26f1`)
3) There will be a popup asking something about using a new input system. Click `No`
4) Setup your input buttons via the following from within the unity project:
    1) Navigate to `Edit` -> `Project Settings` -> `Input Manager` -> `Axes`
    2) Click on `Fire1`
        - Change `Name` to `Fire 1`
        - Verify that `Positive Button` is set to `mouse 1`
    3) Click on `Jump`
        - Verify that `Positive Button` is set to `space`
    4) Right click on `Jump` and click `Duplicate Array Element`. Click on the new `Jump` entry
        - Change `Name` to `Crouch`
        - Change `Positive Button` to `left ctrl`
    5) Right click on `Jump` (or `Crouch`, doesn't matter) and click `Duplicate Array Element`. Click on the new entry
        - Change `Name` to `Sprint`
        - Change `Positive Button` to `left shift`
    6) Click on the `x` on the upper right to exit `Project Settings`
5) Verify that you are able to play the game. Use `W`, `A`, `S`, and `D` keys to move around, in addition to the keybinds you've set up above

## Acknowledgements

- Movement Controls: [UnitySourceMovement](https://github.com/Olezen/UnitySourceMovement)
- Health Bar Images: [Health-Bar](https://github.com/Brackeys/Health-Bar)
- Various Development Assets [DevAssets](https://devassets.com)
