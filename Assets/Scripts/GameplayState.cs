using UnityEditor;
using UnityEngine;
using static GameManager;

public class GameplayState : IGameState
{
    public void Enter(GameManager gm)
    {

        Debug.Log("Gameplay");
        Time.timeScale = 1f;

    }


    public void Update(GameManager gm)
    {

        /*if (Input.GetKeyDown(KeyCode.Escape))
            gm.ChangeState(new PauseState());
*/
    }

    public void Exit(GameManager gm)
    {



    }

    

}
