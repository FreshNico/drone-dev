using UnityEngine.SceneManagement;
using UnityEngine;
using System.IO;

public class EndGame : MonoBehaviour
{
    string filename = "";
    public void OnTriggerEnter(Collider collision)
    {
        filename = Application.dataPath + "/test.csv";
        TextWriter tw = new StreamWriter(filename, true);

        if (collision.transform.tag == "Player")
        {
            tw.WriteLine(ReadInputCode.input + "," + GameManager.levelCount + "," + GameManager.adaptedRun + "," + "End Run" + "," + true + "," + RegularTimer.currentTime);
            tw.WriteLine(ReadInputCode.input + "," + GameManager.levelCount + "," + GameManager.adaptedRun + "," + "Score" + "," + Scoreboard.score + ",");

            tw.Close();

        }
    }

}
