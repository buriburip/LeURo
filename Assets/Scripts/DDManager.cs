using UnityEngine;

public class DDManager : MonoBehaviour {

    public GameObject gameObject1;
    public GameObject gameObject2;

    void Start () {
        DontDestroyOnLoad(gameObject1);
        DontDestroyOnLoad(gameObject2);
    }

}