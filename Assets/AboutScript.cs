using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void BtnKembali()
    {
        // Mendapatkan indeks scene sebelumnya
        int indeksSceneSebelumnya = SceneManager.GetActiveScene().buildIndex - 2;

        // Memuat scene sebelumnya berdasarkan indeks
        SceneManager.LoadScene(indeksSceneSebelumnya);
    }
}
