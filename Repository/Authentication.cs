
//using ispat.DTO.Authentication;
//using ispat.IRepository;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace ispat.Repository
//{
//    public class Authentication : IAuthentication
//    {
//        private readonly ReadWriteContext _context;
//        public Authentication(ReadWriteContext Context)
//        {
//            _context = Context;
//        }
//        public async Task<string> LogIn(LogInDTO obj)
//        {
//            var data = await Task.FromResult(_context.Credential.FirstOrDefault(x => x.MobileNumber == obj.MobileNumber && x.Password == obj.Password && x.IsBlock == false));

//            if (data != null)
//                return $"Log in as {data.UserName}";
//            return $"Invalid Credential!";
//        }
//    }
//}
