using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//外观模式
namespace DesignPattern.Example.Pattern
{
    public class SceneLoader
    {
        public void LoadScene(string sceneName)
        {
            Debug.Log("Loading Scene " + sceneName);
        }
    }

    public class SoundManager
    {
        public void PlaySound(string soundName)
        {
            Debug.Log("Playing Sound " + soundName);
        }
    }

    public class ResourceManager
    {
        public void LoadResource(string resourceName)
        {
            Debug.Log("Loading Resource " + resourceName);
        }
    }

    public class GameFacade
    {
        private SceneLoader _sceneLoader;
        private SoundManager _soundManager;
        private ResourceManager _resourceManager;

        public GameFacade()
        {
            _sceneLoader = new SceneLoader();
            _soundManager = new SoundManager();
            _resourceManager = new ResourceManager();
        }

        public void StartGame(string sceneName, string soundName, string resourceName)
        {
            _sceneLoader.LoadScene(sceneName);
            _soundManager.PlaySound(soundName);
            _resourceManager.LoadResource(resourceName);
        }
    }
}
