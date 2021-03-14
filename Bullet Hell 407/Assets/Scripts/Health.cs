using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public GameObject heart;
    public Sprite currSprite;
    public Sprite fullHeart;
    public Sprite oneDamageHeart;
    public Sprite twoDamageHeart;
    public Sprite threeDamageHeart;
    //private currHealth hp;
    int hp;
    // Start is called before the first frame update
    void Start()
    {
        heart.GetComponent<SpriteRenderer>().sprite = fullHeart;

    }
    void Update()
    {
        hp = gameObject.GetComponent<Player>().currHealth;
        //heart.GetComponent<SpriteRenderer>().sprite = fullHeart;
        if (hp  == 2)
        {
            heart.GetComponent<SpriteRenderer>().sprite = oneDamageHeart;

        }
       
        else if (hp == 1)
        {
            heart.GetComponent<SpriteRenderer>().sprite = twoDamageHeart;
        }
        else if (hp <= 0)
        {
            heart.GetComponent<SpriteRenderer>().sprite = threeDamageHeart;
        }
        
    }


}
