using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaDisplay : MonoBehaviour {

    private PlayerStatus status;
    public GameObject player;
    public Text manaText;

    // Use this for initialization
    void Start()
    {
        status = player.GetComponent<PlayerStatus>();
        manaText.text = "Mana: " + status.mana;
    }

    // Update is called once per frame
    void Update()
    {
        manaText.text = "Mana: " + status.mana;
    }
}
