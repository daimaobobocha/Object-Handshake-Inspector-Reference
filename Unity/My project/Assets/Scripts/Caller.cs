using UnityEngine;

public class Caller : MonoBehaviour
{
    public Receiver receiver;

    void Start()
    {
        //print 'Hello Friend' on the console
        Debug.Log("Hello Friend");
        //Call the function OnCalled() in the file
        receiver.OnCalled();
    }
}
