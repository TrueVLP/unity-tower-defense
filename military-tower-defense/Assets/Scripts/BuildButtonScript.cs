using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildButtonScript : MonoBehaviour
{
    public GameObject menue;
    public void BuildClick()
    {
        if(menue.GetComponent<Image>().enabled == false)
        {
            menue.GetComponent<Image>().enabled = true;
        }

        else
        {
            menue.GetComponent<Image>().enabled = false;
        }
        


    }

}
