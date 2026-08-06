using UnityEngine;

public class MenuNavigator : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject techniquesPanel;
    [SerializeField] private GameObject experimentsPanel;
    [SerializeField] private GameObject revisionPanel;

    public void ShowMainMenu() => Switch(mainMenuPanel);
    public void ShowTechniques() => Switch(techniquesPanel);
    public void ShowExperiments() => Switch(experimentsPanel);
    public void ShowRevision() => Switch(revisionPanel);

    private void Switch(GameObject target)
    {
        mainMenuPanel.SetActive(target == mainMenuPanel);
        techniquesPanel.SetActive(target == techniquesPanel);
        experimentsPanel.SetActive(target == experimentsPanel);
        revisionPanel.SetActive(target == revisionPanel);
    }
}