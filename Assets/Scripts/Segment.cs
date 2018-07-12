using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Segment : MonoBehaviour {

    public bool isClicked ;
    Button button;
    public AudioClip click;
    void Start () {
        isClicked = false;
        button = gameObject.GetComponent<Button>();
       
    }
	
	
	void Update () {
	    if(isClicked)
        {
            button.targetGraphic.color =Color.red ;
        }
        else
        {
            button.targetGraphic.color = new Color(50,50,50,(float)0.2);
        }
	}

    public void Click()
    {
        AudioSource.PlayClipAtPoint(click, Vector3.zero);
        isClicked = !isClicked;
    }
}
