using UnityEngine;



public class GameManager : MonoBehaviour
{
   
    public enum GameState { PAUSE, GAMEPLAY };
    public GameState state;
    private bool hasChangedState;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (state == GameState.GAMEPLAY)
        {
            hasChangedState = true;

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                
                state = GameState.PAUSE;
            }

        }
        else if (state == GameState.PAUSE)

        { 
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                state = GameState.GAMEPLAY;
            }
        }
    }

    private void LateUpdate()
    {
        if (hasChangedState)
        {
            hasChangedState = false;

            if (state == GameState.GAMEPLAY)
            {
                Time.timeScale = 1.0f;
            }
            else if (state == GameState.PAUSE)
            {
                Time.timeScale = 0.0f;
            }
        }
            
            
    }
}
