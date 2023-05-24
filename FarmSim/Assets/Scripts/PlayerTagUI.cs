using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTagUI : MonoBehaviour
{
    public Image p1;
    private Image p1Use;
    private Transform head;

    void Start()
    {
        p1Use = Instantiate(p1, FindObjectOfType<Canvas>().transform).GetComponent<Image>();
        head = transform.GetChild(6);
    }


    void Update()
    {
        p1Use.transform.position = Camera.main.WorldToScreenPoint(head.position);
    }
}
