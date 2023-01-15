

using System.Collections;
using System.Collections.Generic;
using MyGameManager;
using UnityEngine;
using UnityEngine.UI;

public class left : MonoBehaviour
{

    private MyGameSceneManager gsm;
    private Image left_img;
    public int click_type;
    public Sprite zhuangbei;
    public Sprite UIMask;
    

    void Awake()
    {
        gsm = MyGameSceneManager.GetInstance();
        left_img = GetComponent<Image>();
    }

    public void On_left_Button()
    {
        Debug.Log("in left clicked .....");
        int clickType = gsm.GetClicked().GetClickType();
        if (left_img.sprite == zhuangbei && clickType == 0)
        {
            Debug.Log("equip: " + click_type);
            left_img.sprite = UIMask;
            gsm.GetClicked().SetClickType(click_type);
        }
        else if (left_img.sprite == UIMask)
        {
            if (clickType == click_type)
            {
                left_img.sprite = zhuangbei;
                gsm.GetClicked().SetClickType(0);
            }
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
