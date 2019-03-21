using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardApp
{
    interface ILogin
    {
        //初始化{用户登陆信息保存在setting里面}
        Login InitParam();
        //是否显示界面
        void ShowLoginView(bool IsShow);
        //是否显示忘记密码
        void ShowForgetPsw(bool IsShow);
        //是否显示注册账号
        void ShowRegister(bool IsShow);
        //是否显示记住密码
        void ShowRememberPsw(bool IsShow);
        //是否显示自动登陆
        void ShowAutoLogin(bool IsShow);
        //登陆验证
        User JudgePsw(Login login);
    }
}
