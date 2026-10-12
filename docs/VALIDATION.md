# Validation notes

## Scope

Source and configuration review only. No Unity Editor, gameplay, device build, backend, or other live service was run. Scripts, scenes, assets, packages, and framework attribution are preserved.

## Source observations

- QuestionClasses appends its bank with AddRange to a public list. Check Inspector contents and initialization so levels are not duplicated or offset.
- QuestionController indexes levels using `level - 1`, then reads the selected question and answer lists without visible bounds checks on those accesses. Confirm level, bank, and button-array sizes in each scene.
- The three/four-choice branch depends on level 12 as its boundary. Validate question-bank answer counts and the visible UI for both branches.
- Distractor selection contains reroll loops and bookkeeping across question indices. Test small banks, duplicate answers, and completion without assuming every selection terminates correctly.
- Both correct and incorrect paths call RepeatQuestion; the session ends after five attempts, regardless of score. Confirm this is the intended learning flow.
- Several paths depend on named GameObjects and fixed child indices, including audio objects and the QuestionController lookup. QuestionAssign also uses a delayed initialization call; check lifecycle ordering.
- DetailPlayer derives an index from the final character of a profile key. Test profiles with indices above nine and malformed or missing keys.
- Score and profile persistence depend on CurrentPlayerNo_ and related keys. Check switching players, resets, and consistency of the uploaded stars/rounds with local values.
- GameStartupController posts player name/id, stars, rounds, and device name to `https://app-hanana.com/adventuregamekafav2/insertmark.php`. The service was not called and its contract is unverified.

These are source observations rather than reproduced runtime failures.

## Before a release

1. Import with the recorded Unity version and verify compilation and package compatibility.
2. Exercise Init, Game, and enabled World 0–4 navigation.
3. Review Jawi shaping, reading order, question wording, answer correctness, and subject/stage labels with an educator.
4. Test the three/four-choice transition, feedback, five-attempt completion, and repeated sessions.
5. Test multiple profiles, score persistence, deletion/reset controls, and unavailable-network behaviour in an appropriate test environment.
6. Review bundled asset rights and conduct a separate credential/signing-history audit before publication.

Relative documentation links and enabled scene paths are checked against tracked files. No runtime readiness or full-history security guarantee is implied.
