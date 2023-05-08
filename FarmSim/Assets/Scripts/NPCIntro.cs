using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCIntro : MonoBehaviour
{
    public GameObject dialogBox1;
    public TextMeshProUGUI dialogText1;
    public GameObject dialogBox2;
    public TextMeshProUGUI dialogText2;
    public GameObject dialogBox3;
    public TextMeshProUGUI dialogText3;
    public GameObject dialogBox4;
    public TextMeshProUGUI dialogText4;
    public GameObject dialogBox5;
    public TextMeshProUGUI dialogText5;
    private bool hasTriggered = false;
    private int dialogIndex = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasTriggered)
        {
            dialogBox1.SetActive(true);
            dialogText1.text = "Hello, player! Do you know how to play? Do not worry if you don't, I will help you";
            hasTriggered = true;
            Time.timeScale = 0; // Pause player movement
        }
    }

    private void Update()
    {
        if (dialogBox1.activeInHierarchy || dialogBox2.activeInHierarchy || dialogBox3.activeInHierarchy || dialogBox4.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                switch (dialogIndex)
                {
                    case 0:
                        dialogBox1.SetActive(false);
                        dialogBox2.SetActive(true);
                        dialogText2.text = "To move around use WASD if you are using a keyboard and the analog stick if you are using a controller ";
                        dialogIndex++;
                        break;
                    case 1:
                        dialogBox2.SetActive(false);
                        dialogBox3.SetActive(true);
                        dialogText3.text = "To interact press Space on keyboard or X on controller";
                        dialogIndex++;
                        break;
                    case 2:
                        dialogBox3.SetActive(false);
                        dialogBox4.SetActive(true);
                        dialogText4.text = "The day runs fast and you must gather as many points as you can to be able to move to the next level";
                        dialogIndex++;
                        break;
                    case 3:
                        dialogBox3.SetActive(false);
                        dialogBox4.SetActive(true);
                        dialogText4.text = "But be careful, the forest is filled with dangerous creatures.";
                        dialogIndex++;
                        break;
                    case 4:
                        dialogBox5.SetActive(false);
                        Time.timeScale = 1; // Resume player movement
                        dialogIndex = 0;
                        break;



                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dialogBox1.SetActive(false);
            dialogBox2.SetActive(false);
            dialogBox3.SetActive(false);
            dialogBox4.SetActive(false);
            Time.timeScale = 1; // Resume player movement
            hasTriggered = false;
            dialogIndex = 0;
        }
    }
}
