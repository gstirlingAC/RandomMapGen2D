using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 1. Import the Unity Editor namespace. 
// We need this to create an inspector element.
using UnityEditor; 

// 2. We add a CustomEditor attribute to associate this class 
// as a custom editor for the random map tester.
[CustomEditor(typeof(RandomMapTester))] 

// 3. Replace MonoBehaviour with Editor as we are now extending Editor
// as opposed to MonoBehaviour.
public class RandomMapTesterEditor : Editor {
    // 4. Create an override method for the predefined OnInspectorGUI method.
    public override void OnInspectorGUI()
    {
        // 5. Because we are overriding OnInspectorGUI 
        // we need to manually call the DrawDefaultInspector method.
        // This way the inspector should work as before.
        DrawDefaultInspector(); 

        // 6. Create a variable to store our script and
        // cast the target to the RandomMapTester class.
        var script = (RandomMapTester)target;

        // 7. Create a button using GUILayout to generate our "island".
        if(GUILayout.Button("Generate Island"))
        {
            // 8. We need to create a condition to limit the execution
            // of the MakeMap method to when the game is running only.
            if (Application.isPlaying)
            {
                script.MakeMap(); // 9. Call MakeMap from the script variable.
            }
        }
    }
}
