
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;
    using TMPro;
   
    // Start is called before the first frame update
   

    // Update is called once per frame
   


    public class PlayerUI : MonoBehaviour
    {
        public TextMeshProUGUI coinsCounterText;
        public Slider healthSlider;
    
        public float maxHealth = 100;
        public float health;
        public int coins;

    void Update()
    {
        healthSlider.maxValue = maxHealth;
        healthSlider.value = health;

        coinsCounterText.text = coins.ToString();
    }
}    
        
    

