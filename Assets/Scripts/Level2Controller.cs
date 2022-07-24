using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Controller : MonoBehaviour
{
    public GameObject red, redCharacter;
    public GameObject yellow, yellowCharacter;
    public GameObject blue, blueCharacter;
    public GameObject green, greenCharacter;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animationReset();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {

            animationRed();
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            animationYellow();
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            animationBlue();
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            animationGreen();
        }

    }

    void animationReset()
    {

        red.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 500f);
        red.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 500f);
        yellow.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 500f);
        yellow.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 500f);
        blue.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 500f);
        blue.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 500f);
        green.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 500f);
        green.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 500f);
        //repositioning

        LeanTween.moveLocal(red, new Vector3(250, -750, 0) - new Vector3(500, -500, 0), .3f);
        LeanTween.moveLocal(green, new Vector3(750, -750, 0) - new Vector3(500, -500, 0), .3f);
        LeanTween.moveLocal(yellow, new Vector3(250, -250, 0) - new Vector3(500, -500, 0), .3f);
        LeanTween.moveLocal(blue, new Vector3(750, -250, 0) - new Vector3(500, -500, 0), .3f);


       

        LeanTween.scale(redCharacter, new Vector3(150, 150, 150), .1f);
        LeanTween.scale(yellowCharacter, new Vector3(150, 150, 150), .1f);
        LeanTween.scale(blueCharacter, new Vector3(150, 150, 150), .1f);
        LeanTween.scale(greenCharacter, new Vector3(150, 150, 150), .1f);
    }
    void animationRed()
    {
        //scalling
        red.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 700f);
        red.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 700f);
        green.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 700f);
        green.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300f);
        yellow.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300f);
        yellow.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 700f);
        blue.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300f);
        blue.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300f);
        //repositioning

        LeanTween.moveLocal(red, new Vector3(350, -650, 0)-new Vector3(500,-500,0), .3f);
        LeanTween.moveLocal(green, new Vector3(850, -650, 0) - new Vector3(500, -500, 0), .3f);
        LeanTween.moveLocal(yellow, new Vector3(350, -150, 0) - new Vector3(500, -500, 0), .3f);
        LeanTween.moveLocal(blue, new Vector3(850, -150, 0) - new Vector3(500, -500, 0), .3f);
       
      

        LeanTween.scale(redCharacter, new Vector3(250, 250, 250), .3f);
        LeanTween.scale(yellowCharacter, new Vector3(50, 50, 50), .3f);
        LeanTween.scale(blueCharacter, new Vector3(50, 50, 50), .3f);
        LeanTween.scale(greenCharacter, new Vector3(50, 50, 50), .3f);
    }
    void animationBlue()
    {
        //scalling
        blue.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 700f);
        blue.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 700f);
        green.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300f);
        green.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 700f);
        yellow.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 700f);
        yellow.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300f);
        red.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300f);
        red.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300f);
        //repositioning
        LeanTween.moveLocal(red, new Vector3(150, -850, 0) - new Vector3(500, -500, 0), .3f);
        LeanTween.moveLocal(green, new Vector3(650, -850, 0) - new Vector3(500, -500, 0), .3f);
        LeanTween.moveLocal(yellow, new Vector3(150, -350, 0) - new Vector3(500, -500, 0), .3f);
        LeanTween.moveLocal(blue, new Vector3(650, -350, 0) - new Vector3(500, -500, 0), .3f);



        LeanTween.scale(blueCharacter, new Vector3(250, 250, 250), .3f);
        LeanTween.scale(yellowCharacter, new Vector3(50, 50, 50), .3f);
        LeanTween.scale(redCharacter, new Vector3(50, 50, 50), .3f);
        LeanTween.scale(greenCharacter, new Vector3(50, 50, 50), .3f);
    }
    void animationYellow()
    {
        //scalling
        yellow.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 700f);
        yellow.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 700f);
        green.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300f);
        green.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300f);
        blue.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 700f);
        blue.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300f);
        red.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300f);
        red.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 700);
        //repositioning
        LeanTween.moveLocal(red, new Vector3(350, -850, 0) - new Vector3(500, -500, 0), .3f);
        LeanTween.moveLocal(green, new Vector3(850, -850, 0) - new Vector3(500, -500, 0), .3f);
        LeanTween.moveLocal(yellow, new Vector3(350, -350, 0) - new Vector3(500, -500, 0), .3f);
        LeanTween.moveLocal(blue, new Vector3(850, -350, 0) - new Vector3(500, -500, 0), .3f);


        LeanTween.scale(yellowCharacter , new Vector3(250, 250, 250), .3f);
        LeanTween.scale(blueCharacter, new Vector3(50, 50, 50), .3f);
        LeanTween.scale(redCharacter, new Vector3(50, 50, 50), .3f);
        LeanTween.scale(greenCharacter, new Vector3(50, 50, 50), .3f);
    }
    void animationGreen()
    {
        //scalling
        green.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 700f);
        green.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 700f);
        blue.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300f);
        blue.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 700f);
        yellow.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300f);
        yellow.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300f);
        red.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 700f);
        red.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300f);
        //repositioning
        LeanTween.moveLocal(red, new Vector3(150, -650, 0) - new Vector3(500, -500, 0), .3f);
        LeanTween.moveLocal(green, new Vector3(650, -650, 0) - new Vector3(500, -500, 0), .3f);
        LeanTween.moveLocal(yellow, new Vector3(150, -150, 0) - new Vector3(500, -500, 0), .3f);
        LeanTween.moveLocal(blue, new Vector3(650, -150, 0) - new Vector3(500, -500, 0), .3f);



        LeanTween.scale(greenCharacter, new Vector3(250, 250, 250), .3f);
        LeanTween.scale(yellowCharacter, new Vector3(50, 50, 50), .3f);
        LeanTween.scale(redCharacter, new Vector3(50, 50, 50), .3f);
        LeanTween.scale(blueCharacter, new Vector3(50, 50, 50), .3f);
    }
}
