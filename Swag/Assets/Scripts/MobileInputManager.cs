using UnityEngine;
using System.Collections;

public class MobileInputManager : MonoBehaviour {

    private int widthScreen;
    private int heightScreen;

    #region touch
    //private int leftBorder;
    //private int rightBorder;
    //private int middleBorder;

    //private Dolphin upperLeftDolphinScript;
    //private Dolphin bottomLeftDolphinScript;
    //private Dolphin upperRightDolphinScript;
    //private Dolphin bottomRightDolphinScript;
    #endregion

    //Float that determines whether or not the movement was a shake.
    float shakeDetectionThreshold = 1.2f;

    //Interval with which the accelerometervalues are updated.
    private float lowPassFilterFactor = 1.0f / 60.0f;
    private Vector3 lowPassValue;
    private Vector3 acceleration;
    private Vector3 deltaAcceleration;

    private GameObject myCamera;

    void Start () {
        myCamera = GameObject.Find("Manager");

        lowPassValue = Input.acceleration;

        #region touch
        //widthScreen = Screen.width;
        //heightScreen = Screen.height;

        //leftBorder = (widthScreen - heightScreen) / 2;
        //rightBorder = widthScreen - leftBorder;
        //middleBorder = heightScreen / 2;

        //upperLeftDolphinScript = GameObject.Find("Dolphin_top_left").GetComponent<Dolphin>();
        //bottomLeftDolphinScript = GameObject.Find("Dolphin_bottom_left").GetComponent<Dolphin>();
        //upperRightDolphinScript = GameObject.Find("Dolphin_top_right").GetComponent<Dolphin>();
        //bottomRightDolphinScript = GameObject.Find("Dolphin_bottom_right").GetComponent<Dolphin>();
        #endregion


    }

    void Update()
    {
        //Determines acceleration and if there are any gestures.
        acceleration = Input.acceleration;
        lowPassValue = Vector3.Lerp(lowPassValue, acceleration, lowPassFilterFactor);
        deltaAcceleration = acceleration - lowPassValue;

        //Gesture for grabbing, moving device forward rapidly.
        if (deltaAcceleration.x > shakeDetectionThreshold)
        {
            //Send bite message
            Debug.Log("x-positie");
        }
        //Gesture for tilting, moving device down rapidly.
        if (deltaAcceleration.z > shakeDetectionThreshold)
        {
            //Send shake message
            Debug.Log("z-positie");
        }

        //Transform box according to the acceleration.
        myCamera.transform.rotation = Quaternion.Euler(new Vector3(acceleration.y * 90, 0, -acceleration.x * 90));

        #region touch
        //foreach(Touch touch in Input.touches)
        //{

        //    if (touch.position.x < leftBorder && touch.position.y > middleBorder)
        //    {
        //        //First touch in upper left corner.
        //        if(touch.phase == TouchPhase.Began)
        //        {
        //            //upperLeftDolphinScript.doAnimation;
        //        }
        //    }
        //    else if (touch.position.x < leftBorder && touch.position.y < middleBorder)
        //    {
        //        //First touch in down left corner.
        //        if (touch.phase == TouchPhase.Began)
        //        {
        //            //bottomLeftDolphinScript.doAnimation;
        //            Debug.Log("links onder");
        //        }
        //    }
        //    else if (touch.position.x > rightBorder && touch.position.y > middleBorder)
        //    {
        //        //First touch in upper right corner.
        //        if (touch.phase == TouchPhase.Began)
        //        {
        //            //upperRightDolphinScript.doAnimation;
        //            Debug.Log("rechts boven");
        //        }
        //    }
        //    else if (touch.position.x > rightBorder && touch.position.y < middleBorder)
        //    {
        //        //First touch in down right corner.
        //        if (touch.phase == TouchPhase.Began)
        //        {
        //            //bottomRightDolphinScript.doAnimation;
        //            Debug.Log("rechts onder");
        //        }
        //    }
        //}
        #endregion
    }
}

