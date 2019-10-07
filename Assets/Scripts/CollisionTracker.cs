using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionTracker : MonoBehaviour
{
    [SerializeField] Text damageText;
    int damage = 0;
    Material material;
    float damageColor = 0f;
    float damageOpacity= 0f;
    

    private void Start()
    {
        //get renderer component of game object
        Renderer renderer = GetComponent<Renderer>();

        //get material component of game object
        material = renderer.material;       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle" && damage < 100)
        {
            //print a collide debug log
            Debug.Log("Obstacle Collision!");

            //change the damage UI text
            damage++;
            damageText.text = "Damage: " + damage + " %";
            //make the object more red in color
            damageColor += (255 / 100f) / 10;
            damageOpacity += (255 / 100f)/ 10;            
            material.color = new Color(damageColor, 0f, 0f, damageOpacity);
            Debug.Log("color is" + material.color);
            
        }        

    }
}
