using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Interactable
{
    PlayerManager PlayerManager;
    CharacterStats myStats;



     void Start()
    {
        PlayerManager = PlayerManager.instance;
        myStats = GetComponent<CharacterStats>();
    }
    public override void Interact()
    {
        base.Interact();
        CharacterCombat PlayerCombat = PlayerManager.player.GetComponent<CharacterCombat>();
        if (PlayerCombat != null)
        {
            PlayerCombat.Attack(myStats);
        }

    }
}
