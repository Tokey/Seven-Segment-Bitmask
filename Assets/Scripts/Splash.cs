using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {

    public float time = 2f;
    private float t;
    public GameObject splash;
    public GameObject menu;
    void Start () {
        t = 0;
	}
	
	// Update is called once per frame
	void Update () {
        t += Time.deltaTime;
        if (t >= time)
        { splash.gameObject.SetActive(false);
            menu.gameObject.SetActive(true);
        }
	}
}
