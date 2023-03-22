using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessing : MonoBehaviour
{
    [SerializeField] private PostProcessVolume _postProcessVolume;
    private new bool enabled = false;
    // Start is called before the first frame update
    void Start()
    {
        enabled = Convert.ToBoolean(PlayerPrefs.GetInt("PostProcessing", 0));
        _postProcessVolume.enabled = enabled;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            enabled = !enabled;
            _postProcessVolume.enabled = enabled;
            PlayerPrefs.SetInt("PostProcessing", Convert.ToInt32(enabled));
            PlayerPrefs.Save();
        }
    }
}
