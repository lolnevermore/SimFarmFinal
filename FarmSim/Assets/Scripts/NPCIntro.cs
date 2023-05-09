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
            dialogText1.text = "What's poppin', playa? You wanna know how to get you hands dirty and deep in the mud?";
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
                        dialogText2.text = "To move around, fiddle those WASD keys if you are using a keyboard and the analog stick if you are using a controller ";
                        dialogIndex++;
                        break;
                    case 1:
                        dialogBox2.SetActive(false);
                        dialogBox3.SetActive(true);
                        dialogText3.text = "To interact caress that Spacebar on keyboard or bottom face button on controller";
                        dialogIndex++;
                        break;
                    case 2:
                        dialogBox3.SetActive(false);
                        dialogBox4.SetActive(true);
                        dialogText4.text = "Just like always, the day goes by faster than you think and you got a quota to fill before its over";
                        dialogIndex++;
                        break;
                    case 3:
                        dialogBox3.SetActive(false);
                        dialogBox4.SetActive(true);
                        dialogText4.text = "Be careful, boss. Them foxes are maaaaad frisky, especially at night";
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
