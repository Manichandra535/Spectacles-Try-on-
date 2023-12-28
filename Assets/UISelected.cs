using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UISelected : MonoBehaviour
{
    public GameObject g1info;
    public GameObject g2info;
    public GameObject g3info;
    public Material g1material;
    public Material g2material;
    public Material g3material;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void G1infoenable()
    {
        g1info.SetActive(true);
    }

    public void G1infodisable()
    {
        g1info.SetActive(false);
    }

    public void G2infoenable()
    {
        g2info.SetActive(true);
    }

    public void G2infodisable()
    {
        g2info.SetActive(false);
    }

    public void G3infoenable()
    {
        g3info.SetActive(true);
    }

    public void G3infodisable()
    {
        g3info.SetActive(false);
    }

    public void Glasses1ColorChange()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if(buttonName == "BlackColor")
        {
            g1material.color = new Color(0, 0, 0);
        }

        else if(buttonName == "BlueColor")
        {
            g1material.color = new Color(0.1f, 0.3f, 0.8f);
        }
    }

    public void Glasses2ColorChange()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if (buttonName == "BlackColor")
        {
            g2material.color = new Color(0, 0, 0);
        }

        else if (buttonName == "BlueColor")
        {
            g2material.color = new Color(0.1f, 0.3f, 0.8f);
        }
    }

    public void Glasses3ColorChange()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if (buttonName == "BlackColor")
        {
            g3material.color = new Color(0, 0, 0);
        }

        else if (buttonName == "BlueColor")
        {
            g3material.color = new Color(0.1f, 0.3f, 0.8f);
        }
    }

    public void BuyG1()
    {
        Application.OpenURL("https://www.amazon.in/Lenskart-Antiglare-Eyeglasses-Protection-Rectangle/dp/B09D3H2N2N/ref=sr_1_1_sspa?crid=UIMOJQDMTV5W&keywords=spectacles+for+men&qid=1702307499&sprefix=specta%2Caps%2C208&sr=8-1-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&psc=1");
    }

    public void BuyG2()
    {
        Application.OpenURL("https://www.amazon.in/Lenskart-Antiglare-Eyeglasses-Protection-Rectangle/dp/B09D3H2N2N/ref=sr_1_1_sspa?crid=UIMOJQDMTV5W&keywords=spectacles+for+men&qid=1702307499&sprefix=specta%2Caps%2C208&sr=8-1-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&psc=1");
    }

    public void BuyG3()
    {
        Application.OpenURL("https://www.amazon.in/Lenskart-Antiglare-Eyeglasses-Protection-Rectangle/dp/B09D3H2N2N/ref=sr_1_1_sspa?crid=UIMOJQDMTV5W&keywords=spectacles+for+men&qid=1702307499&sprefix=specta%2Caps%2C208&sr=8-1-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&psc=1");
    }

}
