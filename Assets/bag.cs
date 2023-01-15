
using System.Collections;
using System.Collections.Generic;
using MyGameManager;
using UnityEngine;
using UnityEngine.UI;

public class bag : MonoBehaviour
{

    private MyGameSceneManager gsm;
    private Image bag_image;
    public int cli_type;
    public Sprite attack;
    public Sprite deffence;
    public Sprite move;
    public Sprite UIMask;

    void Awake()
    {
        gsm = MyGameSceneManager.GetInstance();
        bag_image = GetComponent<Image>();
    }

    public void On_bag_Button()
    {
        Debug.Log("in bag clicked .....");
        Debug.Log(cli_type);
        Debug.Log(bag_image.sprite);
        int clickType = gsm.GetClicked().GetClickType();
        if (bag_image.sprite != UIMask && clickType == 0)
        {
            Debug.Log(cli_type);

            bag_image.sprite = UIMask;
            gsm.GetClicked().SetClickType(cli_type);
            cli_type = 0;
        }
        else if (bag_image.sprite == UIMask)
        {
            if (clickType == 1)
                bag_image.sprite = attack;
            else if (clickType == 2)
                bag_image.sprite = deffence;
            else if (clickType == 3)
                bag_image.sprite = move;
            cli_type = clickType;
            gsm.GetClicked().SetClickType(0);
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
