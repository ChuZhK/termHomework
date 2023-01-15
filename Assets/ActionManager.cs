using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

namespace MyGameManager
{

    public class MyGameSceneManager : System.Object
    {
        private static MyGameSceneManager _game_scene_manager;
        private static clickedImage _Clicked;

        public static MyGameSceneManager GetInstance()
        {
            if (_game_scene_manager == null)
            {
                _game_scene_manager = new MyGameSceneManager();
            }
            return _game_scene_manager;
        }

        public void SetMouse(clickedImage _clicked)
        {
            if (_Clicked == null)
            {
                _Clicked = _clicked;
            }
        }

        public clickedImage GetClicked()
        {
            return _Clicked;
        }
    }

}
