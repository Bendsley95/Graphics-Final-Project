using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDown : MonoBehaviour {


    public GameObject CountDownBox;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject LapTimer;
    public GameObject CarControls;
   // public GameObject OtherCar;


	// Use this for initialization
	void Start () {

        StartCoroutine(CountStart());

	}


    IEnumerator CountStart()
    {
       // OtherCar.SetActive(false);
       // LapTimer.SetActive(false);
        yield return new WaitForSeconds(0.5f);

        CountDownBox.GetComponent<Text>().text = "3";

        GetReady.Play();
        CountDownBox.SetActive(true);

        yield return new WaitForSeconds(1);
        CountDownBox.SetActive(false);

        CountDownBox.GetComponent<Text>().text = "2";
        GetReady.Play();
        CountDownBox.SetActive(true);

        yield return new WaitForSeconds(1);
        CountDownBox.SetActive(false);

        CountDownBox.GetComponent<Text>().text = "1";
        GetReady.Play();
        CountDownBox.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDownBox.SetActive(false);
        GoAudio.Play();

        LapTimer.SetActive(true);
        CarControls.SetActive(true);
      //  OtherCar.SetActive(true);
    }
	
}
