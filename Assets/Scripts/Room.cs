using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Room : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("Room");
    }
}
