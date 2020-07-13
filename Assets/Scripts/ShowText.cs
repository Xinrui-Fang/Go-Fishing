using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour
{
    public GameObject piranhaText;
    public GameObject purplefishText;
    public GameObject stingrayText;
    public GameObject spermwhaleText;
    public GameObject rainbow_cichlidText;
    public GameObject red_rockfishText;
    public GameObject redear_sunfishText;
    public GameObject rockfishText;
    public GameObject sardineText;
    public GameObject shaudText; //10
    public GameObject sunfishText;
    public GameObject SynodontisText;
    public GameObject titanText;
    public GameObject trewavasText;
    public GameObject trumpefishText; //15

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("piranha(Clone)") != true)
        {
            piranhaText.SetActive(false);
        }

        if (GameObject.Find("purplefish(Clone)") != true)
        {
            purplefishText.SetActive(false);
        }

        if (GameObject.Find("stingray(Clone)") != true)
        {
            stingrayText.SetActive(false);
        }

        if (GameObject.Find("spermwhale(Clone)") != true)
        {
            spermwhaleText.SetActive(false);
        }

        if (GameObject.Find("rainbow_cichlid(Clone)") != true)
        {
            rainbow_cichlidText.SetActive(false);
        }

        if (GameObject.Find("red_rockfish(Clone)") != true)
        {
            red_rockfishText.SetActive(false);
        }

        if (GameObject.Find("redear_sunfish(Clone)") != true)
        {
            redear_sunfishText.SetActive(false);
        }

        if (GameObject.Find("rockfish(Clone)") != true)
        {
            rockfishText.SetActive(false);
        }

        if (GameObject.Find("sardine(Clone)") != true)
        {
            sardineText.SetActive(false);
        }

        if (GameObject.Find("shaud(Clone)") != true)
        {
            shaudText.SetActive(false);
        }

        if (GameObject.Find("sunfish(Clone)") != true)
        {
            sunfishText.SetActive(false);
        }

        if (GameObject.Find("Synodontis_eupterus(Clone)") != true)
        {
            SynodontisText.SetActive(false);
        }

        if (GameObject.Find("titan_triggerfish(Clone)") != true)
        {
            titanText.SetActive(false);
        }

        if (GameObject.Find("trewavas_cichlid(Clone)") != true)
        {
            trewavasText.SetActive(false);
        }

        if (GameObject.Find("trumpetfish(Clone)") != true)
        {
            trumpefishText.SetActive(false);
        }

    }

    public void showText()
    {
        if (piranhaText != null && GameObject.Find("piranha(Clone)"))
        {
            bool isActive = piranhaText.activeSelf;
            piranhaText.SetActive(!isActive);
        }

        if (purplefishText != null && GameObject.Find("purplefish(Clone)"))
        {
            bool isActive = purplefishText.activeSelf;
            purplefishText.SetActive(!isActive);
        }

        if (stingrayText != null && GameObject.Find("stingray(Clone)"))
        {
            bool isActive = stingrayText.activeSelf;
            stingrayText.SetActive(!isActive);
        }

        if (spermwhaleText != null && GameObject.Find("spermwhale(Clone)"))
        {
            bool isActive = spermwhaleText.activeSelf;
            spermwhaleText.SetActive(!isActive);
        }

        if (rainbow_cichlidText != null && GameObject.Find("rainbow_cichlid(Clone)"))
        {
            bool isActive = rainbow_cichlidText.activeSelf;
            rainbow_cichlidText.SetActive(!isActive);
        }

        if (red_rockfishText != null && GameObject.Find("red_rockfish(Clone)"))
        {
            bool isActive = red_rockfishText.activeSelf;
            red_rockfishText.SetActive(!isActive);
        }

        if (redear_sunfishText != null && GameObject.Find("redear_sunfish(Clone)"))
        {
            bool isActive = redear_sunfishText.activeSelf;
            redear_sunfishText.SetActive(!isActive);
        }

        if (rockfishText != null && GameObject.Find("rockfish(Clone)"))
        {
            bool isActive = rockfishText.activeSelf;
            rockfishText.SetActive(!isActive);
        }

        if (sardineText != null && GameObject.Find("sardine(Clone)"))
        {
            bool isActive = sardineText.activeSelf;
            sardineText.SetActive(!isActive);
        }

        if (shaudText != null && GameObject.Find("shaud(Clone)"))
        {
            bool isActive = shaudText.activeSelf;
            shaudText.SetActive(!isActive);
        }

        if (sunfishText != null && GameObject.Find("sunfish(Clone)"))
        {
            bool isActive = sunfishText.activeSelf;
            sunfishText.SetActive(!isActive);
        }

        if (SynodontisText != null && GameObject.Find("Synodontis_eupterus(Clone)"))
        {
            bool isActive = SynodontisText.activeSelf;
            SynodontisText.SetActive(!isActive);
        }

        if (titanText != null && GameObject.Find("titan_triggerfish(Clone)"))
        {
            bool isActive = titanText.activeSelf;
            titanText.SetActive(!isActive);
        }

        if (trewavasText != null && GameObject.Find("trewavas_cichlid(Clone)"))
        {
            bool isActive = trewavasText.activeSelf;
            trewavasText.SetActive(!isActive);
        }

        if (trumpefishText != null && GameObject.Find("trumpetfish(Clone)"))
        {
            bool isActive = trumpefishText.activeSelf;
            trumpefishText.SetActive(!isActive);
        }

    }
}
