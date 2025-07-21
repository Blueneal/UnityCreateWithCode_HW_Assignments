using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;
public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshPro scoreText;

    private int score;
    private float spawnRate = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        StartCoroutine(SpawnTarget());
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }
}
