using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlay : MonoBehaviour
{
    public GameObject video;
    public static int currentClipIndex;

    // Start is called before the first frame update
    void Start()
    {
        video.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        GameObject Button = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        Debug.Log(Button.name);
        if(Button.name == "piranha")
        {
            currentClipIndex = 0;
        }
        if (Button.name == "purplefish")
        {
            currentClipIndex = 1;
        }
        if (Button.name == "rainbow_cichlid")
        {
            currentClipIndex = 2;
        }
        if (Button.name == "red_rockfish")
        {
            currentClipIndex = 3;
        }
        if (Button.name == "redear_sunfish")
        {
            currentClipIndex = 4;
        }

        video.SetActive(true);

        

    }
}
