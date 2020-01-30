using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    MeshRenderer rend;

    private void Start()
    {
        rend = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        Color lerpColor = Color.Lerp(Color.blue, Color.red, 0.1f);
        rend.material.color = lerpColor;
    }
}
