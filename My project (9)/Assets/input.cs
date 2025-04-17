using UnityEngine;

public class input : MonoBehaviour




{

    public string input_bn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    public void input_s (string s) {

        input_bn = s;
        Debug.Log(input_bn);

        }
}
