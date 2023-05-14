using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreInfosButtonScript : MonoBehaviour
{

    public AudioSource click;
    public void MoreInfosClick()
    {

        Application.OpenURL("https://www.vlp-entertainment.com/vlp-studios/millitary-tower-defense");

    }

    public void PlaySound()
    {
        click.Play();
    }
}
