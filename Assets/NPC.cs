using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using TMPro;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public TextMeshProUGUI lineUI;

    private Canvas dialoguecanvas;

    // Start is called before the first frame update
    void Start()
    {
        dialoguecanvas = lineUI.canvas;
        dialoguecanvas.enabled = false;
    }

    public void StartTalking()
    {
        dialoguecanvas.enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
