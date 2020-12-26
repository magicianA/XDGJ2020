using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : BugableObjects
{
    public bool isPressed = false;
    public Door door;
    private SpriteRenderer spriteRenderer;
    [SerializeField]
    private Sprite activeSprite;
    [SerializeField]
    private Sprite deactiveSprite;
    void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player"){
            if(collider.GetComponent<Player>().bugType != 2 && this.bugType != 1 && this.bugType != 2){
                isPressed = !isPressed;
                door.isOpen = isPressed;
            }
        }
    }
    void Update()
    {
        if(isPressed){
            spriteRenderer.sprite = activeSprite;
        }else{
            spriteRenderer.sprite = deactiveSprite;
        }
    }
}
