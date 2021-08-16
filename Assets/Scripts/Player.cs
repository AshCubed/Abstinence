using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public Text multiplierText;
    public List<GameObject> tryFruit;
    public Slider multiplierBar;

    private Camera cam;
    Vector3 posX;

    public float fixedYPos;

    public GameObject gameOverCanavs;
    public Text gameOverFinalScoretxt;
    public List<GameObject> alcoholStrikes;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < alcoholStrikes.Count; i++)
        {
            alcoholStrikes[i].SetActive(false);
        }

        gameOverCanavs.SetActive(false);
        score = 0;
        cam = FindObjectOfType<Camera>().GetComponent<Camera>();

        TryFruitSet(1);
    }

    // Update is called once per frame
    void Update()
    {
        #region Movement

        posX = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, 0));

        if (posX.x <= 2.6 && posX.x >= -2.4)
        {
            transform.position = new Vector3(posX.x, fixedYPos, 0f);
        }

        //if (Input.GetKey(KeyCode.D))
        //{
        //    if (transform.position.x <= 2.6)
        //    {
        //        transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        //    }
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    if (transform.position.x >= -2.4)
        //    {
        //        transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
        //    }
        //}
        #endregion

        uiUpdates();

        Debug.Log("Multiplier" + multipler);
        Debug.Log("Progress" + multiplierBarProgress);
        Debug.Log(pastTag);
    }

    #region Multiplier Code
    int multipler = 1;
    float multiplierBarProgress = 0;

    void multiplierIncrease()
    {
        multiplierBarProgress += 0.2f;
        multiplierBar.value = multiplierBarProgress;

        if (multiplierBarProgress >= 1)
        {
            multiplierBarProgress = 0;
            multiplierBar.value = multiplierBarProgress;
            multipler += 1;
        }
    }

    void multiplierDecrease()
    {
        multiplierBarProgress = 0;
        multiplierBar.value = multiplierBarProgress;

        if (multipler >= 2)
        {
            multipler -= 1;
        }

    }
    #endregion

    string pastTag = null;
    int alcoholNum = 0;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Lemon Collision
        if (collision.gameObject.tag == "Lemon")
        {
            if (pastTag == "Orange" || pastTag == "GrapeFruit")
            {
                pastTag = collision.gameObject.tag;
                multiplierIncrease();
                score += 1 * multipler;
                TryFruitSet(1);
            }
            else
            {
                pastTag = collision.gameObject.tag;
                TryFruitSet(1);
                multiplierDecrease();
                score += 1;
            }

            scoreText.text = score.ToString();
            multiplierText.text = "x" + multipler.ToString();
            Destroy(collision.gameObject);
        }

        //Orange Collision
        if (collision.gameObject.tag == "Orange")
        {
            if (pastTag == "Lemon")
            {
                pastTag = collision.gameObject.tag;
                multiplierIncrease();
                score += 1 * multipler;
                TryFruitSet(0);
            }
            else
            {
                pastTag = collision.gameObject.tag;
                TryFruitSet(0);
                multiplierDecrease();
                score += 1;
            }

            scoreText.text = score.ToString();
            multiplierText.text = "x " + multipler.ToString();
            Destroy(collision.gameObject);
        }

        //Orange Collision
        if (collision.gameObject.tag == "GrapeFruit")
        {
            if (pastTag == "Lemon")
            {
                pastTag = collision.gameObject.tag;
                multiplierIncrease();
                score += 1 * multipler;
                TryFruitSet(0);
            }
            else
            {
                pastTag = collision.gameObject.tag;
                TryFruitSet(0);
                multiplierDecrease();
                score += 1;
            }

            scoreText.text = score.ToString();
            multiplierText.text = "x " + multipler.ToString();
            Destroy(collision.gameObject);
        }

        //Ice Cube Collision
        if (collision.gameObject.tag == "IceCube")
        {
            score += 1 * multipler;

            scoreText.text = score.ToString();
            multiplierText.text = "x " + multipler.ToString();
            Destroy(collision.gameObject);
        }

        //Alcohol Collision
        if (collision.gameObject.tag == "Alcohol")
        {
            pastTag = null;

            multiplierDecrease();
            score -= 1;
            scoreText.text = score.ToString();
            Destroy(collision.gameObject);
            alcoholStrikes[alcoholNum].SetActive(true);
            alcoholNum++;


            if (alcoholNum >= 3)
            {
                gameOverFinalScoretxt.text = "Final Score: " + score;
                gameOverCanavs.SetActive(true);
                Time.timeScale = 0;
            }
        }

    }

    void uiUpdates()
    {
        scoreText.text = score.ToString();
        multiplierBar.value = multiplierBarProgress;
        multiplierText.text = "x" + multipler.ToString();
    }

    void TryFruitSet(int num)
    {
        for (int i = 0; i < tryFruit.Count; i++)
        {
            tryFruit[i].SetActive(false);
        }

        tryFruit[num].SetActive(true);
    }
}
