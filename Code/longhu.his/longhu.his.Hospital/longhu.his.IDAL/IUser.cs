using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using longhu.his.Model;

namespace longhu.his.IDAL
{
    public interface IUser
    {
        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="user">新建用户对象</param>
        /// <returns></returns>
        int Create(sys_users user);

        /// <summary>
        /// 通过系统登录账号、密码查询用户信息
        /// </summary>
        /// <param name="userName">系统登录账号</param>
        /// <param name="password"></param>
        /// <returns></returns>
        sys_users Get(string userName, string password);

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="user">被修改用户对象</param>
        /// <returns></returns>
        int Update(sys_users user);
    }
}
