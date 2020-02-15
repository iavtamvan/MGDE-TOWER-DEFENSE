using UnityEngine;
public class TowerDestroy : MonoBehaviour
{
    public bool isPlayer = true;
    private void OnDestroy()
    {
        if (!Data.isGameOver)
            if (isPlayer)
            {
                Data.isGameOver = true;
                Data.isComplate = false;
                Debug.Log("Player Lost");
            }
            else
            {
                Data.isGameOver = true;
                Data.isComplate = true;
                Debug.Log("Player Win");
            }
    }
}