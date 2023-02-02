using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MenuPagesController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _pages;

    public static MenuPagesController instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void Open(string pageName, bool over)
    {
        var page = _pages.Where(x => x.name == pageName).FirstOrDefault();
        if (page == default)
        {
            throw new KeyNotFoundException($"Page With Name '{pageName}' Not Found!");
        }
        else
        {
            page.SetActive(true);
            if (!over)
            {
                foreach(var p in _pages.Where(x => x != page))
                {
                    p.SetActive(false);
                }
            }
        }
    }

    public void Open(string pageName) => Open(pageName, false);

    public void OpenOver(string pageName) => Open(pageName, true);

    public void Close(string pageName)
    {
        var page = _pages.Where(x => x.name == pageName).FirstOrDefault();

        if (page == default)
        {
            throw new KeyNotFoundException($"Page With Name '{pageName}' Not Found!");
        }
        else
        {
            page.SetActive(false);
        }
    }
}
