using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    GameObject player;
    Renderer rend;

<<<<<<< HEAD
    float playerStartpos;
    public float speed = 0.5f;

    private void Start()
    {
        player = GameObject.Find("Player");
        rend = GetComponent<Renderer>();
        playerStartpos = player.transform.position.x;
=======
    float playerStartPos;
    public float speed = 0.5f;

    void Start()
    {
        player = GameObject.Find("Player");
        rend = GetComponent<Renderer>();
        playerStartPos = player.transform.position.x;
>>>>>>> aad5ff8bf06e35b35f41d28a40751d2016511813
    }

    void Update()
    {
<<<<<<< HEAD
        float offset = (player.transform.position.x - playerStartpos) * speed;
=======
        float offset = (player.transform.position.x - playerStartPos) * speed;
>>>>>>> aad5ff8bf06e35b35f41d28a40751d2016511813
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0f));
    }
}