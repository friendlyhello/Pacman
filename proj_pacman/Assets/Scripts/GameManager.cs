using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //** VARIABLES */
    
    // Object References 
    public Ghost[] ghosts;
    public Pacman pacman;
    public Transform pellets;
    
    // Getters-Setters
    public int Score { get; private set; }
    public int Lives { get; private set; }
    

    private void Start()
    {
        NewGame();
        Debug.Log("GAME START");
    }

    private void NewGame()
    {
        SetScore(0);
        SetLives(3);
        NewRound();
    }

    private void NewRound()
    {
        // Reset pellets
        foreach (Transform pellet in pellets) {
            pellet.gameObject.SetActive(true);
        }
        
        ResetState();
    }

    private void ResetState()
    {
        // Reset Ghosts
        for (int i = 0; i < this.ghosts.Length; i++) {
            ghosts[i].gameObject.SetActive(true);
        }

        // Reset Pacman
        pacman.gameObject.SetActive(true);
    }

    private void GameOver()
    {
        // TODO: Add functionality for UI
        
        // Hide Ghosts
        for (int i = 0; i < this.ghosts.Length; i++) {
            ghosts[i].gameObject.SetActive(false);
        }

        // Hide Pacman
        pacman.gameObject.SetActive(false);
    }
    private void SetScore(int score)
    {
        score = score;
    }

    private void SetLives(int lives)
    {
        lives = lives;
    }
    
    //** METHODS */
    
    
}
