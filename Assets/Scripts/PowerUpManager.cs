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
    public int spawnInverval2;
    private float timer;
    private float timer2;
    private int amount;

    private void Start()
    {
        powerUpList = new List<GameObject>();
        timer = 0;
        timer2 = 0;
    }

    private async void Update() 
    { 
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;

        if (timer > spawnInterval)
        {
            GenerateRandomPowerUp();
            
            timer = 0;
        }

        if (timer2 > spawnInverval2)
        {
            //maxPowerUpAmount += 1;
            RemoveAllPowerUp();
            timer2 = spawnInverval2 - (2 * spawnInterval);
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
        if (powerUpList.Count > 0)
        {
            RemovePowerUp(powerUpList[0]);
        }
    }
}
