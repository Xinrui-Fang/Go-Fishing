using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pamphlet : MonoBehaviour
{

    public GameObject video;
    public GameObject panelPiranha;
    public GameObject panelPurplefish;
    public GameObject panelRainbow;
    public GameObject panelRed_rock;
    public GameObject panelRedear;

    public GameObject panelRockfish;
    public GameObject panelSardine;
    public GameObject panelShaud;
    public GameObject panelStingray;
    public GameObject panelSpermwhale;

    public GameObject panelSunfish;
    public GameObject panelSynodontis;
    public GameObject panelTitan;
    public GameObject panelTrewavas;
    public GameObject panelTrumpefish;


    // Start is called before the first frame update
    void Start()
    {
        video.SetActive(false);

        panelPiranha.SetActive(false);
        panelPurplefish.SetActive(false);
        panelRainbow.SetActive(false);
        panelRed_rock.SetActive(false);
        panelRedear.SetActive(false);


        panelStingray.SetActive(false);
        panelSpermwhale.SetActive(false);
        panelRockfish.SetActive(false);
        panelSardine.SetActive(false);
        panelShaud.SetActive(false);

        panelSunfish.SetActive(false);
        panelSynodontis.SetActive(false);
        panelTitan.SetActive(false);
        panelTrewavas.SetActive(false);
        panelTrumpefish.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Personalize.isPiranha == true)
        {
            panelPiranha.SetActive(true);
        }

        if (Personalize.isPurplefish == true)
        {
            panelPurplefish.SetActive(true);
        }

        if (Personalize.isRainbow == true)
        {
            panelRainbow.SetActive(true);
        }

        if (Personalize.isRed_rock == true)
        {
            panelRed_rock.SetActive(true);
        }

        if (Personalize.isRedear == true)
        {
            panelRedear.SetActive(true);
        }

        if (Personalize.isRockfish == true)
        {
            panelRockfish.SetActive(true);
        }

        if (Personalize.isSardine == true)
        {
            panelSardine.SetActive(true);
        }

        if (Personalize.isShaud == true)
        {
            panelShaud.SetActive(true);
        }

        if (Personalize.isSpermwhale == true)
        {
            panelSpermwhale.SetActive(true);
        }

        if (Personalize.isStingray == true)
        {
            panelStingray.SetActive(true);
        }

        if (Personalize.isSunfish == true)
        {
            panelSunfish.SetActive(true);
        }

        if (Personalize.isSynodontis == true)
        {
            panelSynodontis.SetActive(true);
        }

        if (Personalize.isTitan == true)
        {
            panelTitan.SetActive(true);
        }

        if (Personalize.isTrewavas == true)
        {
            panelTrewavas.SetActive(true);
        }

        if (Personalize.isTrumpefish == true)
        {
            panelTrumpefish.SetActive(true);
        }
    }

    public void ShowPanel()
    {
        

        
    }
}
