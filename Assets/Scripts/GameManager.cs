using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject TitleScreen, Level1, Result1, Result2, Level2, Result3, Result4, Level3, Result5, Result6, Ending1, Level4, Result7, Result8, Ending2, Finale, Ending3, Ending4;
    // Start is called before the first frame update
    void Start()
    {
        TitleScreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGameButton()
    {
        TitleScreen.SetActive(false);
        Level1.SetActive(true);
    }
    public void Button_1()
    {
        Level1.SetActive(false);
        Result1.SetActive(true);
    }
    public void Button_2()
    {
        Level1.SetActive(false);
        Result2.SetActive(true);
    }
    public void Button_3()
    {
        Result1.SetActive(false);
        Level2.SetActive(true);
    }
    public void Button_4()
    {
        Result2.SetActive(false);
        Level2.SetActive(true);
    }
    public void Button_5()
    {
        Level2.SetActive(false);
        Result3.SetActive(true);
    }
    public void Button_6()
    {
        Level2.SetActive(false);
        Result4.SetActive(true);
    }
    public void Button_7()
    {
        Result3.SetActive(false);
        Level3.SetActive(true);
    }
    public void Button_8()
    {
        Result4.SetActive(false);
        Level3.SetActive(true);
    }
    public void Button_9()
    {
        Level3.SetActive(false);
        Result5.SetActive(true);
    }
    public void Button_10()
    {
        Level3.SetActive(false);
        Result6.SetActive(true);
    }
    public void Button_11()
    {
        Result5.SetActive(false);
        Level4.SetActive(true);
    }
    public void Button_12()
    {
        Result6.SetActive(false);
        Ending1.SetActive(true);
    }
    public void ReplayButton1()
    {
        Ending1.SetActive(false);
        TitleScreen.SetActive(true);
    }
    public void Button_13()
    {
        Level4.SetActive(false);
        Result7.SetActive(true);
    }
    public void Button_14()
    {
        Level4.SetActive(false);
        Result8.SetActive(true);
    }
    public void Button_15()
    {
        Result7.SetActive(false);
        Finale.SetActive(true);
    }
    public void Button_16()
    {
        Result8.SetActive(false);
        Ending2.SetActive(true);
    }
    public void ReplayButton2()
    {
        Ending2.SetActive(false);
        TitleScreen.SetActive(true);
    }
    public void Button_17()
    {
        Finale.SetActive(false);
        Ending3.SetActive(true);
    }
    public void ReplayButton3()
    {
        Ending3.SetActive(false);
        TitleScreen.SetActive(true);
    }
    public void Button_18()
    {
        Finale.SetActive(false);
        Ending4.SetActive(true);
    }
    public void ReplayButton4()
    {
        Ending4.SetActive(false);
        TitleScreen.SetActive(true);
    }
    public void ExitButton() {
        Application.Quit();

    }
}
