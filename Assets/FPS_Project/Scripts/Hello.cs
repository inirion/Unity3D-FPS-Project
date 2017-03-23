using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hello : MonoBehaviour {
    private string _message = string.Empty;
    private Text _textWelcome;
    private GameObject _canvasWelcome;
	// Use this for initialization
	void Start () {
        SetInitialReferences();
        _message = "Hello Player.";
        MyWelcomeMessage();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void SetInitialReferences()
    {
        _canvasWelcome = GameObject.Find("CanvasWelcome");
        _textWelcome = GameObject.Find("TextWelcome").GetComponent<Text>();
    }

    void MyWelcomeMessage()
    {
        if(_textWelcome != null)
        {
            _textWelcome.text = _message;
        }
        else
        {
            Debug.LogWarning("Text object not assigned");
        }

        if(_canvasWelcome != null)
        {
            StartCoroutine(DisableCanvas(3.0f));
        }
        else
        {
            Debug.LogWarning("Canvas object not assigned");
        }
        
    }

    IEnumerator DisableCanvas(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        _canvasWelcome.SetActive(false);
    }
}
