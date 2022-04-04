using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldObject : MonoBehaviour
{
    public ControlScheme selectedControlScheme = ControlScheme.MNK;
    public bool thermostatEnabled = false;
    public int thermostatInt;
    public GamePlatform gamePlatform;

    public enum ControlScheme {MNK, Controller}
    public enum LifeIcon {LuminPurple, LuminBlue, Theta, ThetaSmall, ThetaCartoon}
    public enum GamePlatform {PC, Xbox, Switch, PS5}
}
