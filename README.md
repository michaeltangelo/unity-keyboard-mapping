# unity-keyboard-mapping
getting MIDI inputs working in Unity

There are two scenes (one for testing, one for the MIDI piano):
1) LocalTesting  
-	Uses computer keyboard home row (asdfghjkl) to control 9 'keys'  
2) MIDIScene
-	Uses MIDI Keyboard input via USB MIDI controller to control 88 'keys'

Current workflow:  
- use LocalTesting scene to test changes when MIDI access is not possible.
- Currently, changes in testScripts must be manually transferred to the main scene scripts  

Can ignore MidiJack / Keijiro folders -> they are the plugin folders to allow the MIDI Processing to work
- thanks to Keijiro for writing the MidiJack driver
- https://github.com/keijiro/MidiJack