namespace Wallboards.UI.Models
{
    public class UserData
    { 
        public UserData()
        {
        }

        public UserData(string id, string fio)
        {
            Id = id;
            FIO = fio; 
        }

        public string Id { get; set; } 
        public string FIO { get; set; }
    }
}