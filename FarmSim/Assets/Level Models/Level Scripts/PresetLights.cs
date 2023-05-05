using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName ="Light Preset", menuName ="Scriptables/Light Preset", order = 1 )]
public class PresetLights : ScriptableObject
{
    public Gradient ambColour;
    public Gradient dirColour;
    public Gradient fogColour;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
