using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower_Sun : MonoBehaviour
{
    public float speed = 1f;
    public float deadSunTimeout = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Counter());
    }

    // Update is called once per frame
    private IEnumerator Counter()
    {
        yield return new WaitForSeconds(deadSunTimeout);
        Destroy(this.gameObject);
    }
    public void OnButtonDown()
    {
        SunWallet.sunCounter += 100;
        Destroy(this.gameObject);
    }
}
