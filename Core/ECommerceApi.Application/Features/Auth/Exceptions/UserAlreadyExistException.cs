﻿using ECommerceApi.Application.Bases;

namespace ECommerceApi.Application.Features.Auth.Exceptions
{
    public class UserAlreadyExistException : BaseException
    {

        public UserAlreadyExistException() : base("Böyle bir kullanıcı zaten var!") { }
        // bu bize özel bir exception fırlatmamıza olanak sağlıyor.

    }
}
