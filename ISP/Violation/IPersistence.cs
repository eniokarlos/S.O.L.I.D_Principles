namespace ISP.Violation;

public interface IPersistence
{
    void SendEmail();
    void SaveInDataBase();
    void ValidateData();
}