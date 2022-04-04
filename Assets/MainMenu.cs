using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject worldObject;
    public WorldObject.ControlScheme controlsType = WorldObject.ControlScheme.MNK;
    public GameObject conSelLine;
    public GameObject mnkSelLine;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        worldObject = GameObject.Find("WorldObject");
    }

    // Update is called once per frame
    void Update()
    {
        if (controlsType == WorldObject.ControlScheme.MNK && settingsMenu.activeSelf == true)
        {
            mnkSelLine.SetActive(true);
            conSelLine.SetActive(false);
        }

        else if (controlsType == WorldObject.ControlScheme.Controller && settingsMenu.activeSelf == true)
        {
            mnkSelLine.SetActive(false);
            conSelLine.SetActive(true);
        }

        worldObject.GetComponent<WorldObject>().selectedControlScheme = controlsType;
    }

    public void SayOptions()
    {
        settingsMenu.SetActive(true);
    }

    public void SayPlayDemo()
    {
        SceneManager.LoadScene("Game");
    }

    public void CloseSettingsMenu()
    {
        settingsMenu.SetActive(false);
    }

    public void ControllerButton()
    {
        controlsType = WorldObject.ControlScheme.Controller;
    }

    public void MNKButton()
    {
        controlsType = WorldObject.ControlScheme.MNK;
    }
}
