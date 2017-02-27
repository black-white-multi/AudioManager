using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour {
    public void StartBGM () {
        AudioManager.Instance.PlayBGM ("sample");
    }

    public void StopBGM () {
        AudioManager.Instance.StopBGM ();
    }
}