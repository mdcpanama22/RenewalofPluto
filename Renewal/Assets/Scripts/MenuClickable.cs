﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuClickable : MonoBehaviour {

    public string sceneName;
    //public Shader lightUp;

    //private Renderer rend;

	// Use this for initialization
	void Start () {
        //rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }

    private void OnMouseOver()
    {
        //rend.material.shader = Shader.Find("Self-Illumin/Outlined Diffuse");
        //rend.material.shader = lightUp;
    }

    private void OnMouseExit()
    {
        //rend.material.shader = Shader.Find("Diffuse");
    }
}
