using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.PlayerLoop;

public class DiamanteUIController : MonoBehaviour
{
    [SerializeField] private TMP_Text diamanteText;

    private void OnEnable()
    {
        PlayerObserverManager.OnDiamantesChanged += UpdateDiamanteText;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnDiamantesChanged -= UpdateDiamanteText;
    }

    private void UpdateDiamanteText(int newDiamantesValue)
    {
        diamanteText.text = newDiamantesValue.ToString();
    }
}
