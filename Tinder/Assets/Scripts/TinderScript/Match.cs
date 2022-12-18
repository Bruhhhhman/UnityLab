using UnityEngine;
using static UnityEditor.ObjectChangeEventStream;

public class Match : MonoBehaviour
{
    [SerializeField] private GameObject _builderObj;
    private void Start()
    {
        var builder = _builderObj.GetComponent<MyLoveBuilder>();
        if (_builderObj == null) return;
        GirlGeneral(builder);
        Girl0(builder);
        Girl1(builder);
        Girl2(builder);
        Girl3(builder);
        Girl4(builder);
    }

    private void GirlGeneral(MyLoveBuilder builder)
    {
        builder.Add();
        builder.AddBeautiful();
        builder.AddSmart();
        builder.AddYoung();
        builder.AddRich();
        builder.AddCharismatic();
        builder.AddNotJealous();
        builder.AddPurposeful();
        builder.AddNiceCoking();
        builder.AddNiceSpeach();
        builder.AddNiceProgramming();
        builder.AddPlayGames();

        PrintDataSale(builder);

        builder.Reset();
    }
    private void Girl0(MyLoveBuilder builder)
    {
        builder.Add();

        PrintDataSale(builder);

        builder.Reset();
    }
    private void Girl1(MyLoveBuilder builder)
    {
        builder.Add1();
        builder.AddNotJealous();
        builder.AddPurposeful();
        builder.AddPlayGames();

        PrintDataSale(builder);

        builder.Reset();
    }
    private void Girl2(MyLoveBuilder builder)
    {
        builder.Add2();
        builder.AddBeautiful();
        builder.AddNotJealous();
        builder.AddNiceCoking();
        builder.AddYoung();

        PrintDataSale(builder);

        builder.Reset();
    }
    private void Girl3(MyLoveBuilder builder)
    {
        builder.Add3();
        builder.AddSmart();
        builder.AddYoung();
        builder.AddRich();
        builder.AddCharismatic();

        PrintDataSale(builder);

        builder.Reset();
    }
    private void Girl4(MyLoveBuilder builder)
    {
        builder.Add4();
        builder.AddYoung();
        builder.AddNiceSpeach();
        builder.AddNiceProgramming();
        builder.AddPlayGames();

        PrintDataSale(builder);

        builder.Reset();
    }

    public void PrintDataSale(MyLoveBuilder builder)
    {
        var data = builder.Girl.GetPurchaseData();

        print("Подобрана новая девушка!!!");

        for (int i = 0; i < data.Length; i++)
        {
            print(data[i]);
        }
    }
}
