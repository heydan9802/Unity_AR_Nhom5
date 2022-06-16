using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public void MovetoScreen(int ID)
    {
        SceneManager.LoadScene(ID);
    }
}
