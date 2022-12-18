using System.Collections.Generic;

public class Girls
{
    private List<GirlsInfo> _charact = new List<GirlsInfo>();

    public void Add(GirlsInfo product)
    {
        _charact.Add(product);
    }
    public string[] GetPurchaseData()
    {
        string[] data = new string[_charact.Count];

        for (int i = 0; i < data.Length; i++)
        {
            data[i] = "Name: " + _charact[i].Name + " || " + _charact[i].Stars.ToString();
        }
        return data;
    }
}
