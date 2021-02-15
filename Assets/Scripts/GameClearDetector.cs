using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearDetector : MonoBehaviour
{
    public Hole holeRed;
    public Hole holeBlue;
    public Hole holeGreen;

    private void OnGUI()
    {
        GUI.matrix = Matrix4x4.Scale(Vector3.one * 2);
        if(holeRed.IsHoldind() && holeBlue.IsHoldind() && holeGreen.IsHoldind())
        {
            Debug.Log("ゲームくりあ");
            GUI.Label(new Rect(50, 50, 100, 30), "GameClear!");
        }
    }

}
