using UnityEngine;
using System.Collections;

public class touchInputManager : MonoBehaviour {

    private int widthScreen;
    private int heightScreen;

    private int leftBorder;
    private int rightBorder;
    private int middleBorder;

    private Dolphin upperLeftDolphinScript;
    private Dolphin bottomLeftDolphinScript;
    private Dolphin upperRightDolphinScript;
    private Dolphin bottomRightDolphinScript;

    void Start () {
        widthScreen = Screen.width;
        heightScreen = Screen.height;

        leftBorder = (widthScreen - heightScreen) / 2;
        rightBorder = widthScreen - leftBorder;
        middleBorder = heightScreen / 2;

        upperLeftDolphinScript = GameObject.Find("Dolphins/Dolphin_top_left").GetComponent<Dolphin>();
		bottomLeftDolphinScript = GameObject.Find("Dolphins/Dolphin_bottom_left").GetComponent<Dolphin>();
		upperRightDolphinScript = GameObject.Find("Dolphins/Dolphin_top_right").GetComponent<Dolphin>();
		bottomRightDolphinScript = GameObject.Find("Dolphins/Dolphin_bottom_right").GetComponent<Dolphin>();
    }

    void Update () {

        foreach(Touch touch in Input.touches)
        {
            if (touch.position.x < leftBorder && touch.position.y > middleBorder)
            {
                //Touch in upper left corner.
				if(touch.phase != TouchPhase.Ended)
                {
                    StartCoroutine(upperLeftDolphinScript.startAnim());
				} 
            }
            else if (touch.position.x < leftBorder && touch.position.y < middleBorder)
            {
                //Touch in down left corner.
                if (touch.phase != TouchPhase.Ended)
                {
                    StartCoroutine(bottomLeftDolphinScript.startAnim());
                } 
            }
            else if (touch.position.x > rightBorder && touch.position.y > middleBorder)
            {
                //Touch in upper right corner.
                if (touch.phase != TouchPhase.Ended)
                {
                    StartCoroutine(upperRightDolphinScript.startAnim());
                } 
            }
            else if (touch.position.x > rightBorder && touch.position.y < middleBorder)
            {
                //Touch in down right corner.
                if (touch.phase != TouchPhase.Ended)
                {
                    StartCoroutine(bottomRightDolphinScript.startAnim());
                } 
            }
        }
	
	}
}
