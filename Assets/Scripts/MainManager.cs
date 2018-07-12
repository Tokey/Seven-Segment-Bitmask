using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainManager : MonoBehaviour {
    public Segment[] maskedButtons;
    int[] bitMask=new int[8];
    public Text[] bits;
    public Text HEXOP;
    int hex;
    public AudioClip type;
    public AudioClip open;
    bool mode;
    public Text ModeText;
    void Start()
    {
        mode = true;
    }
	void Update () {

        if (mode)
            ModeText.text = "ANODE";
        else
            ModeText.text = "CATHODE";
        for (int i = 0; i < maskedButtons.Length; i++)
        {
            if (maskedButtons[i].isClicked == true)
            {
                if(mode)
                bitMask[i] = 0;
                else
                    bitMask[i] = 1;

                bits[i].text = bitMask[i].ToString();
            }

            else
            {
                if (mode)
                    bitMask[i] = 1;
                else
                    bitMask[i] = 0;
                bits[i].text = bitMask[i].ToString();
            }

            
        }
        hex = 0;
        for (int i = 0; i < maskedButtons.Length; i++)
        {
            hex += (int)(bitMask[i] * Mathf.Pow((float)2, (float)i));
        }
        HEXOP.text = hex.ToString("X2");

    }

    public void ResetMask()
    {

        AudioSource.PlayClipAtPoint(type, Vector3.zero);
        for (int i = 0; i < maskedButtons.Length; i++)
            maskedButtons[i].isClicked = false;
        AdManager.Instance.ShowBanner();
    }

    public void ChangeMode()
    {
        AudioSource.PlayClipAtPoint(type, Vector3.zero);
        mode = !mode;
        AdManager.Instance.ShowBanner();
    }

    public void PlayAudio()
    {
        AudioSource.PlayClipAtPoint(open, Vector3.zero);
    }
    public void RemoveBanner()
    {
        AdManager.Instance.RemoveBanner(); 
    }

    public void Quit()
    {
        Application.Quit();
    }


    public void Mask0()
    {
        ResetMask();
        maskedButtons[0].isClicked = true;
        maskedButtons[1].isClicked = true;
        maskedButtons[2].isClicked = true;
        maskedButtons[3].isClicked = true;
        maskedButtons[4].isClicked = true;
        maskedButtons[5].isClicked = true;
    }

    public void Mask1()
    {
        ResetMask();
        maskedButtons[1].isClicked = true;
        maskedButtons[2].isClicked = true;
    }

    public void Mask2()
    {
        ResetMask();
        maskedButtons[0].isClicked = true;
        maskedButtons[1].isClicked = true;
        maskedButtons[3].isClicked = true;
        maskedButtons[4].isClicked = true;
        maskedButtons[6].isClicked = true;

    }

    public void Mask3()
    {
        ResetMask();
        maskedButtons[0].isClicked = true;
        maskedButtons[1].isClicked = true;
        maskedButtons[2].isClicked = true;
        maskedButtons[3].isClicked = true;
        maskedButtons[6].isClicked = true;
    }
    public void Mask4()
    {
        ResetMask();
        maskedButtons[5].isClicked = true;
        maskedButtons[1].isClicked = true;
        maskedButtons[2].isClicked = true;
        maskedButtons[6].isClicked = true;
    }
    public void Mask5()
    {
        ResetMask();
        maskedButtons[0].isClicked = true;
        maskedButtons[5].isClicked = true;
        maskedButtons[2].isClicked = true;
        maskedButtons[3].isClicked = true;
        maskedButtons[6].isClicked = true;
    }
    public void Mask6()
    {
        ResetMask();
        maskedButtons[0].isClicked = true;
        maskedButtons[2].isClicked = true;
        maskedButtons[3].isClicked = true;
        maskedButtons[6].isClicked = true;
        maskedButtons[5].isClicked = true;
        maskedButtons[4].isClicked = true;
    }
    public void Mask7()
    {
        ResetMask();
        maskedButtons[0].isClicked = true;
        maskedButtons[1].isClicked = true;
        maskedButtons[2].isClicked = true;
        maskedButtons[5].isClicked = true;
    }
    public void Mask8()
    {
        ResetMask();
        maskedButtons[0].isClicked = true;
        maskedButtons[1].isClicked = true;
        maskedButtons[2].isClicked = true;
        maskedButtons[3].isClicked = true;
        maskedButtons[4].isClicked = true;
        maskedButtons[5].isClicked = true;
        maskedButtons[6].isClicked = true;
    }

    public void Mask9()
    {
        ResetMask();
        maskedButtons[0].isClicked = true;
        maskedButtons[1].isClicked = true;
        maskedButtons[2].isClicked = true;
        maskedButtons[3].isClicked = true;
        maskedButtons[5].isClicked = true;
        maskedButtons[6].isClicked = true;
    }

    public void MaskA()
    {
        ResetMask();
        maskedButtons[0].isClicked = true;
        maskedButtons[4].isClicked = true;
        maskedButtons[1].isClicked = true;
        maskedButtons[2].isClicked = true;
        maskedButtons[5].isClicked = true;
        maskedButtons[6].isClicked = true;
    }

    public void MaskB()
    {
        ResetMask();
        maskedButtons[2].isClicked = true;
        maskedButtons[3].isClicked = true;
        maskedButtons[4].isClicked = true;
        maskedButtons[5].isClicked = true;
        maskedButtons[6].isClicked = true;
    }

    public void MaskC()
    {
        ResetMask();
        maskedButtons[0].isClicked = true;
        maskedButtons[3].isClicked = true;
        maskedButtons[4].isClicked = true;
        maskedButtons[5].isClicked = true;
       
    }

    public void MaskD()
    {
        ResetMask();
        maskedButtons[1].isClicked = true;
        maskedButtons[2].isClicked = true;
        maskedButtons[3].isClicked = true;
        maskedButtons[4].isClicked = true;
        maskedButtons[6].isClicked = true;
    }

    public void MaskE()
    {
        ResetMask();
        maskedButtons[0].isClicked = true;
        maskedButtons[3].isClicked = true;
        maskedButtons[4].isClicked = true;
        maskedButtons[5].isClicked = true;
        maskedButtons[6].isClicked = true;
    }

    public void MaskF()
    {
        ResetMask();
        maskedButtons[0].isClicked = true;
        maskedButtons[4].isClicked = true;
        maskedButtons[5].isClicked = true;
        maskedButtons[6].isClicked = true;
    }





}
