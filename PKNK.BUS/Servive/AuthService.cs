using PKNK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PKNK.BUS.Servive
{
    public class AuthService
    {
        // Đăng nhập
        public Auth Login(string username, string password)
        {
            PKNK_ContextDB db = new PKNK_ContextDB();
            string hashedPassword = HashPassword(password); // Mã hóa md5 để so sánh password trong DB
            return db.Auths.FirstOrDefault(u => u.username == username && u.password == hashedPassword);
        }

        // Đăng kí
        public void Register(string username, string password)
        {
            string hashedPassword = HashPassword(password);

            try{
                PKNK_ContextDB db = new PKNK_ContextDB();
                // Tạo mới user để add vào DB
                Auth newUser = new Auth
                {
                    username = username,
                    password = hashedPassword
                };
                db.Auths.Add(newUser);
                db.SaveChanges();
            }
            catch (Exception ex){
                throw new Exception(ex.Message);
            }
        }

        // Mã hóa password sang MD5
        private string HashPassword(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    sb.Append(data[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
