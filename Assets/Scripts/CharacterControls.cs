using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterControls : MonoBehaviour
{
    // Start is called before the first frame update

    public int weaponSelect = 1;
    public GameObject bottomTracks;
    public float floatPub;
    PlayerControls controls;
    public Vector2 moveStickV2;
    public Vector2 moveWASDV2;
    public Vector2 lookStickV2;
    public Vector2 lookMouseV2;
    public Weapon selectedWeapon = Weapon.Gatling;
    public float moveSpeed = 10;
    public Rigidbody2D rigidBody;
    public float speedBoost = 1;
    public int heatValue = 0;
    public bool overheating = false;
    public int maxHealth = 100;
    public int health;
    public Slider healthSlider;
    public int extraLives = 0;
    public GameObject pointerObject;
    public GameObject pointerBottomObject;
    public GameObject cameraYes;
    public Camera mainCam;

    public GameObject worldObject;

    //switch sfx
    public AudioSource switchVoiceSource;
    public AudioSource switchSFXSource;
    public AudioClip gatlingVoice;
    public AudioClip laserVoice;
    public AudioClip grenadeVoice;
    public AudioClip bladeVoice;
    //weapon stuff
    public GameObject gatlingObject;
    public GameObject laserObject;
    public GameObject grenadeObject;
    public GameObject bladeObject;
    //
    public AudioSource catchFireSource;
    public bool playFireSound = false;
    public HeatStage heatStage = HeatStage.CoolAndCollected;
    //heat stuff
    public GameObject stage1Head;
    public GameObject stage2Head;
    public GameObject stage3Head;
    public GameObject stageMaxHead;
    public GameObject coolCollectedText;
    public GameObject tepidTotalingText;
    public GameObject roastingRampageText;
    public GameObject blisteringBlitzText;
    public Slider heatSlider;
    //status
    public bool isOnFire = false;
    //
    public enum Weapon { Gatling, Laser, Grenade, Blade }
    public enum AttackType {GatlingBullets, LaserBolt, }
    public enum HeatStage { CoolAndCollected, TepidTotaling, RoastingRampage, BlisteringBlitz }

    private void OnEnable()
    {
        controls.Gameplay.Enable();

        worldObject = GameObject.Find("WorldObject");
    }

    private void Start()
    {
        StartCoroutine(OvertimeDamage());
        health = maxHealth;
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }

    private void Awake()
    {
        controls = new PlayerControls();

        controls.Gameplay.MoveStick.performed += ctx => moveStickV2 = (ctx.ReadValue<Vector2>());
        controls.Gameplay.MoveStick.canceled += ctx => moveStickV2 = (ctx.ReadValue<Vector2>());
        controls.Gameplay.MoveWASD.performed += ctx => moveWASDV2 = (ctx.ReadValue<Vector2>());
        controls.Gameplay.MoveWASD.canceled += ctx => moveWASDV2 = (ctx.ReadValue<Vector2>());
        controls.Gameplay.LookStick.performed += ctx => lookStickV2 = (ctx.ReadValue<Vector2>());
        //controls.Gameplay.LookStick.canceled += ctx => lookStickV2 = (ctx.ReadValue <Vector2>());
        controls.Gameplay.LookMouse.performed += ctx => lookMouseV2 = (ctx.ReadValue<Vector2>());
        controls.Gameplay.HeatAbility.performed += ctx => HeatAbility();
        controls.Gameplay.SwitchPlus.performed += ctx => AddWeaponNum();
        controls.Gameplay.SwitchMinus.performed += ctx => NegateWeaponNum();
        controls.Gameplay.SwitchPlus.performed += ctx => SwitchWeapon();
        controls.Gameplay.SwitchMinus.performed += ctx => SwitchWeapon();
    }

    public void SwitchWeapon()
    {
        Debug.Log(weaponSelect);

        switch (weaponSelect)
        {
            case 1:
                if (switchVoiceSource.clip != gatlingVoice)
                {
                    switchVoiceSource.clip = gatlingVoice;
                    switchVoiceSource.Play();
                    selectedWeapon = Weapon.Gatling;
                    gatlingObject.SetActive(true);
                    laserObject.SetActive(false);
                    grenadeObject.SetActive(false);
                    bladeObject.SetActive(false);
                }
                break;

            case 2:
                if (switchVoiceSource.clip != laserVoice)
                {
                    switchVoiceSource.clip = laserVoice;
                    switchVoiceSource.Play();
                    selectedWeapon = Weapon.Gatling;
                    gatlingObject.SetActive(false);
                    laserObject.SetActive(true);
                    grenadeObject.SetActive(false);
                    bladeObject.SetActive(false);
                }
                break;

            case 3:
                if (switchVoiceSource.clip != grenadeVoice)
                {
                    switchVoiceSource.clip = grenadeVoice;
                    switchVoiceSource.Play();
                    selectedWeapon = Weapon.Gatling;
                    gatlingObject.SetActive(false);
                    laserObject.SetActive(false);
                    grenadeObject.SetActive(true);
                    bladeObject.SetActive(false);
                }
                break;

            case 4:
                if (switchVoiceSource.clip != bladeVoice)
                {
                    switchVoiceSource.clip = bladeVoice;
                    switchVoiceSource.Play();
                    selectedWeapon = Weapon.Gatling;
                    gatlingObject.SetActive(false);
                    laserObject.SetActive(false);
                    grenadeObject.SetActive(false);
                    bladeObject.SetActive(true);
                }
                break;
        }
    }

    public void AddWeaponNum()
    {
        weaponSelect -= 1;
    }

    public void NegateWeaponNum()
    {
        weaponSelect += 1;
    }

    public void HeatAbility()
    {

    }

    void DeadStatus()
    {
        if (health <= 0)
        {
            if (extraLives >= 1)
            {
                health = maxHealth;
            }

            else
            {
                Kill();
            }
        }
    }

    void Kill()
    {
        SceneManager.LoadScene("Menu");
    }
    public bool isMoving;
    void RottyBottoms()
    {
        // LookAt 2D
        var controlScheme = worldObject.GetComponent<WorldObject>().selectedControlScheme;
        var pointerPos = moveStickV2;
        switch (controlScheme)
        {
            case WorldObject.ControlScheme.Controller:
                pointerPos = moveStickV2;
                break;

            case WorldObject.ControlScheme.MNK:
                pointerPos = moveWASDV2;
                break;

            default:
                pointerPos = lookStickV2;
                break;
        }

        if (pointerPos != Vector2.zero)
        {
            isMoving = true;
            treadsSound.UnPause();
        }

        else
        {
            isMoving = false;
            treadsSound.Pause();
        }

        pointerBottomObject.transform.position = new Vector3(pointerPos.x + transform.position.x, pointerPos.y + transform.position.y);

        var posV3 = new Vector3(pointerBottomObject.transform.position.x, pointerBottomObject.transform.position.y, 0f);

        // get the angle
        Vector3 norTar = (posV3 - bottomTracks.transform.position).normalized;
        float angle = Mathf.Atan2(norTar.y, norTar.x) * Mathf.Rad2Deg;
        floatPub = angle;
        // rotate to angle
        Quaternion rotation = new Quaternion();
        rotation.eulerAngles = new Vector3(0, 0, angle + 270);
        bottomTracks.transform.rotation = rotation;
    }

    void RottyTops()
    {
        var controlScheme = worldObject.GetComponent<WorldObject>().selectedControlScheme;
        var pointerPos = lookStickV2;
        var mousePos = mainCam.ScreenToWorldPoint(lookMouseV2);

        switch (controlScheme)
        {
            case WorldObject.ControlScheme.Controller:
                pointerPos = lookStickV2;
                break;

            case WorldObject.ControlScheme.MNK:
                pointerPos = lookMouseV2;
                break;

            default:
                pointerPos = lookStickV2;
                
                break;
        }

        pointerObject.transform.position = new Vector3(pointerPos.x + transform.position.x, pointerPos.y + transform.position.y);
        var posV3 = new Vector3(pointerObject.transform.position.x, pointerObject.transform.position.y, 0f);
        Vector3 norm = (posV3 - thetaTopTransform.position).normalized;
        float angle = Mathf.Atan2(norm.y, norm.x) * Mathf.Rad2Deg;
        Quaternion rotation = new Quaternion();
        rotation.eulerAngles = new Vector3(0, 0, angle + 270);
        thetaTopTransform.rotation = rotation;
    }

    void HeatState()
    {
        heatSlider.value = heatValue;

        if (heatValue >= 0 && heatValue <= 39)
        {
            heatStage = HeatStage.CoolAndCollected;
            overheating = false;
        }

        if (heatValue >= 40 && heatValue <= 69)
        {
            heatStage = HeatStage.TepidTotaling;
            overheating = false;
        }

        if (heatValue >= 70 && heatValue <= 99)
        {
            heatStage = HeatStage.RoastingRampage;
            overheating = false;
        }

        if (heatValue >= 100)
        {
            heatStage = HeatStage.BlisteringBlitz;
            overheating = true;
        }
    }

    void OverheatCheck()
    {
        switch (heatStage)
        {
            case HeatStage.CoolAndCollected:
                stage1Head.SetActive(true);
                stage2Head.SetActive(false);
                stage3Head.SetActive(false);
                stageMaxHead.SetActive(false);
                coolCollectedText.SetActive(true);
                tepidTotalingText.SetActive(false);
                roastingRampageText.SetActive(false);
                blisteringBlitzText.SetActive(false);
                break;

            case HeatStage.TepidTotaling:
                stage1Head.SetActive(false);
                stage2Head.SetActive(true);
                stage3Head.SetActive(false);
                stageMaxHead.SetActive(false);
                coolCollectedText.SetActive(false);
                tepidTotalingText.SetActive(true);
                roastingRampageText.SetActive(false);
                blisteringBlitzText.SetActive(false);
                break;

            case HeatStage.RoastingRampage:
                stage1Head.SetActive(false);
                stage2Head.SetActive(false);
                stage3Head.SetActive(true);
                stageMaxHead.SetActive(false);
                coolCollectedText.SetActive(false);
                tepidTotalingText.SetActive(false);
                roastingRampageText.SetActive(true);
                blisteringBlitzText.SetActive(false);
                break;

            case HeatStage.BlisteringBlitz:
                stage1Head.SetActive(false);
                stage2Head.SetActive(false);
                stage3Head.SetActive(false);
                stageMaxHead.SetActive(true);
                coolCollectedText.SetActive(false);
                tepidTotalingText.SetActive(false);
                roastingRampageText.SetActive(false);
                blisteringBlitzText.SetActive(true);
                break;
        }
    }

    public AudioSource treadsSound;
    public GameObject thetaTop;
    public Transform thetaTopTransform;
    void Update()
    {
        HeatState();
        OverheatCheck();
        DeadStatus();
        RottyTops();
        RottyBottoms();

        if (weaponSelect <= 0)
        {
            weaponSelect = 4;
        }

        else if (weaponSelect >= 5)
        {
            weaponSelect = 1;
        }

        healthSlider.value = health;
    }

    IEnumerator OvertimeDamage()
    {

        if (overheating == true | isOnFire == true)
        {
            yield return new WaitForSeconds(0.5f);
            health -= 4;
        }

        yield return new WaitForSeconds(0.5f);
        StartCoroutine(OvertimeDamage());
    }

            void FixedUpdate()
            {

        var movingV2 = moveStickV2;
        var controlScheme = worldObject.GetComponent<WorldObject>().selectedControlScheme;

        switch (controlScheme)
        {
            case WorldObject.ControlScheme.Controller:
                movingV2 = moveStickV2;
                break;

            case WorldObject.ControlScheme.MNK:
                movingV2 = moveWASDV2;
                break;

            default:
                movingV2 = moveWASDV2;
                break;
        }


        Vector2 speedBoostV2 = new Vector2(speedBoost, speedBoost);

        
        rigidBody.AddForce(movingV2);
            }
        }
    
