# UPKK Jawi Adventure

A Unity educational adventure prototype with Jawi-script multiple-choice questions and local player profiles. It combines a bundled Watermelon game framework with custom learning, text presentation, and score-handling scripts.

## Learning systems

- A question bank organized around Akidah, Ibadah, Sirah, and Adab, with multiple labelled stages. Curriculum coverage and answer accuracy require educator review.
- Jawi text presentation using ArabicSupport's ArabicFixer with TextMesh Pro.
- Three answer buttons for levels up to 12 and four for later levels, as selected in the quiz controller.
- Five-attempt quiz sessions with audio, tick/cross, and answer-colour feedback. Correct responses add ten to the current player's star score; both correct and incorrect responses advance the session.
- Local player names, identifiers, selection, and star totals stored through PlayerPrefs.
- A configured score-reporting request to an existing Hanana service; server availability and behaviour are unverified.

These features are described from tracked scripts. Their scene bindings and runtime behaviour have not been tested in this review.

## Open the project

1. Install **Unity 6000.0.62f1**, recorded in [ProjectVersion.txt](ProjectSettings/ProjectVersion.txt).
2. Clone the complete repository and add its folder in Unity Hub.
3. Open it with the recorded editor and allow [package resolution](Packages/manifest.json) to finish. Declared packages include URP 17.2.0, Input System 1.14.2, AI Navigation 2.0.8, and Unity UI 2.0.0.
4. Start from `Assets/Project Files/Game/Scenes/Init.unity`, the first enabled scene in [build settings](ProjectSettings/EditorBuildSettings.asset).
5. Check the console and Inspector references before testing learning activities or building for a device.

Seven scenes are enabled: Init, Game, and World 0–4. MainMenu and the bundled example scenes are not enabled in the reviewed build list. No successful import, build, or device run is claimed.

## Source guide

| Area | Source |
| --- | --- |
| Learning content | [QuestionClasses.cs](Assets/QuestionClasses.cs) |
| Question selection and answer flow | [QuestionController.cs](Assets/QuestionController.cs), [QuestionAssign.cs](Assets/QuestionAssign.cs) |
| Jawi presentation | [JawiFix.cs](Assets/JawiFix.cs) |
| Per-player star score | [ScoreController.cs](Assets/ScoreController.cs) |
| Profiles and score reporting | [GameStartupController.cs](Assets/GameStartupController.cs), [DetailPlayer.cs](Assets/DetailPlayer.cs) |

## Data and project status

The startup controller can post the selected player's name, identifier, stars, rounds, and device name to the existing service. Review deployment configuration and data handling before a release; this review did not call that service.

See [validation notes](docs/VALIDATION.md) for source observations and remaining checks. Bundled framework code, ArabicSupport, assets, and packages retain their respective terms and attribution. This README does not establish asset redistribution rights or add a project-wide licence.
