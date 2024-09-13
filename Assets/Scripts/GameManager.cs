using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

namespace Chapter.Singleton
{
    public class GameManager : Singleton<GameManager>
    {
        private DateTime _sessionStartTime;
        private DateTime _sessionEndTime;
        void Start()
        {
            _sessionStartTime = DateTime.Now;
            Debug.Log("Game session start time @: " + DateTime.Now);

        }
        private void OnApplicationQuit()
        {
            _sessionEndTime = DateTime.Now;

            TimeSpan timeDifference = _sessionEndTime.Subtract(_sessionStartTime);
            Debug.Log("Game session ended @: " + DateTime.Now);
            Debug.Log("Session Duration: " + timeDifference);
        }

        void OnGUI()
        {
            GUILayout.BeginArea(new Rect(100, 100, 100, 100));
            if(SceneManager.sceneCountInBuildSettings - 1>SceneManager.GetActiveScene().buildIndex)
            {
                if (GUILayout.Button("Next: " + GetNextSceneName()))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
            else
            {
                if (GUILayout.Button("Next: " + GetSceneNameByIndex(1)))
                {
                    SceneManager.LoadScene(1);
                }
            }
            GUILayout.EndArea();
        }

        // Pulled from https://discussions.unity.com/t/how-to-get-scene-name-at-certain-buildindex/175723/2
        // Still doesnt work tho ;w;
        private static string GetSceneNameByIndex(int buildIndex)
        {
            if (buildIndex > SceneManager.sceneCountInBuildSettings - 1)
            {
                Debug.LogErrorFormat("Incorrect buildIndex {0}!", buildIndex);
                return null;
            }

            var scene = SceneManager.GetSceneByBuildIndex(buildIndex);
            return scene.name;
        }

        private static string GetNextSceneName()
        {
            return GetSceneNameByIndex(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
