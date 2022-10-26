using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private float CollectibleCount = 0;
    [SerializeField] private float points = 0;
    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        var colls = GetComponentsInChildren<Collectible>();
        CollectibleCount = colls.Length;

        foreach(Collectible coll in colls)
        {
            coll.gameController = this;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updatePoints()
    {
        points++;
        if (points == CollectibleCount)
        {
            canvas.gameObject.SetActive(true);
        }
    }
}
