using DctApi.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Repositories.Interfaces
{
    public interface IUserRepository
    {
        void DangKy(UserEntity user);
        bool DangNhap(UserEntity user);
    }
}
