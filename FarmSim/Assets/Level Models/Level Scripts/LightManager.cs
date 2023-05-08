using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class LightManager : MonoBehaviour
{
    [SerializeField] private Light DirLight;
    [SerializeField] private PresetLights Light;
    [SerializeField, Range(0, 60)] private float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Light == null)
            return;

        if (Application.isPlaying)
        {
            time += Time.deltaTime;
            time %= 60;
            UpdateLight(time / 60f);
        }
        else
        {
            UpdateLight(time / 60f);
        }
    }

    private void UpdateLight(float timePercent)
    {
        RenderSettings.ambientLight = Light.ambColour.Evaluate(timePercent);
        RenderSettings.fogColor = Light.fogColour.Evaluate(timePercent);

        if(DirLight != null)
        {
            DirLight.color = Light.dirColour.Evaluate(timePercent);
            DirLight.transform.localRotation = Quaternion.Euler(new Vector3((timePercent * 360f) - 90f, 170f, 0));
        }
    }
}
