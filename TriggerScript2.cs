using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript2 : MonoBehaviour
{
    public GameObject uiObject;
    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        uiObject.SetActive(true);
        StartCoroutine("WaitForSec");
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(120);
        Destroy(uiObject);
        Destroy(gameObject);
    }
}
