
using System.Collections;
using System.Collections.Generic;
using MyGameManager;
using UnityEngine;
using UnityEngine.UI;

public class clickedImage : MonoBehaviour
{

    private MyGameSceneManager gsm;
    private Image click_image;
  
    private int click_type = 0;
    public Sprite basep;
    public Sprite attack;
    public Sprite jinghua;
    public Sprite deffence;
    public Sprite move;
    public Color None;
    public Color NotNone;
    public Camera cam;


    void Awake()
    {
        gsm = MyGameSceneManager.GetInstance();
        gsm.SetMouse(this);
        click_image = GetComponent<Image>();
    }

    public int GetClickType()
    {
        return click_type;
    }

    public void SetClickType(int cli_type)
    {
        click_type = cli_type;
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("strat click_type:  ");
        Debug.Log(click_type);
        Debug.Log(transform.position.x);
        Debug.Log(transform.position.y);
        Debug.Log(transform.position.z);
        if (click_type == 0)
        {
            
            click_image.sprite = basep;
            // click_image.color = None;
        }
        else
        {
            // click_image.color = NotNone;
            if (click_type == 1)
                click_image.sprite = attack;
            else if (click_type == 2)
                click_image.sprite = deffence;
            else if (click_type == 3)
                click_image.sprite = move;
            
            Vector3 screenP =Camera.main.WorldToScreenPoint(transform.position);
            Vector3 mp = Input.mousePosition;
            mp.z=screenP.z;
            // Vector3 mmp = cam.ScreenToWorldPoint(mp);
            // transform.position = new Vector3(mp.x - 450, mp.y - 200, 0);
            transform.position = Camera.main.ScreenToWorldPoint(mp);
            // transform.position = mp+new Vector3(-370,-140,0);
            Debug.Log("mp: " + mp);

            // Debug.Log("mmp: " + mmp);
            Debug.Log("position: "+transform.position);
            Debug.Log(Camera.main.ScreenToWorldPoint(mp));

        }

    }
}
