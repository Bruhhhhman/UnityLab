using UnityEngine;

[System.Serializable]
public class GirlsInfo
{
    [SerializeField] private string _name;
    [SerializeField] private int _stars;

    public string Name => _name;
    public int Stars => _stars;

    public GirlsInfo(string name, int stars)
    {
        _name = name;
        _stars = stars;
    }
}
