using UnityEditor.PackageManager;
using UnityEngine;

public class MyLoveBuilder : MonoBehaviour, IGirlChar
{
    [SerializeField] private GirlsInfo _girl;
    [SerializeField] private GirlsInfo _girl1;
    [SerializeField] private GirlsInfo _girl2;
    [SerializeField] private GirlsInfo _girl3;
    [SerializeField] private GirlsInfo _girl4;
    [SerializeField] private GirlsInfo _beautiful;
    [SerializeField] private GirlsInfo _smart;
    [SerializeField] private GirlsInfo _young;
    [SerializeField] private GirlsInfo _rich;
    [SerializeField] private GirlsInfo _charismatic;
    [SerializeField] private GirlsInfo _notjealous;
    [SerializeField] private GirlsInfo _purposeful;
    [SerializeField] private GirlsInfo _nicecoking;
    [SerializeField] private GirlsInfo _nicespeach;
    [SerializeField] private GirlsInfo _niceprogramming;
    [SerializeField] private GirlsInfo _playgames;


    public Girls Girl { get; private set; } = new Girls();

    public void Add()
    {
        InstanceProduct(_girl);
    }

    public void Add1()
    {
        InstanceProduct(_girl1);
    }

    public void Add2()
    {
        InstanceProduct(_girl2);
    }
    public void Add3()
    {
        InstanceProduct(_girl3);
    }
    public void Add4()
    {
        InstanceProduct(_girl4);
    }

    public void AddBeautiful()
    {
        InstanceProduct(_beautiful);
    }

    public void AddSmart()
    {
        InstanceProduct(_smart);
    }
    public void AddYoung()
    {
        InstanceProduct(_young);
    }

    public void AddRich()
    {
        InstanceProduct(_rich);
    }

    public void AddCharismatic()
    {
        InstanceProduct(_charismatic);
    }
    public void AddNotJealous()
    {
        InstanceProduct(_notjealous);
    }

    public void AddPurposeful()
    {
        InstanceProduct(_purposeful);
    }

    public void AddNiceCoking()
    {
        InstanceProduct(_nicecoking);
    }
    public void AddNiceSpeach()
    {
        InstanceProduct(_nicespeach);
    }

    public void AddNiceProgramming()
    {
        InstanceProduct(_niceprogramming);
    }

    public void AddPlayGames()
    {
        InstanceProduct(_playgames);
    }

    public void Reset()
    {
        Girl = new Girls();
    }

    private void InstanceProduct(GirlsInfo reference)
    {
        var instance = new GirlsInfo(reference.Name, reference.Stars);
        Girl.Add(instance);
    }
}
