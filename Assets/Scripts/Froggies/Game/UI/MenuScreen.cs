using Kodebolds.Core;
using Unity.Entities;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

namespace Froggies
{
    [RequireComponent(typeof(UIDocument))]
    public class MenuScreen : KodeboldBehaviour
    {
        private VisualElement rootVisualElement;
        private Button startButton;

        public override void GetBehaviourDependencies(Dependencies dependencies)
        {
        }

        public override void InitBehaviour()
        {
            // Root element of UI
            rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

            startButton = rootVisualElement.Q<Button>("StartButton");
            startButton.clickable.clickedWithEventInfo += StartGame;

        }

        public override void UpdateBehaviour()
        {

        }

        public override void FreeBehaviour()
        {
        }

        public void Hide()
        {
            rootVisualElement.style.display = DisplayStyle.None;
        }

        public void Show()
        {
            rootVisualElement.style.display = DisplayStyle.Flex;
        }

        // UI BUTTON ON CLICK EVENTS \\
        public void StartGame(EventBase eventBase)
        {
            this.Hide();
            SceneManager.UnloadSceneAsync("MainMenu");
            SceneManager.LoadScene("SampleScene");
        }
    }
}