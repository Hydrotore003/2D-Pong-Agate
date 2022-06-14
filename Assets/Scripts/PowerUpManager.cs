using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public Transform spawnArea;
    public Vector2 powerUpAreaMin;
    public Vector2 powerUpAreaMax;
    public int maxPowerUpAmount;
    public List<GameObject> powerUpTemplateList;
    private List<GameObject> powerUpList;
    public int spawnInterval;
    private float timer;
    private int amount;

    private void Start()
    {
        powerUpList = new List<GameObject>();
        timer = 0;
    }

    private async void Update() 
    { 
        timer += Time.deltaTime;

        if (timer > spawnInterval)
        {
            GenerateRandomPowerUp();

            if (powerUpList.Count < 2 || powerUpList.Count > 0)
            {
                Invoke("RemoveIfOne", 10);
                Invoke("GenerateRandomPowerUp", 5);
                
            }

            if (powerUpList.Count < 3 || powerUpList.Count > 1)
            {
                Invoke("RemoveIftwo", 10);
                Invoke("GenerateRandomPowerUp", 5);
            }
            else
            {
                return;
            }
            timer = 0;
        }
       
    }

    public void GenerateRandomPowerUp()
    {
        GenerateRandomPowerUp(new Vector2(Random.Range(powerUpAreaMin.x, powerUpAreaMax.x), Random.Range(powerUpAreaMin.y, powerUpAreaMax.y)));
    }

    public void GenerateRandomPowerUp(Vector2 position)
    {
        if (powerUpList.Count >= maxPowerUpAmount)
        {
            return;
        }

        if (position.x < powerUpAreaMin.x || position.x > powerUpAreaMax.x || position.y < powerUpAreaMin.y || position.y > powerUpAreaMax.y)
        {
            return;
        }

        int randomIndex = Random.Range(0, powerUpTemplateList.Count);

        GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex], new Vector3(position.x, position.y, powerUpTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea);
        powerUp.SetActive(true);

        powerUpList.Add(powerUp);
    }

    public void RemovePowerUp(GameObject powerUp)
    {
        powerUpList.Remove(powerUp);
        Destroy(powerUp);
    }

    public void RemoveAllPowerUp()
    {
        while (powerUpList.Count > 0)
        {
            RemovePowerUp(powerUpList[0]);
        }
    }

    public void RemoveIfOne()
    {
        RemovePowerUp(powerUpList[0]);
    }

    public void RemoveIfTwo()
    {
        RemovePowerUp(powerUpList[1]);
    }

}
