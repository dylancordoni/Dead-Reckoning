using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class CreatePanel : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput, maxPlayersInput;
    //[SerializeField] private TMP_Dropdown _typeDropdown, _difficultyDropdown;

    private void Start()
    {
        //SetOptions(_typeDropdown, Constants.GameTypes);
        //SetOptions(_difficultyDropdown, Constants.Difficulties);

        //void SetOptions(TMP_Dropdown dropdown, IEnumerable<string> values)
        //{
        //    dropdown.options = values.Select(type => new TMP_Dropdown.OptionData { text = type }).ToList();
        //}
    }

    public static event Action<LobbyData> LobbyCreated;

    public void OnCreateClicked()
    {
        var lobbyData = new LobbyData
        {
            Name = nameInput.text,
            MaxPlayers = int.Parse(maxPlayersInput.text),
            //Difficulty = _difficultyDropdown.value,
            //Type = _typeDropdown.value
        };

        LobbyCreated?.Invoke(lobbyData);
    }
}

public struct LobbyData
{
    public string Name;
    public int MaxPlayers;
    public int Difficulty;
    public int Type;
}
