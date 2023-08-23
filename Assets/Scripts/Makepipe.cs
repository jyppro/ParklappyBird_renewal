using UnityEngine;

public class Makepipe : MonoBehaviour
{
    public GameObject Pipe;
    public float timeDiff;
    float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newpipe = Instantiate(Pipe);
            newpipe.transform.position = new Vector3(6, Random.Range(-3.3f, 4), 0);
            timer = 0;
            Destroy(newpipe, 10.0f);
        }
    }
}
