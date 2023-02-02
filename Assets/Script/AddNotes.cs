using System;
using Script;
using UnityEngine;

public class AddNotes : MonoBehaviour
{
    [SerializeField] private GameObject[] N;
    public GameObject NoteDog;
    public GameObject NoteCat;

    private int _index = 0;


    public void Add()
    {
        if (_index < 20)
        {
            N[_index].SetActive(true);
            _index++;
        }
    }

    public void Delete()
    {
        if (_index > 0)
        {
            N[_index].SetActive(false);
            _index--;
        }
    }

    public void SetTrueRW()
    {
        NoteCat.SetActive(true);
    }

    public void SetFalseRW()
    {
        NoteCat.SetActive(false);
    }

    public void SetFalse()
    {
       NoteDog.SetActive(false);
    }

    public void SetTrue()
    {
            NoteDog.SetActive(true);
    }
    
     public GameObject prefab;  // the prefab to generate

    void Start()
    {
        // Attach this script to a button in the scene
        // And add the prefab as a reference to the "prefab" field in the inspector
    }

    public void GenerateObject()
    {
        // Generate the prefab when the button is clicked
        Instantiate(prefab, transform.position, transform.rotation);
    }
}