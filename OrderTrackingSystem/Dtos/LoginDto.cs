using System.ComponentModel;

namespace OrderTrackingSystem.Dtos
{
    public class LoginDto
    {

        [DisplayName("帳號")]
        public string Account { get; set; }


        [DisplayName("密碼")]
        public string Password { get; set; }


    }
}
