using Unity.IntegerTime;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    [SerializeField] private Button MenuButton;
    [SerializeField] private GameObject credits;
    private int rangeY;
    private float speed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        credits = GameObject.Find("Credits");
    }

    // Update is called once per frame
    void Update()
    {
        if(credits.transform.position.y <300)
        { 
            credits.transform.Translate(Vector3.up * speed * Time.deltaTime); 
        }

    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
