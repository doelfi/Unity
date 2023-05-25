using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    [SerializeField]
    public GameObject canvas;
    private UIcontroller _UIScript;

    // Start is called before the first frame update
    void Start()
    {
        _UIScript = canvas.GetComponent<UIcontroller>();
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player"))
        {
            _UIScript.Victory();
        }
    }
}
