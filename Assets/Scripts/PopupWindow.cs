using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupWindow : MonoBehaviour
{
    private Button btn;
    [SerializeField] private Button closeBtn;
    [SerializeField] private GameObject modal;
    private void Awake()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(OpenModal);
        closeBtn.onClick.AddListener(CloseModal);
    }

    private void OpenModal()
    {
        modal.SetActive(true);
    }
    private void CloseModal()
    {
        modal.SetActive(false);
    }
}
