﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    // where the camera looks at the tank from
    public GameObject cameraPosition;
    public LevelController.playerType ptype; // P1 or P2
    public int health;
    // angle of the arm
    public float angle;
    private bool isTurnOver;

    // called when the tank has no health
    void Die()
    {
        switch(ptype)
        {
            case LevelController.playerType.P1:
                LevelController.Instance.GameOver(LevelController.winCondition.P2_WIN);
                break;
            case LevelController.playerType.P2:
                LevelController.Instance.GameOver(LevelController.winCondition.P1_WIN);
                break;
        }

    }

    // subtract health from the tank.
    void Damage(int amt)
    {
        health -= amt;
        if (health <= 0)
            Die();
    }


    // changes the angle of the arm by "amt" degrees
    void ChangeAngle(float amt)
    {
        float animationDuration = 1; // in seconds

       // smoothly lerp between original and new angle
    }

    // moves the tank to the given position
    void Move(Vector3 pos)
    {

    }


    /*
    Starts the player's turn sequence. The player can do the following things
    during their turn:

    1) move the tank
    2) change the angle
    3) choose a weapon to shoot
    4) shoot the enemy

    Moving or shooting will use up your turn
    Changing the angle does NOT count as a use of your turn
    */
    void StartTurn()
    {
        // move the main camera to the tank's camera view location

        // dispay the turn UI

        //
    }

    void EndTurn()
    {
        // remove UI
    }
}
