using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeUIElement : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == 0)
        {
            //Enter Fade-Out Animation
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == 0)
        {
            //Exit fade-out animation
        }
    }

}
