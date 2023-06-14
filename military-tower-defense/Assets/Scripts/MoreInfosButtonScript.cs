using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreInfosButtonScript : MonoBehaviour
{

    //Script zum wechseln auf die offizielle Website

    public AudioSource click;
    public void MoreInfosClick()
    {

        Application.OpenURL("https://www.vlp-entertainment.com/vlp-studios/military-tower-defense/");

    }

    public void PlaySound()
    {
        click.Play();
    }
}
