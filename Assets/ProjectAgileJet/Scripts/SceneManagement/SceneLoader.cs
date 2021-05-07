using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEditor;

using YergoScripts.Audio;

namespace YergoScripts.SceneManagement
{
    [CreateAssetMenu(menuName = "YergoScripts/Scene Management/Scene Loader")]
    public class SceneLoader : ScriptableObject
    {
        int _LoadingSceneBuildIndex = 0;

        [CustomEditor(typeof(SceneLoader))]
        class SceneLoaderCustomEditor : Editor
        {
            public override void OnInspectorGUI()
            {
                SceneLoader sceneLoader = target as SceneLoader;
                
                if(!sceneLoader)
                    return;

                // Loading Scene
                int lastIndex;
                int extensionIndex;

                List<string> sceneNameList = new List<string>();

                foreach(EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
                {
                    lastIndex = scene.path.LastIndexOf('/') + 1;
                    extensionIndex = scene.path.IndexOf('.');

                    sceneNameList.Add(scene.path.Substring(lastIndex, extensionIndex - lastIndex));
                }

                sceneLoader._LoadingSceneBuildIndex = EditorGUILayout.Popup("Loading Scene", sceneLoader._LoadingSceneBuildIndex, sceneNameList.ToArray());
            }

            void UpdateLoadingScene()
            {

            }
        }

        void OnEnable() 
        {

        }

        public void LoadSceneSingle(int sceneBuildIndex)
        {
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }

        public void LoadSceneAdditive(int sceneBuildIndex)
        {
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Additive);
        }

        public void LoadSceneInLoadingScene(int sceneBuildIndex)
        {

        }
    }
}