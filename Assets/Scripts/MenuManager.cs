using Assets.Scripts.Enums;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] List<Button> tableButtons;
    // Start is called before the first frame update
    void Start()
    {
        for (int buttonIndex = 0; buttonIndex < tableButtons.Count; buttonIndex++)
        {
            Button button = tableButtons[buttonIndex];
            TableChoice tableChoice = (TableChoice)buttonIndex;
            button.onClick.AddListener(delegate { StartGame(tableChoice); });
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame(TableChoice tableChoice)
    {
        MainManager.Instance.tableChoice = tableChoice;
        SceneManager.LoadScene(1);
    }
}
