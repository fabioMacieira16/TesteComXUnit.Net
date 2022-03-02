namespace DevFrella.Infrastrucure.CloudServices
{
    public interface IFileStorageService
    {
        void UploadFile(byte[] bytes, string fileName);
    }
}
