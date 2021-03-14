using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public AudioSource buttonSound;

    public void Exit()
    {
        buttonSound.Play();
        Application.Quit();
    }


    public void Play()
    {
        buttonSound.Play();
        SceneManager.LoadScene("Game");
    }

}

/*
Reference Sound
Freesound. 2021. Button Click 3 by Mellau, 14 February 2020. [Online]. Available at: https://freesound.org/people/Mellau/sounds/506052/.
[Accessed 11 March 2021].

*/
