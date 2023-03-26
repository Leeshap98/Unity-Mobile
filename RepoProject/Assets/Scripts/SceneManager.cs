using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField] GameObject image;

    // Update is called once per frame
    //void Update()
    //{
    //    if(Input.touchCount > 0)
    //    {
    //        Touch touch = Input.GetTouch(0);
    //        if(touch.phase == TouchPhase.Began)
    //        {
    //            if(startGameButton != null)
    //            {
    //                SceneManager.LoadScene(1);
    //            }

    //        }
    //    }
    //}

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                if (image != null)
                {
                    Destroy(image);
                }

            }
        }
    }
}
