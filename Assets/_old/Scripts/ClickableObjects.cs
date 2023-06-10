using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObjects : MonoBehaviour
{
    public Renderer Player;
    public GameObject StatusMenu;
    public GameObject Menu;
    void Start()
    {
        Player.GetComponent<SpriteRenderer>().enabled = true;
    }

    void Update()
    {

    }

    private void OnMouseDown()
    {
        Player.GetComponent<SpriteRenderer>().enabled = false;
        Menu.SetActive(true);
        StatusMenu.SetActive(false);
    }

    private void OnMouseOver()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color (1f,1f,1f, 0.8f);
    }

        private void OnMouseExit()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color (1f,1f,1f, 1f);
    }
}
